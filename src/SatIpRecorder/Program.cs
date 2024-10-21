using System.Runtime;

using Microsoft.Extensions.Hosting;

using SatIPlayer.Common;

namespace SatIpRecorder
{
	public class Program
	{


		public static string targetFilename = "";
		public static DateTime endTime;
#nullable disable annotations
		public static ChannelInfo foundChannel;
#nullable restore annotations


		//todo?: create a long-running service, where new timers can be added through a web-api
		// #https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-8.0

		public static void Main(string[] args)
		{
			if (args.Length < 3)
			{
				Console.WriteLine("Usage: SatIpRecorder M3U_ChannelNumber RecordingTimeInMinutes Filename");
				return;
			}

			if (int.TryParse(args[0], out int m3uChannelNumber) == false)
			{
				Console.WriteLine("M3U_ChannelNumber is not an integer");
				return;
			}

			if (int.TryParse(args[1], out int recordingTimeInMinutes) == false)
			{
				Console.WriteLine("RecordingTimeInMinutes is not an integer");
				return;
			}

			if (recordingTimeInMinutes < 1)
			{
				Console.WriteLine("RecordingTimeInMinutes is to small");
				return;
			}

			endTime = DateTime.Now + TimeSpan.FromMinutes(recordingTimeInMinutes);

			targetFilename = args[2];

			List<ChannelInfo> channelList = HelpersCommon.LoadChannelList();
			List<ChannelInfo> customchannelList = HelpersCommon.LoadCustomChannelList();
			List<ChannelInfo> allChannels = channelList.Concat(customchannelList).ToList();
			ChannelInfo? tmpChannel = allChannels.FirstOrDefault(i => IsChannelNumberMatching(i, m3uChannelNumber));
			if (tmpChannel == null)
			{
				Console.WriteLine("Channel not found");
				return;
			}

			foundChannel = tmpChannel;
			Console.WriteLine($"Using Channel: {foundChannel.Name}");


			var builder = Host.CreateApplicationBuilder(args);

			builder.Configuration.SetBasePath(AppContext.BaseDirectory)
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

			IConfigurationSection section = builder.Configuration.GetSection("SatIpRecorderConfig");
			builder.Services.Configure<SatIpRecorderConfig>(section);

			builder.Services.AddHostedService<Worker>();

			var host = builder.Build();
			host.Run();
		}

		private static bool IsChannelNumberMatching(ChannelInfo info, int number)
		{
			int index = info.Name.IndexOf('.');
			if (index < 1)
			{
				return false;
			}

			string numberSubstring = info.Name.Substring(0, index);
			if (int.TryParse(numberSubstring, out int currentNumber) == false)
			{
				return false;
			}

			return number == currentNumber;
		}

	}
}
