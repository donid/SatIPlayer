using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;

using HtmlAgilityPack;

using StringExtensions;

namespace SatIpUrlGenerator
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void simpleButtonReadClipboard_Click(object sender, EventArgs e)
		{
			string csvText = Clipboard.GetText();
			string[] lines = csvText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			var filteredLines = lines.Where(l => CountTabs(l) == 14).ToArray();

			if (!filteredLines.Any())
			{
				MessageBox.Show("No Table-Lines Found");
				return;
			}
			if (!filteredLines[0].StartsWith("Satellit	Provider	Sender	Frequenz	POL	Symbolrate	FEC	Format	Modulation	SID	PMT	VPID	APID	Typ	Codierung"))
			{
				MessageBox.Show("Table-Header Not Found");
				return;
			}

			Channelinfo[] infos = filteredLines.Skip(1).Select(l => new Channelinfo(l)).ToArray();

			gridControl1.DataSource = infos;

			foreach (GridColumn gridColumn in gridView1.Columns)
			{
				if (gridColumn.Name.EndsWith("ForUrl"))
				{
					gridColumn.Visible = false;
				}
			}
		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			if (e.FocusedRowHandle < 0)
			{
				return;
			}
			Channelinfo info = (Channelinfo)gridView1.GetFocusedRow();
			// without the PIDs '0,17,18' VLC shows only generic names for the Audio-Streams
			// 0 is PAT -> Program Association Table
			// 17,18 - IDs for EPG and infos about channel and currently transmitted content
			// following the audio PIDs: Videotext and subtitles
			// see satip_specification_version_1_2_2.pdf
			// 3.5.11 Query Syntax
			string m3uUrl = $"rtsp://sat.ip/?freq={info.Freq}&pol={info.PolForUrl}&ro=0.35&msys={info.FormatForUrl}&sr={info.Symbolrate}&fec={info.FECForUrl}&pids=0,17,18,{info.PIDsForUrl}";
			textEditM3uUrl.Text = m3uUrl;
			string vlcUrl = m3uUrl.Replace("sat.ip", textEditServerIp.Text).Replace("rtsp:", "satip:");
			textEditVlcUrl.Text = vlcUrl;
			textEditM3uComment.Text = $"#EXTINF:0,9999. {info.Name} - change the '9999' channel number!";
		}

		private void simpleButtonOpenWebsite_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.digitalfernsehen.de/sat-frequenzen?");
		}

		private static int CountTabs(string text)
		{
			return text.Count(c => c == '\t');
		}

		private void simpleButtonOpenSatIndex_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.satindex.de/astra.php");
		}

		private void simpleButtonReadClipboardSatIndex_Click(object sender, EventArgs e)
		{
			string text = Clipboard.GetText();
			//if (text.StartsWith("https://www.satindex.de/channeleng/"))
			//{
			//	MessageBox.Show("Only german versions of satindex channel-page URL supported!");
			//	return;
			//}
			if (!text.StartsWith("https://www.satindex.de/channel/"))
			{
				MessageBox.Show("Not a satindex channel-page URL!");
				return;
			}
			Dictionary<string, Action<SatIndexChannelInfo, string>> _keyToSetter = new Dictionary<string, Action<SatIndexChannelInfo, string>>();
			_keyToSetter.Add("Name", (i, v) => i.ChannelName = v);
			_keyToSetter.Add("Art", (i, v) => i.ChannelType = v);
			_keyToSetter.Add("Modulation", (i, v) => i.Modulation = v);
			_keyToSetter.Add("Frequenz", (i, v) => i.Frequency = v);
			_keyToSetter.Add("Polarisation", (i, v) => i.Polarisation = v);
			_keyToSetter.Add("Symbolrate", (i, v) => i.Symbolrate = v);
			_keyToSetter.Add("FEC", (i, v) => i.FEC = v);
			_keyToSetter.Add("Video Pid", (i, v) => i.VideoPid = v);
			_keyToSetter.Add("Audio Pids", (i, v) => i.AudioPids = v);
			_keyToSetter.Add("PMT Pid", (i, v) => i.PMTPid = v);
			_keyToSetter.Add("Videotext Pid", (i, v) => i.VideotextPid = v);

			Console.WriteLine("Hello World!");
			//var doc = new HtmlDocument();

			SatIndexChannelInfo sci = new SatIndexChannelInfo();

			var web = new HtmlWeb();
			var doc = web.Load(text);
			var nodes = doc.DocumentNode.SelectNodes("//div[@class='table']");
			foreach (var node in nodes)
			{
				HtmlNodeCollection childNodes = node.ChildNodes;
				string txt0 = childNodes[0].InnerText;
				Console.WriteLine(txt0);
				for (int index = 1; index < childNodes.Count; index++)
				{
					string innerText = childNodes[index].InnerText;
					string key = innerText.LeftOf(':').Trim();
					if (_keyToSetter.TryGetValue(key, out Action<SatIndexChannelInfo, string> setter))
					{
						setter(sci, innerText.RightOf(':').Trim());
					}
					Console.WriteLine("\t" + innerText);
				}
			}
			// ((nodes._items).Items[0]).ChildNodes._items).Items[0]).InnerText	
			// "&nbsp;  &raquo;  Frequenz Daten"	string


			// https://www.satindex.de/channel/7580/


			string fec = sci.FEC.Replace("/", "");
			Console.WriteLine($"fec: '{fec}'");

			string frequency = sci.Frequency.LeftOf(" MHz").Replace(".", "");
			Console.WriteLine($"Frequency: '{frequency}'");

			string symbolrate = sci.Symbolrate.LeftOf(" kSym/s").Replace(".", "");
			Console.WriteLine($"Symbolrate: '{symbolrate}'");

			string polarisation = "UNKONPOLARISATION";
			if (sci.Polarisation == "Horizontal")
			{
				polarisation = "h";
			}
			else if (sci.Polarisation == "Vertikal" || sci.Polarisation == "Vertical")
			{
				polarisation = "v";
			}
			Console.WriteLine($"Polarisation: '{polarisation}'");

			string modulation = sci.Modulation.ToLower();
			Console.WriteLine($"Modulation: '{modulation}'");

			string channelType = "UNKONCHANNELTYPE";
			if (sci.ChannelType == "DVB-S")
			{
				channelType = "dvbs";
			}
			else if (sci.ChannelType == "DVB-S2")
			{
				channelType = "dvbs2";
			}
			Console.WriteLine($"ChannelType: '{channelType}'");

			Regex regex = new Regex(@"[\d]+");
			MatchCollection matchCollection = regex.Matches(sci.AudioPids);
			string audioPids = string.Join(",", matchCollection.Cast<Match>().Select(m => m.Value));
			List<string> allPidsList = new List<string>() { sci.PMTPid, sci.VideoPid, audioPids };
			if (!sci.VideotextPid.StartsWith("0"))
			{
				allPidsList.Add(sci.VideotextPid);
			}
			string allPids = string.Join(",", allPidsList);
			Console.WriteLine($"allPids: '{allPids}'");

			//string textEditServerIpText = "TSS400-MKII";
			//For DVB-S this value shall be set to “off” in client queries
			string pilotTones = true ? "on" : "off";// "hr-fernsehen HD" didn't work without this value!- value does NOT exist in the details data
			string dvbRollOff = "0.35";// "hr-fernsehen HD" didn't work without this value! - value does exist in the details data
			string m3uUrl = $"rtsp://sat.ip/?freq={frequency}&pol={polarisation}&ro={dvbRollOff}&msys={channelType}&mtype={modulation}&plts={pilotTones}&sr={symbolrate}&fec={fec}&pids=0,17,18,{allPids}";
			textEditM3uUrl.Text = m3uUrl;
			string vlcUrl = m3uUrl.Replace("sat.ip", textEditServerIp.Text).Replace("rtsp:", "satip:");
			textEditVlcUrl.Text = vlcUrl;
			/*string*/
			textEditM3uComment.Text = $"#EXTINF:0,9999. {sci.ChannelName} - change the '9999' channel number!";
			//Console.WriteLine(textEditM3uCommentText);
		}

		private void buttonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Glyph)//HACK
			{
				var be = sender as ButtonEdit;
				string content = be.EditValue as string;
				Clipboard.SetText(content);
			}

		}

		private void labelControl6_Click(object sender, EventArgs e)
		{

		}
	}

	// copied from V:\projs_git\SatIndexDataExtractor\SatIndexDataExtractor\Program.cs


	public class /*record*/ SatIndexChannelInfo
	{
		public string ChannelName { get; set; }
		public string ChannelType { get; set; }
		public string Modulation { get; set; }
		public string Frequency { get; set; }
		public string Polarisation { get; set; }
		public string Symbolrate { get; set; }
		public string FEC { get; set; }
		public string VideoPid { get; set; }
		public string AudioPids { get; set; }
		public string PMTPid { get; set; }
		public string VideotextPid { get; set; }
	}

	internal class Channelinfo
	{
		private string[] _parts;
		public Channelinfo(string line)
		{
			_parts = line.Split('\t');
			_parts = _parts.Concat(Enumerable.Repeat("", 15)).ToArray();
		}

		public string Provider
		{
			get => _parts[1];
		}

		public string Name
		{
			get => _parts[2];
		}
		public string Freq
		{
			get => _parts[3];
		}

		public string Pol
		{
			get => _parts[4];
		}
		public string PolForUrl
		{
			get => Pol.ToLower();
		}
		public string Symbolrate
		{
			get => _parts[5];
		}
		public string FEC
		{
			get => _parts[6];
		}
		public string FECForUrl
		{
			get => FEC.Replace("/", "");
		}
		public string Format
		{
			get => _parts[7];
		}
		public string FormatForUrl
		{
			get
			{
				string result = "###UNKOWNFORMAT###";
				if (Format == "DVB-S")
				{
					result = "dvbs";
				}
				if (Format == "DVB-S2")
				{
					result = "dvbs2";
				}
				return result;
			}
		}
		public string Modulation
		{
			get => _parts[8];
		}

		public string SID
		{
			get => _parts[9];
		}

		// Program Map Table
		public string PMT
		{
			get => _parts[10];
		}
		public string VideoPID
		{
			get => _parts[11];
		}

		public string AudioPid
		{
			get => _parts[12];
		}
		public string Typ
		{
			get => _parts[13];
		}

		public string Encryption
		{
			get => _parts[14];
		}
		public string PIDsForUrl
		{
			get => $"{VideoPID},{AudioPid},{PMT}";
		}
	}
}
