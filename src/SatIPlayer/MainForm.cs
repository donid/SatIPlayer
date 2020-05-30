using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Vlc.DotNet.Core.Interops;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Vlc.DotNet.Core.Interops.Signatures;


// todo:
// support displaying multiple streams?
// stream recording
// channel mosaic: automatically switch channel, record 10s (or screenshot) -> display all the recordings at once in an endless loop
// show vlc debug log in GUI
// support multiple server simultaneously?
// mainwindow: snap to screen borders?

namespace SatIPlayer
{
	public partial class MainForm : XtraForm
	{
		//string _satIpServerAndPort = "192.168.178.53";// triax / dvbviewer uses port :554 - VLC does not require the port to be specified
		string _satIpServerAndPort;//= "192.168.178.99";// xoro / dvbviewer uses port :554 - VLC does not require the port to be specified
		string _favoritesFilePath = "satip_favorites.json";
		string _configFilePath = "satip_config.json";

		private List<ChannelInfo> _favoriteChannels;
		private ServerConfig _serverConfig = new ServerConfig();
		private bool _tracksListIsVisible;


		public MainForm()
		{
			InitializeComponent();

			string json = File.ReadAllText("satip_servers.json");
			var _serverInfos = JsonConvert.DeserializeObject<List<ServerInfo>>(json);
			_serverConfig.ServerInfos = _serverInfos;
			AdjustToNewServer();

			UpdateVolumeGui();
		}

		private void AdjustToNewServer()
		{
			ServerInfo activeServerInfo = _serverConfig.ServerInfos[_serverConfig.ActiveServerIndex];
			_satIpServerAndPort = activeServerInfo.UriAndPort;
			barStaticItem1.Caption = activeServerInfo.Description;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (File.Exists(_favoritesFilePath))
			{
				string json = File.ReadAllText(_favoritesFilePath);
				_favoriteChannels = JsonConvert.DeserializeObject<List<ChannelInfo>>(json);

				BuildFavoritesMenu();
			}

			if (File.Exists(_configFilePath))
			{
				string configJson = File.ReadAllText(_configFilePath);
				var satipConfig = JsonConvert.DeserializeObject<SatipConfig>(configJson);
				// this does not work in ctor!
				if (satipConfig.WindowState == FormWindowState.Normal)
				{
					this.Location = new Point(satipConfig.LocationX, satipConfig.LocationY);
					this.Size = new Size(satipConfig.SizeWidth, satipConfig.SizeHeight);
				}
				else
				{
					this.Location = new Point(satipConfig.RestoreBounds.X, satipConfig.RestoreBounds.Y);
					this.Size = new Size(satipConfig.RestoreBounds.Width, satipConfig.RestoreBounds.Height);

				}
				this.WindowState = satipConfig.WindowState;
			}

			vlcControl7.VlcMediaPlayer.PositionChanged += VlcMediaPlayer_PositionChanged;
		}

