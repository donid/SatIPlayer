using System.Runtime;
using System.Text.Json;

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
			Console.WriteLine($"SatIpRecorder V1.0.2");

			if (args.Length < 3)
			{
				Console.WriteLine("Usage: SatIpRecorder M3U_ChannelNumber RecordingTimeInMinutes Filename");
				return;
			}

			string m3uChannelName = args[0];

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


			const string favoritesJsonFileName = "satip_favorites.json";
			string favoritesFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, favoritesJsonFileName);
			if (!File.Exists(favoritesFilePath))
			{
				Console.WriteLine($"Favorites-Json File not found: '{favoritesFilePath}'");
				return;
			}
			string json = File.ReadAllText(favoritesFilePath);
			var favoriteChannels = JsonSerializer.Deserialize<List<ChannelInfo>>(json);
			if (favoriteChannels == null)
			{
				Console.WriteLine("Cannot deserialize favorites file");
				return;
			}
			ChannelInfo? tmpChannel = favoriteChannels.FirstOrDefault(i => i.Name == m3uChannelName);
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



	}
}
