namespace SatIPlayer
{
	partial class ServersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServersForm));
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridViewServersFromConfig = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridControl2 = new DevExpress.XtraGrid.GridControl();
			this.gridViewUpnpServers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewServersFromConfig)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewUpnpServers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl1.Location = new System.Drawing.Point(5, 21);
			this.gridControl1.MainView = this.gridViewServersFromConfig;
			this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(521, 139);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewServersFromConfig});
			// 
			// gridViewServersFromConfig
			// 
			this.gridViewServersFromConfig.DetailHeight = 444;
			this.gridViewServersFromConfig.GridControl = this.gridControl1;
			this.gridViewServersFromConfig.Name = "gridViewServersFromConfig";
			this.gridViewServersFromConfig.OptionsView.ShowGroupPanel = false;
			// 
			// gridControl2
			// 
			this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
			this.gridControl2.Location = new System.Drawing.Point(5, 180);
			this.gridControl2.MainView = this.gridViewUpnpServers;
			this.gridControl2.Margin = new System.Windows.Forms.Padding(2);
			this.gridControl2.Name = "gridControl2";
			this.gridControl2.Size = new System.Drawing.Size(521, 140);
			this.gridControl2.TabIndex = 1;
			this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUpnpServers});
			// 
			// gridViewUpnpServers
			// 
			this.gridViewUpnpServers.DetailHeight = 284;
			this.gridViewUpnpServers.GridControl = this.gridControl2;
			this.gridViewUpnpServers.Name = "gridViewUpnpServers";
			this.gridViewUpnpServers.OptionsView.ShowGroupPanel = false;
			this.gridViewUpnpServers.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(this.gridViewUpnpServers_CustomDrawEmptyForeground);
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControl2);
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(531, 325);
			this.layoutControl1.TabIndex = 2;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
			this.Root.Name = "Root";
			this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
			this.Root.Size = new System.Drawing.Size(531, 325);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(525, 159);
			this.layoutControlItem1.Text = "Select active server from config";
			this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(321, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.gridControl2;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 159);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(525, 160);
			this.layoutControlItem2.Text = "Found UPNP servers (Url must be manually copied to server config)";
			this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem2.TextSize = new System.Drawing.Size(321, 13);
			// 
			// ServersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 325);
			this.Controls.Add(this.layoutControl1);
			this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ServersForm.IconOptions.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ServersForm";
			this.ShowInTaskbar = false;
			this.Text = "Sat>IP Servers";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServersForm_FormClosing);
			this.Load += new System.EventHandler(this.ServersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewServersFromConfig)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewUpnpServers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewServersFromConfig;
		private DevExpress.XtraGrid.GridControl gridControl2;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewUpnpServers;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
	}
}