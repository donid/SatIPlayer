using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using PlaylistsNET.Content;
using PlaylistsNET.Models;

namespace SatIPlayer.Common
{
	public class HelpersCommon
	{
		// as of June 2024, this site appears to be completely down:
		// here are some resources related to sat>ip
		// http://www.satip.info/resources?tid=23
		// private const string _m3uUrl = "http://www.satip.info/Playlists/ASTRA_19_2E.m3u";

		private const string _m3uUrl = "https://raw.githubusercontent.com/dersnyke/satipplaylists/main/satip_astra192e.m3u";

		public static List<ChannelInfo> LoadChannelList()
		{
			string? rootedFilePath = GetRootedFilePath("ASTRA_19_2E.m3u");
			if (rootedFilePath == null)
			{
				Trace.WriteLine("LoadChannelList: rootedFilePath is null");
				return new List<ChannelInfo>();
			}

			if (!File.Exists(rootedFilePath))
			{
				try
				{
					new WebClient().DownloadFile(_m3uUrl, rootedFilePath);
				}
				catch (Exception ex)
				{
					Trace.WriteLine($"LoadChannelList: DownloadFile failed with error ({ex.Message})");
					return new List<ChannelInfo>();
				}
			}

			return LoadChannelListInternal(rootedFilePath);
		}

		public static List<ChannelInfo> LoadCustomChannelList()
		{
			string? rootedFilePath = GetRootedFilePath("ASTRA_19_2E_custom.m3u");
			if (rootedFilePath == null)
			{
				Trace.WriteLine("LoadCustomChannelList: rootedFilePath is null");
				return new List<ChannelInfo>();
			}

			if (!File.Exists(rootedFilePath))
			{
				Trace.WriteLine("LoadCustomChannelList: CustomChannelList file not found");
				return new List<ChannelInfo>();
			}

			return LoadChannelListInternal(rootedFilePath);
		}

		private static List<ChannelInfo> LoadChannelListInternal(string localFilePath)
		{
			string? rootedFilePath = GetRootedFilePath(localFilePath);
			if (rootedFilePath == null)
			{
				Trace.WriteLine("LoadChannelListInternal: rootedFilePath is null");
				return new List<ChannelInfo>();
			}

			M3uPlaylist playlist;
			try
			{
				string m3uContent = File.ReadAllText(rootedFilePath);
				M3uContent content = new M3uContent();
				playlist = content.GetFromString(m3uContent);
			}
			catch (Exception ex)
			{
				Trace.WriteLine($"LoadChannelListInternal: error while processing file or content {ex.Message}");
				return new List<ChannelInfo>();
			}
			List<ChannelInfo> channelList = playlist.PlaylistEntries.Select(item => new ChannelInfo() { Name = item.Title, Url = item.Path }).ToList();
			return channelList;
		}

		private static string? GetRootedFilePath(string localFilePath)
		{
			string? exeFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			if (exeFolder == null)
			{
				return null;
			}
			return Path.Combine(exeFolder, localFilePath);
		}


		public static TimeSpan ConvertVlcTime(long time)
		{
			return TimeSpan.FromSeconds(time / 1000.0);
		}


		// use 'satip://' instead of 'rtsp', otherwise it doesn't work if multiple streams are recorded/received !!!
		// rtsp:// works with xoro even when an other client is already recording / when using triax, vlc always plays the currently recorded stream
		// satip:// seems to always create a new stream even with triax
		private static string FixSatIpUriScheme(string url)
		{
			return url.Replace("rtsp://", "satip://");
		}

		private static string ApplyServerNameToUri(string m3uUriString, string satIpServerAndPort)
		{
			return m3uUriString.Replace(@"://sat.ip/", $@"://{satIpServerAndPort}/");
		}

		public static string ApplyServerNameAndFixUri(string m3uUriString, string satIpServerAndPort)
		{
			string tmp = ApplyServerNameToUri(m3uUriString, satIpServerAndPort);
			return FixSatIpUriScheme(tmp);
		}

	}
}
