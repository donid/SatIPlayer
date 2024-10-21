using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatIpRecorder
{

	public record SatIpRecorderConfig
	{
		public string SatIpServer { get; set; } = "";
		public string RecordingTargetFolder { get; set; } = "";
		public string VlcExePath { get; set; } = "";

	}
}
