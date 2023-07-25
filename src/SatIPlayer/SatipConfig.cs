using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatIPlayer
{
	public class SatipConfig
	{
		public int LocationX { get; set; }
		public int LocationY { get; set; }
		public int SizeHeight { get; set; }
		public int SizeWidth { get; set; }
		public string RestoreBounds { get; set; }
		public FormWindowState WindowState { get; set; }
	}
}
