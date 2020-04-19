using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SatIp.RtspSample.SatIp;


namespace SatIPlayer
{
	public partial class ServersForm : XtraForm
	{
		ServerConfig _serverConfig;

		public ServersForm()
		{
			InitializeComponent();
		}

		public void SetServerConfig(ServerConfig serverConfig)
		{
			_serverConfig = serverConfig;
			gridControl1.DataSource = serverConfig.ServerInfos;
			gridViewServersFromConfig.FocusedRowHandle = serverConfig.ActiveServerIndex;
		}
		 
		private void ServersForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			_serverConfig.ActiveServerIndex= gridViewServersFromConfig.FocusedRowHandle;
		}

		private async void ServersForm_Load(object sender, EventArgs e)
		{
			//vlc uses "urn:schemas-upnp-org:device:MediaServer:1"
   			IEnumerable<UPnP.Device> devices = await new UPnP.Ssdp().SearchDevicesAsync("urn:ses-com:device:SatIPServer:1");

			_upnpEmptyRowstext = "No servers found";

			gridControl2.DataSource = devices;

			var triax=devices.First(item => item.FriendlyName == "Triax SatIP Converter");
			if (triax==null)
			{
				return;
			}
			var triaxSat=new SatIpDevice(triax);


			// examples:
			// .BaseUrl.Host

			//		devices	Count = 2	System.Collections.Generic.IEnumerable<UPnP.Device> {System.Collections.Generic.List<UPnP.Device>}
			//		[0]	{DVBViewer Media Server (WIN8)}	UPnP.Device
			//		DeviceType	"urn:ses-com:device:SatIPServer:1"	string
			//		FriendlyName	"DVBViewer Media Server (WIN8)"	string
			//		Icons	{UPnP.Icon[4]}	UPnP.Icon[]
			//		Manufacturer	"cmuv"	string
			//		ManufacturerURL	"http://www.dvbviewer.com/"	string
			//		ModelDescription	"DVBViewer Mediaserver"	string
			//		ModelName	"DVBViewer Mediaserver"	string
			//		ModelNumber	"2.0"	string
			//		ModelURL	"http://www.dvbviewer.com/"	string
			//		SerialNumber	"0815"	string
			//		Services	null	UPnP.Service[]
			//		UDN	"uuid:9FDE1636-F74B-47AB-8F87-6E54F4AD2564"	string
			//		UPC	null	string
			//		URLBase	"http://192.168.178.41:8089"	string
			//		[1]	{XORO8100}	UPnP.Device
			//		DeviceType	"urn:ses-com:device:SatIPServer:1"	string
			//		FriendlyName	"XORO8100"	string
			//		Icons	{UPnP.Icon[4]}	UPnP.Icon[]
			//		Manufacturer	"XORO by MAS Elektronik AG"	string
			//		ManufacturerURL	""	string
			//		ModelDescription	"This is XORO SAT>IP Server 8100"	string
			//		ModelName	"XORO SAT>IP Server 8100"	string
			//		ModelNumber	"1.0"	string
			//		ModelURL	""	string
			//		SerialNumber	"manufacturer's serial number"	string
			//		Services	null	UPnP.Service[]
			//		UDN	"uuid:20e1a2e4-1dd2-11b2-985d-b0695a8a79ae"	string
			//		UPC	"123456789012"	string
			//		URLBase	" http://192.168.178.99:8000/description.xml"	string


			//-		[1]	{Triax SatIP Converter}	UPnP.Device
			//		DeviceType	"urn:ses-com:device:SatIPServer:1"	string
			//		FriendlyName	"Triax SatIP Converter"	string
			//		Icons	{UPnP.Icon[4]}	UPnP.Icon[]
			//		Manufacturer	"Triax"	string
			//		ManufacturerURL	"http://www.triax.fr/"	string
			//		ModelDescription	null	string
			//		ModelName	"TSS400 MKII"	string
			//		ModelNumber	null	string
			//		ModelURL	null	string
			//		SerialNumber	null	string
			//		Services	null	UPnP.Service[]
			//		UDN	"uuid:00000000-0000-1000-a2c0-00059e979cba"	string
			//		UPC	"123456789"	string
			//		URLBase	"http://192.168.178.53:80/rootDescr"	string

		}

		string _upnpEmptyRowstext = "Searching...";

		private void gridViewUpnpServers_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
		{
			DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
			if (view.RowCount != 0)
				return;
			StringFormat drawFormat = new StringFormat();
			drawFormat.Alignment = drawFormat.LineAlignment = StringAlignment.Center;
			e.Graphics.DrawString(_upnpEmptyRowstext, e.Appearance.Font, SystemBrushes.ControlDark, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height), drawFormat);
		}
	}
}
