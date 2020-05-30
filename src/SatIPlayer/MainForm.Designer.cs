namespace SatIPlayer
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.vlcControl7 = new Vlc.DotNet.Forms.VlcControl();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barButtonItemChannels = new DevExpress.XtraBars.BarButtonItem();
			this.barListItemFavorites = new DevExpress.XtraBars.BarListItem();
			this.barButtonItemServer = new DevExpress.XtraBars.BarButtonItem();
			this.barListItemAudioTracks = new DevExpress.XtraBars.BarListItem();
			this.barButtonItemPause = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemPlayFile = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItemAbout = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.barButtonItemMute = new DevExpress.XtraBars.BarButtonItem();
			this.barEditItemVolume = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
			this.barStaticItemVolume = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItemChannelName = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItemFileStatus = new DevExpress.XtraBars.BarStaticItem();
			this.barEditItemPosition = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
			this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.barStaticItemTime = new DevExpress.XtraBars.BarStaticItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
			this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.vlcControl7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
			this.SuspendLayout();
			// 
			// vlcControl7
			// 
			this.vlcControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.vlcControl7.BackColor = System.Drawing.Color.Black;
			this.vlcControl7.Location = new System.Drawing.Point(0, 24);
			this.vlcControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.vlcControl7.Name = "vlcControl7";
			this.vlcControl7.Size = new System.Drawing.Size(1120, 568);
			this.vlcControl7.Spu = -1;
			this.vlcControl7.TabIndex = 6;
			this.vlcControl7.Text = "vlcControl7";
			this.vlcControl7.VlcLibDirectory = null;
			this.vlcControl7.VlcMediaplayerOptions = null;
			this.vlcControl7.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl7_VlcLibDirectoryNeeded);
			this.vlcControl7.EncounteredError += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerEncounteredErrorEventArgs>(this.vlcControl7_EncounteredError);
			this.vlcControl7.Log += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLogEventArgs>(this.vlcControl7_Log);
			this.vlcControl7.DoubleClick += new System.EventHandler(this.vlcControl7_DoubleClick);
			// 
			// barManager1
			// 
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItemVolume,
            this.barStaticItemChannelName,
            this.barEditItemVolume,
            this.barEditItem2,
            this.barEditItem1,
            this.barToggleSwitchItem1,
            this.barButtonItemMute,
            this.barButtonItemChannels,
            this.barListItemFavorites,
            this.barButtonItemServer,
            this.barButtonItemPause,
            this.barButtonItem4,
            this.barStaticItemFileStatus,
            this.barEditItemPosition,
            this.barStaticItem1,
            this.barStaticItemTime,
            this.barButtonItemAbout,
            this.barListItemAudioTracks,
            this.barButtonItemPlayFile});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 21;
			this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemTrackBar1,
            this.repositoryItemCheckEdit1,
            this.repositoryItemProgressBar2});
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemChannels),
            new DevExpress.XtraBars.LinkPersistInfo(this.barListItemFavorites),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemServer),
            new DevExpress.XtraBars.LinkPersistInfo(this.barListItemAudioTracks),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPause),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemPlayFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemAbout),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// barButtonItemChannels
			// 
			this.barButtonItemChannels.Caption = "Channels";
			this.barButtonItemChannels.Id = 8;
			this.barButtonItemChannels.Name = "barButtonItemChannels";
			this.barButtonItemChannels.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemChannels_ItemClick);
			// 
			// barListItemFavorites
			// 
			this.barListItemFavorites.Caption = "Favorites";
			this.barListItemFavorites.Id = 9;
			this.barListItemFavorites.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barListItemFavorites.ImageOptions.Image")));
			this.barListItemFavorites.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barListItemFavorites.ImageOptions.LargeImage")));
			this.barListItemFavorites.Name = "barListItemFavorites";
			this.barListItemFavorites.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barListItemFavorites.ShowChecks = true;
			this.barListItemFavorites.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.barListItemFavorites_ListItemClick);
			// 
			// barButtonItemServer
			// 
			this.barButtonItemServer.Caption = "Server";
			this.barButtonItemServer.Id = 10;
			this.barButtonItemServer.Name = "barButtonItemServer";
			this.barButtonItemServer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonServer_Click);
			// 
			// barListItemAudioTracks
			// 
			this.barListItemAudioTracks.Caption = "AudioTracks";
			this.barListItemAudioTracks.Enabled = false;
			this.barListItemAudioTracks.Id = 19;
			this.barListItemAudioTracks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barListItemAudioTracks.ImageOptions.Image")));
			this.barListItemAudioTracks.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barListItemAudioTracks.ImageOptions.LargeImage")));
			this.barListItemAudioTracks.Name = "barListItemAudioTracks";
			this.barListItemAudioTracks.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.barListItemAudioTracks.ShowChecks = true;
			this.barListItemAudioTracks.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.barListItemAudioTracks_ListItemClick);
			this.barListItemAudioTracks.CloseUp += new System.EventHandler(this.barListItemAudioTracks_CloseUp);
			this.barListItemAudioTracks.Popup += new System.EventHandler(this.barListItemAudioTracks_Popup);
			this.barListItemAudioTracks.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barListItemAudioTracks_ItemClick);
			this.barListItemAudioTracks.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.barListItemAudioTracks_ItemPress);
			// 
			// barButtonItemPause
			// 
			this.barButtonItemPause.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.barButtonItemPause.Caption = "Pause";
			this.barButtonItemPause.Id = 11;
			this.barButtonItemPause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemPause.ImageOptions.Image")));
			this.barButtonItemPause.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemPause.ImageOptions.LargeImage")));
			this.barButtonItemPause.Name = "barButtonItemPause";
			this.barButtonItemPause.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPause_ItemClick);
			// 
			// barButtonItemPlayFile
			// 
			this.barButtonItemPlayFile.Caption = "PlayFile";
			this.barButtonItemPlayFile.Hint = "Play File";
			this.barButtonItemPlayFile.Id = 20;
			this.barButtonItemPlayFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemPlayFile.ImageOptions.Image")));
			this.barButtonItemPlayFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemPlayFile.ImageOptions.LargeImage")));
			this.barButtonItemPlayFile.Name = "barButtonItemPlayFile";
			this.barButtonItemPlayFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemPlayFile_ItemClick);
			// 
			// barButtonItemAbout
			// 
			this.barButtonItemAbout.Caption = "About";
			this.barButtonItemAbout.Id = 18;
			this.barButtonItemAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemAbout.ImageOptions.Image")));
			this.barButtonItemAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemAbout.ImageOptions.LargeImage")));
			this.barButtonItemAbout.Name = "barButtonItemAbout";
			this.barButtonItemAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemAbout_ItemClick);
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "Test";
			this.barButtonItem4.Id = 12;
			this.barButtonItem4.Name = "barButtonItem4";
			this.barButtonItem4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemMute),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItemVolume),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItemVolume),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItemChannelName),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItemFileStatus),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditItemPosition),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItemTime)});
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// barButtonItemMute
			// 
			this.barButtonItemMute.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.barButtonItemMute.Caption = "Mute";
			this.barButtonItemMute.Id = 6;
			this.barButtonItemMute.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Plum;
			this.barButtonItemMute.ItemAppearance.Pressed.Options.UseBackColor = true;
			this.barButtonItemMute.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.Immediate;
			this.barButtonItemMute.Name = "barButtonItemMute";
			this.barButtonItemMute.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemMute_ItemClick);
			// 
			// barEditItemVolume
			// 
			this.barEditItemVolume.Caption = "Volume";
			this.barEditItemVolume.Edit = this.repositoryItemProgressBar1;
			this.barEditItemVolume.EditValue = "80";
			this.barEditItemVolume.EditWidth = 120;
			this.barEditItemVolume.Id = 2;
			this.barEditItemVolume.Name = "barEditItemVolume";
			this.barEditItemVolume.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
			// 
			// repositoryItemProgressBar1
			// 
			this.repositoryItemProgressBar1.Maximum = 150;
			this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
			this.repositoryItemProgressBar1.PercentView = false;
			this.repositoryItemProgressBar1.ShowTitle = true;
			this.repositoryItemProgressBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.repositoryItemProgressBar1_MouseDown);
			// 
			// barStaticItemVolume
			// 
			this.barStaticItemVolume.Caption = "Volume %";
			this.barStaticItemVolume.Id = 0;
			this.barStaticItemVolume.Name = "barStaticItemVolume";
			// 
			// barStaticItemChannelName
			// 
			this.barStaticItemChannelName.Caption = "Channel Name";
			this.barStaticItemChannelName.Id = 1;
			this.barStaticItemChannelName.Name = "barStaticItemChannelName";
			// 
			// barStaticItemFileStatus
			// 
			this.barStaticItemFileStatus.Caption = "NowPlaying";
			this.barStaticItemFileStatus.Id = 13;
			this.barStaticItemFileStatus.Name = "barStaticItemFileStatus";
			// 
			// barEditItemPosition
			// 
			this.barEditItemPosition.Caption = "Position";
			this.barEditItemPosition.Edit = this.repositoryItemProgressBar2;
			this.barEditItemPosition.EditWidth = 250;
			this.barEditItemPosition.Id = 14;
			this.barEditItemPosition.Name = "barEditItemPosition";
			this.barEditItemPosition.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
			this.barEditItemPosition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			// 
			// repositoryItemProgressBar2
			// 
			this.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2";
			this.repositoryItemProgressBar2.ShowTitle = true;
			// 
			// barStaticItem1
			// 
			this.barStaticItem1.Caption = "barStaticItemServer";
			this.barStaticItem1.Id = 15;
			this.barStaticItem1.Name = "barStaticItem1";
			// 
			// barStaticItemTime
			// 
			this.barStaticItemTime.Caption = "Time";
			this.barStaticItemTime.Id = 17;
			this.barStaticItemTime.Name = "barStaticItemTime";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlTop.Size = new System.Drawing.Size(1120, 24);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 595);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlBottom.Size = new System.Drawing.Size(1120, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 571);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1120, 24);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 571);
			// 
			// barEditItem2
			// 
			this.barEditItem2.Caption = "Vol";
			this.barEditItem2.Edit = this.repositoryItemTrackBar1;
			this.barEditItem2.Id = 3;
			this.barEditItem2.Name = "barEditItem2";
			// 
			// repositoryItemTrackBar1
			// 
			this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
			this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
			// 
			// barEditItem1
			// 
			this.barEditItem1.Caption = "barEditItem1";
			this.barEditItem1.Edit = this.repositoryItemCheckEdit1;
			this.barEditItem1.Id = 4;
			this.barEditItem1.Name = "barEditItem1";
			// 
			// repositoryItemCheckEdit1
			// 
			this.repositoryItemCheckEdit1.AutoHeight = false;
			this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
			// 
			// barToggleSwitchItem1
			// 
			this.barToggleSwitchItem1.Caption = "barToggleSwitchItem1";
			this.barToggleSwitchItem1.Id = 5;
			this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 3000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 618);
			this.Controls.Add(this.vlcControl7);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "SatIPlayer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.vlcControl7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Vlc.DotNet.Forms.VlcControl vlcControl7;
		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarStaticItem barStaticItemVolume;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarStaticItem barStaticItemChannelName;
		private DevExpress.XtraBars.BarEditItem barEditItemVolume;
		private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
		private DevExpress.XtraBars.BarEditItem barEditItem2;
		private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
		private DevExpress.XtraBars.BarEditItem barEditItem1;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
		private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItemMute;
		private DevExpress.XtraBars.BarButtonItem barButtonItemChannels;
		private System.Windows.Forms.Timer timer1;
		private DevExpress.XtraBars.BarListItem barListItemFavorites;
		private DevExpress.XtraBars.BarButtonItem barButtonItemServer;
		private DevExpress.XtraBars.BarButtonItem barButtonItemPause;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarStaticItem barStaticItemFileStatus;
		private DevExpress.XtraBars.BarEditItem barEditItemPosition;
		private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
		private DevExpress.XtraBars.BarStaticItem barStaticItem1;
		private DevExpress.XtraBars.BarStaticItem barStaticItemTime;
		private DevExpress.XtraBars.BarButtonItem barButtonItemAbout;
		private DevExpress.XtraBars.BarListItem barListItemAudioTracks;
		private DevExpress.XtraBars.BarButtonItem barButtonItemPlayFile;
	}
}

