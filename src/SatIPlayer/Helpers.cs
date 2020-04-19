using PlaylistsNET.Content;
using PlaylistsNET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;

namespace SatIPlayer
{
	class Helpers
	{

		// hier gibt es m3u playlist zum download
		// http://www.satip.info/resources?tid=23
		const string _m3uUrl = "http://www.satip.info/Playlists/ASTRA_19_2E.m3u";

		public static List<ChannelInfo> LoadChannellist()
		{
			string localFilePath = "ASTRA_19_2E.m3u";
			if (!File.Exists(localFilePath))
			{
				new WebClient().DownloadFile(_m3uUrl, localFilePath);
			}

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
