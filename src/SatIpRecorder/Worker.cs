using System.Diagnostics;
using System.Runtime;

using Microsoft.Extensions.Options;

using SatIPlayer.Common;

namespace SatIpRecorder
{
	public class Worker : BackgroundService
	{
		private readonly ILogger<Worker> _logger;
		private readonly IHostApplicationLifetime _hostApplicationLifetime;
		private SatIpRecorderConfig _config;

		public Worker(IHostApplicationLifetime hostApplicationLifetime, ILogger<Worker> logger, IOptions<SatIpRecorderConfig> config)
		{
			_hostApplicationLifetime = hostApplicationLifetime;
			_logger = logger;
			_config = config.Value;
			Console.WriteLine($"VlcExePath: {_config.VlcExePath}");
			Console.WriteLine($"RecordingTargetFolder: {_config.RecordingTargetFolder}");
			Console.WriteLine($"SatIpServer: {_config.SatIpServer}");
			Console.WriteLine($"endTime: {Program.endTime}");
		}

		protected override async Task ExecuteAsync(CancellationToken stoppingToken)
		{
			_logger.LogInformation($"server: {_config.SatIpServer} folder: {_config.RecordingTargetFolder}", DateTimeOffset.Now);

			string modifiedUrl = HelpersCommon.ApplyServerNameAndFixUri(Program.foundChannel.Url, _config.SatIpServer);
			Console.WriteLine($"Using URL: {modifiedUrl}");
			string streamUrl = modifiedUrl;

			string targetFilepath = Path.Combine(_config.RecordingTargetFolder, Program.targetFilename);
			Console.WriteLine($"targetFilepath: {targetFilepath}");
			//# https://wiki.videolan.org/Documentation:Streaming_HowTo/Receive_and_Save_a_Stream/
			//# -> 'file/ps://' -> MPEG2-PS muxer -> ProgramStream instead of TS (TransportStream)
			// this did not work: --run-time 120 vlc://quit
			string arguments = "-vvv " + streamUrl + " --sout=file/ps://" + targetFilepath;
			Process process = Process.Start(_config.VlcExePath, arguments);

			while (!stoppingToken.IsCancellationRequested)
			{
				if (_logger.IsEnabled(LogLevel.Information))
				{
					//_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
				}
				await Task.Delay(60000, stoppingToken);
				if (DateTime.Now > Program.endTime)
				{
					process.CloseMainWindow();
					_hostApplicationLifetime.StopApplication();
				}
			}
		}


	}
}
