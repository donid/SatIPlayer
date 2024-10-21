using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatIPlayer
{
	public class ServerConfig
	{

		public List<ServerInfo> ServerInfos { get; set; }
		public int ActiveServerIndex { get; set; } = 1;//TODO: remember (serialize) the last selected

	}
}
