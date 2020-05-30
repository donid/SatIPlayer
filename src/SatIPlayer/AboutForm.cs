using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SatIPlayer
{
	public partial class AboutForm : XtraForm
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		public string VlcVersion { get; set; }
		public string VlcLibDirectory { get; set; }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			textEditVlcVersion.Text = "Vlc Version: " + VlcVersion;
			textEditVlcLibDirectory.Text = "Vlc LibDirectory: " + VlcLibDirectory;
			textEditSatIPlayerVersion.Text = "SatIPlayer Version: " + Application.ProductVersion;
		}
	}
}