		private void VlcMediaPlayer_PositionChanged(object sender, VlcMediaPlayerPositionChangedEventArgs e)
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action(() =>
				   {
					   barEditItemPosition.EditValue = e.NewPosition * 100.0;
				   }));
			}
		}

		private void vlcControl7_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
		{
			Assembly entryAssembly = Assembly.GetEntryAssembly();
			string binaryDirectory = new FileInfo(entryAssembly.Location).DirectoryName;
			// Default installation path of VideoLAN.LibVLC.Windows
			string vlcLibDirectory = Path.Combine(binaryDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64");
			if (!Directory.Exists(vlcLibDirectory))
			{
				if (IntPtr.Size == 4)
				{
					vlcLibDirectory = @"C:\Program Files (x86)\VideoLAN\VLC";
				}
				else
				{
					vlcLibDirectory = @"C:\Program Files\VideoLAN\VLC";
				}
			}
			if (!Directory.Exists(vlcLibDirectory))
			{
				timer1.Enabled = false;
				MessageBox.Show(this, "vlc / libvlc not found!", "SatIPlayer");
				Environment.Exit(0);
			}
			e.VlcLibDirectory = new DirectoryInfo(vlcLibDirectory);
		}


		private void repositoryItemProgressBar1_MouseDown(object sender, MouseEventArgs e)
		{
			int newPercentage = (int)GetNewVolumeValue(e.X);
			barEditItemVolume.EditValue = newPercentage;
			vlcControl7.VlcMediaPlayer.Audio.Volume = newPercentage;
			//mousePressed = true;
		}

		double GetNewVolumeValue(int x)
		{
			double value = x * 1.0 / barEditItemVolume.Width;
			int max = repositoryItemProgressBar1.Maximum;
			int min = repositoryItemProgressBar1.Minimum;
			return min + value * (max - min);
		}

		private void UpdateVolumeGui()
		{
			barEditItemVolume.EditValue = vlcControl7.Audio.Volume;
		}


		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			// does not work for timeshift:
			// https://trac.videolan.org/vlc/ticket/9707
			// "EsOutTimeshift does not yet support time change"
			// https://www.java-forum.org/thema/timeshift-vlcj.175253/
			// workaround: increase playback speed

			const double f = 1.0; //1.2244; determined by experiments // varies heavily between different files!
			if (keyData == Keys.Left)
			{
				vlcControl7.VlcMediaPlayer.Time -= (int)(10 * 1000 * f);
				return true;
			}
			else if (keyData == Keys.Right)
			{
				vlcControl7.VlcMediaPlayer.Time += (int)(10 * 1000 * f);
				return true;
			}
			else if (keyData == Keys.Up)
			{
				vlcControl7.VlcMediaPlayer.Time += (int)(60 * 1000 * f);
				return true;
			}
			else if (keyData == Keys.Down)
			{
				vlcControl7.VlcMediaPlayer.Time -= (int)(60 * 1000 * f);
				return true;
			}
			else if (keyData == Keys.PageUp)
			{
				vlcControl7.VlcMediaPlayer.Time += (int)(10 * 60 * 1000 * f);
				return true;
			}
			else if (keyData == Keys.PageDown)
			{
				vlcControl7.VlcMediaPlayer.Time -= (int)(10 * 60 * 1000 * f);
				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 'm')
			{
				barButtonItemMute.Down = !barButtonItemMute.Down;
				UpdateVlcMuteState();
				e.Handled = true;
			}
			else if (e.KeyChar == '*')
			{
				// increase playback speed
				vlcControl7.Rate *= 1.4f;
				e.Handled = true;
			}
			else if (e.KeyChar == '_')
			{
				// decrease playback speed
				vlcControl7.Rate /= 1.4f;
				e.Handled = true;
			}
			else if (e.KeyChar == '+')
			{
				vlcControl7.VlcMediaPlayer.Audio.Volume = Math.Min(vlcControl7.VlcMediaPlayer.Audio.Volume + 5, repositoryItemProgressBar1.Maximum);
				UpdateVolumeGui();
				e.Handled = true;
			}
			else if (e.KeyChar == '-')
			{
				vlcControl7.VlcMediaPlayer.Audio.Volume -= 5;
				UpdateVolumeGui();
				e.Handled = true;
			}
			else if (e.KeyChar == '.')
			{
				vlcControl7.VlcMediaPlayer.NextFrame();
				e.Handled = true;
			}
			else if (e.KeyChar == ' ')
			{
				TogglePausePlay();
				e.Handled = true;
			}
		}

		private void barButtonItemMute_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			UpdateVlcMuteState();
		}

		private void UpdateVlcMuteState()
		{
			bool isMute = vlcControl7.VlcMediaPlayer.Audio.IsMute;
			if ((barButtonItemMute.Down && !isMute) || (!barButtonItemMute.Down && isMute))
			{
				vlcControl7.VlcMediaPlayer.Audio.ToggleMute();
			}
		}

		private void barButtonItemChannels_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			List<ChannelInfo> channelList = Helpers.LoadChannellist();
			var form = new ChannelsForm();
			form.Channels = channelList;
			form.FavoriteChannels = _favoriteChannels;
			form.ShowDialog(this);
			_favoriteChannels = form.FavoriteChannels;

			string json = JsonConvert.SerializeObject(_favoriteChannels, Formatting.Indented);
			File.WriteAllText(_favoritesFilePath, json);

			BuildFavoritesMenu();

			if (form.SelectedEntry == null)
			{
				return;
			}
			ChannelInfo selectedChannel = form.SelectedEntry;
			ActivateChannel(selectedChannel);
		}

		private void BuildFavoritesMenu()
		{
			barListItemFavorites.Strings.Clear();
			foreach (ChannelInfo channelInfo in _favoriteChannels)
			{
				barListItemFavorites.Strings.Add(channelInfo.Name);
			}
		}

		private void ActivateChannel(ChannelInfo channel)
		{
			barEditItemPosition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			vlcControl7.Stop();

			string m3uUriString = channel.Url;
			// rtsp:// works with xoro even when an other client is already recording /  when using triax, vlc always plays the currently recorded stream
			// satip:// seems to always create a new stream even with triax

			// satip needs to be allowed by a custom Firewall-rule: see readme.md
			string uriString = m3uUriString.Replace("sat.ip", _satIpServerAndPort).Replace("rtsp://", "satip://");//.Replace("src=1", "src=2");
			vlcControl7.Play(new Uri(uriString));
			barStaticItemChannelName.Caption = channel.Name;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{

			// vlcControl7.Position*100 is the position in % :
			// pos: {vlcControl7.Position}


			TimeSpan time = Helpers.ConvertVlcTime(vlcControl7.VlcMediaPlayer.Time);
			TimeSpan length = Helpers.ConvertVlcTime(vlcControl7.VlcMediaPlayer.Length);
			//length is always '0' for satip, but time-values are plausible
			barStaticItemTime.Caption = $"Time: {time:hh\\:mm\\:ss} Length: {length:hh\\:mm\\:ss}";

			// no plausible values: aspect:{vlcControl7.Video.AspectRatio}
			float playbackSpeed = vlcControl7.Rate * 100.0f;
			barStaticItemVolume.Caption = $"fps: {vlcControl7.VlcMediaPlayer.FramesPerSecond} AudioTracks: {vlcControl7.Audio.Tracks.Count} Speed: {playbackSpeed:0}%";

			VlcMedia media = vlcControl7.GetCurrentMedia();
			if (media != null)
			{
				//barStaticItemAudio.Caption = "Audio: " + string.Join(",", media.Tracks.Where(item => item.Type == MediaTrackTypes.Audio).Select(item => item.Language));

				//TODO
				//Mrl
				//media.TracksInformations
				barStaticItemFileStatus.Caption = media.NowPlaying;
				barStaticItemChannelName.Caption = media.Publisher;
				var stat = media.Statistics;
				Trace.WriteLine($"DemuxCorrupted:{stat.DemuxCorrupted} DemuxDiscontinuity:{stat.DemuxDiscontinuity} InputBitrate:{stat.InputBitrate} LostAudioBuffers:{stat.LostPictures} LostAudioBuffers:{stat.LostPictures}");
			}
			else
			{

			}

			if (!_tracksListIsVisible)
			{
				BuildAudioTracksMenu();
			}
		}


		private void barButtonServer_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			ServersForm form = new ServersForm();
			form.SetServerConfig(_serverConfig);
			form.ShowDialog(this);
			AdjustToNewServer();


			//vlc uses "urn:schemas-upnp-org:device:MediaServer:1"
			//var devices = await new UPnP.Ssdp().SearchDevicesAsync("urn:schemas-upnp-org:device:MediaServer:1");
			//IEnumerable<UPnP.Device> devices = await new UPnP.Ssdp().SearchDevicesAsync("urn:ses-com:device:SatIPServer:1");

			// .BaseUrl.Host

			//		devices	Count = 2	System.Collections.Generic.IEnumerable<UPnP.Device> {System.Collections.Generic.List<UPnP.Device>}
			//		[0]	{DVBViewer Media Server (WIN8)}	UPnP.Device
			//		DeviceType	"urn:ses-com:device:SatIPServer:1"	string
			//		FriendlyName	"DVBViewer Media Server (WIN8)"	string
			//		Icons	{UPnP.Icon[4]}	UPnP.Icon[]
			//		Manufacturer	"cmuv"	string
			//		ManufacturerURL	"http://www.dvbviewer.com/"	string
			//		ModelDescription	"DVBViewer Mediaserver"	string
			//		ModelName	"DVBViewer Mediaserver"	string
			//		ModelNumber	"2.0"	string
			//		ModelURL	"http://www.dvbviewer.com/"	string
			//		SerialNumber	"0815"	string
			//		Services	null	UPnP.Service[]
			//		UDN	"uuid:9FDE1636-F74B-47AB-8F87-6E54F4AD2564"	string
			//		UPC	null	string
			//		URLBase	"http://192.168.178.41:8089"	string
			//		[1]	{XORO8100}	UPnP.Device
			//		DeviceType	"urn:ses-com:device:SatIPServer:1"	string
			//		FriendlyName	"XORO8100"	string
			//		Icons	{UPnP.Icon[4]}	UPnP.Icon[]
			//		Manufacturer	"XORO by MAS Elektronik AG"	string
			//		ManufacturerURL	""	string
			//		ModelDescription	"This is XORO SAT>IP Server 8100"	string
			//		ModelName	"XORO SAT>IP Server 8100"	string
			//		ModelNumber	"1.0"	string
			//		ModelURL	""	string
			//		SerialNumber	"manufacturer's serial number"	string
			//		Services	null	UPnP.Service[]
			//		UDN	"uuid:20e1a2e4-1dd2-11b2-985d-b0695a8a79ae"	string
			//		UPC	"123456789012"	string
			//		URLBase	" http://192.168.178.99:8000/description.xml"	string

		}

		private void barListItemFavorites_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
		{
			var channel = _favoriteChannels[e.Index];
			ActivateChannel(channel);
		}

		private void MainForm_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		private void MainForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
			vlcControl7.Play(new FileInfo(filePaths[0]));
			barEditItemPosition.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
		}


		private void barButtonItemPause_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			TogglePausePlay();
		}

		private void TogglePausePlay()
		{
			//returns false, even for files!
			//if (vlcControl7.VlcMediaPlayer.IsPausable() )
			//{
			//	return;
			//}

			if (vlcControl7.VlcMediaPlayer.IsPlaying())
			{
				vlcControl7.VlcMediaPlayer.Pause(); // works for satip, too
			}
			else
			{
				vlcControl7.VlcMediaPlayer.Play();
			}
		}

		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			//media.
			return;

			bool res = vlcControl7.VlcMediaPlayer.IsSeekable;
			vlcControl7.VlcMediaPlayer.Navigate(Vlc.DotNet.Core.Interops.Signatures.NavigateModes.Right);

		}

		private void vlcControl7_EncounteredError(object sender, VlcMediaPlayerEncounteredErrorEventArgs e)
		{

		}

		private void vlcControl7_Log(object sender, VlcMediaPlayerLogEventArgs e)
		{
			if (e.Level >= Vlc.DotNet.Core.Interops.Signatures.VlcLogLevel.Warning)
			{
				Trace.WriteLine("Log: " + e.Level + " - " + e.Message);
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// vlcControl seems to save the mute-state internally between sessions
			// cannot query  or set IsMute in OnLoad!
			// -> property will not reflect the 'real' state (and the setter will have an effect)
			// until a video is playing and the clickhandler has been completed
			// you maybe would even have to wait a little while
			// this has to be done before .Stop()
			vlcControl7.VlcMediaPlayer.Audio.IsMute = false;
			vlcControl7.Stop();

			SatipConfig config = new SatipConfig();
			config.LocationX = this.Location.X;
			config.LocationY = this.Location.Y;
			config.SizeWidth = this.Size.Width;
			config.SizeHeight = this.Size.Height;
			config.RestoreBounds = this.RestoreBounds;
			config.WindowState = this.WindowState;
			var configJson = JsonConvert.SerializeObject(config);
			File.WriteAllText(_configFilePath, configJson);

		}

		private void vlcControl7_DoubleClick(object sender, EventArgs e)
		{
			FormWindowState newState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
			this.WindowState = newState;
			// does not work - but logs an error: error set fullscreen failed!
			//vlcControl7.Video.FullScreen = !vlcControl7.Video.FullScreen;
		}

		private void barButtonItemAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			VlcManager mgr = vlcControl7.VlcMediaPlayer.Manager;

			AboutForm form = new AboutForm();
			form.VlcVersion = mgr.VlcVersion;
			form.VlcLibDirectory = vlcControl7.VlcLibDirectory.FullName;
			form.ShowDialog(this);
		}


		private void BuildAudioTracksMenu()
		{
			barListItemAudioTracks.Strings.Clear();

			IEnumerable<TrackDescription> tracks = vlcControl7.VlcMediaPlayer.Audio.Tracks.All;
			TrackDescription currentTrack = vlcControl7.VlcMediaPlayer.Audio.Tracks.Current;
			int selectedIndex = 0;
			int currentIndex = 0;
			foreach (TrackDescription trackDescription in tracks)
			{
				if (trackDescription.ID == currentTrack.ID)
				{
					selectedIndex = currentIndex;
				}
				barListItemAudioTracks.Strings.Add(trackDescription.Name);
				++currentIndex;
			}

			/* TODO: additionally use some infos from media.Tracks?
			VlcMedia media = vlcControl7.GetCurrentMedia();
			if (media == null)
			{
				barListItemAudioTracks.Enabled = false;
				return;
			}
			foreach (MediaTrack track in media.Tracks.Where(item => item.Type == MediaTrackTypes.Audio))
			{
				string bitrateText = track.Bitrate > 0 ? $" {track.Bitrate / 1024.0:#}kbps" : "";
				string itemText = $"{track.Language} {track.Description}" + bitrateText;
				barListItemAudioTracks.Strings.Add(itemText);
				if (media.TrackID == track.Id.ToString())
				{
					selectedIndex = currentIndex;
				}
			}*/

			barListItemAudioTracks.ItemIndex = selectedIndex; // when an item is clicked by the user, the checkmark is automatically set by the barListItem control
			barListItemAudioTracks.Enabled = barListItemAudioTracks.Strings.Count > 0;
		}

		private void barListItemAudioTracks_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			// the added items seem to be shown only after the next click on the barlist
			// moved BuildAudioTracksMenu call to timer_tick
		}
		private void barListItemAudioTracks_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void barListItemAudioTracks_ListItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
		{
			// updating audio-menu is disabled, when it is open, so e.Index should be valid
			vlcControl7.VlcMediaPlayer.Audio.Tracks.Current = vlcControl7.VlcMediaPlayer.Audio.Tracks.All.ToArray()[e.Index];
		}

		private void barListItemAudioTracks_CloseUp(object sender, EventArgs e)
		{
			_tracksListIsVisible = false;
		}

		private void barListItemAudioTracks_Popup(object sender, EventArgs e)
		{
			_tracksListIsVisible = true;
		}

		private void barButtonItemPlayFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			vlcControl7.Play(new FileInfo(dialog.FileName));

			//string m3uUriString = "rtsp://sat.ip/?src=1&freq=12188&pol=h&ro=0.35&msys=dvbs&mtype=qpsk&plts=off&sr=27500&fec=34&pids=0,17,18,163,104,44,105";
			//string m3uUriString = "rtsp://sat.ip/?src=1&freq=12226&pol=h&ro=0.35&msys=dvbs&mtype=qpsk&plts=off&sr=27500&fec=34&pids=0,17,18,600,601,602,603";
			//string uriString = m3uUriString.Replace("sat.ip", _satIpServerAndPort);
			//vlcControl7.Play(new Uri(uriString));
			//vlcControl7.Play(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));

		}
	}
}
