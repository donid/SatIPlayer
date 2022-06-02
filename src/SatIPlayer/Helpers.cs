using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;

using PlaylistsNET.Content;
using PlaylistsNET.Models;

namespace SatIPlayer
{
	internal class Helpers
	{

		// here some resources related to sat>ip
		// http://www.satip.info/resources?tid=23
		private const string _m3uUrl = "http://www.satip.info/Playlists/ASTRA_19_2E.m3u";

		public static List<ChannelInfo> LoadChannellist()
		{
			string localFilePath = "ASTRA_19_2E.m3u";
			if (!File.Exists(localFilePath))
			{
				new WebClient().DownloadFile(_m3uUrl, localFilePath);
			}

			return LoadChannellistInternal(localFilePath);
		}

		public static List<ChannelInfo> LoadCustomChannellist()
		{
			string localFilePath = "ASTRA_19_2E_custom.m3u";
			if (!File.Exists(localFilePath))
			{

				return new List<ChannelInfo>();
			}

			return LoadChannellistInternal(localFilePath);
		}

		private static List<ChannelInfo> LoadChannellistInternal(string localFilePath)
		{
			M3uContent content = new M3uContent();
			M3uPlaylist playlist = content.GetFromStream(File.OpenRead(localFilePath));
			List<ChannelInfo> channelList = playlist.PlaylistEntries.Select(item => new ChannelInfo() { Name = item.Title, Url = item.Path }).ToList();
			return channelList;
		}

		public static TimeSpan ConvertVlcTime(long time)
		{
			return TimeSpan.FromSeconds(time / 1000.0);
		}

	}
}
