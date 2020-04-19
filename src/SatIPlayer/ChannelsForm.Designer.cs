namespace SatIPlayer
{
	partial class ChannelsForm
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
			this.gridControlAllChannels = new DevExpress.XtraGrid.GridControl();
			this.gridViewAllChannels = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gridControlFavoriteChannels = new DevExpress.XtraGrid.GridControl();
			this.gridViewFavoriteChannels = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
			this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
			this.dragDropEventsFav = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
			((System.ComponentModel.ISupportInitialize)(this.gridControlAllChannels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAllChannels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlFavoriteChannels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewFavoriteChannels)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlAllChannels
			// 
			this.gridControlAllChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.gridControlAllChannels.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
			this.gridControlAllChannels.Location = new System.Drawing.Point(12, 28);
			this.gridControlAllChannels.MainView = this.gridViewAllChannels;
			this.gridControlAllChannels.Margin = new System.Windows.Forms.Padding(4);
			this.gridControlAllChannels.Name = "gridControlAllChannels";
			this.gridControlAllChannels.Size = new System.Drawing.Size(310, 482);
			this.gridControlAllChannels.TabIndex = 0;
			this.gridControlAllChannels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAllChannels});
			this.gridControlAllChannels.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
			// 
			// gridViewAllChannels
			// 
			this.behaviorManager1.SetBehaviors(this.gridViewAllChannels, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents1)))});
			this.gridViewAllChannels.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
			this.gridViewAllChannels.DetailHeight = 444;
			this.gridViewAllChannels.GridControl = this.gridControlAllChannels;
			this.gridViewAllChannels.Name = "gridViewAllChannels";
			this.gridViewAllChannels.OptionsBehavior.Editable = false;
			this.gridViewAllChannels.OptionsSelection.MultiSelect = true;
			this.gridViewAllChannels.OptionsView.ShowAutoFilterRow = true;
			this.gridViewAllChannels.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Name";
			this.gridColumn1.FieldName = "Name";
			this.gridColumn1.MinWidth = 29;
			this.gridColumn1.Name = "gridColumn1";
			this.gridColumn1.Visible = true;
			this.gridColumn1.VisibleIndex = 0;
			this.gridColumn1.Width = 109;
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControlFavoriteChannels);
			this.layoutControl1.Controls.Add(this.gridControlAllChannels);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.Root;
			this.layoutControl1.Size = new System.Drawing.Size(653, 522);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// gridControlFavoriteChannels
			// 
			this.gridControlFavoriteChannels.Location = new System.Drawing.Point(326, 28);
			this.gridControlFavoriteChannels.MainView = this.gridViewFavoriteChannels;
			this.gridControlFavoriteChannels.Name = "gridControlFavoriteChannels";
			this.gridControlFavoriteChannels.Size = new System.Drawing.Size(315, 482);
			this.gridControlFavoriteChannels.TabIndex = 4;
			this.gridControlFavoriteChannels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFavoriteChannels});
			// 
			// gridViewFavoriteChannels
			// 
			this.behaviorManager1.SetBehaviors(this.gridViewFavoriteChannels, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEventsFav)))});
			this.gridViewFavoriteChannels.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
			this.gridViewFavoriteChannels.GridControl = this.gridControlFavoriteChannels;
			this.gridViewFavoriteChannels.Name = "gridViewFavoriteChannels";
			this.gridViewFavoriteChannels.OptionsBehavior.Editable = false;
			this.gridViewFavoriteChannels.OptionsSelection.MultiSelect = true;
			this.gridViewFavoriteChannels.OptionsView.ShowAutoFilterRow = true;
			this.gridViewFavoriteChannels.OptionsView.ShowGroupPanel = false;
			// 
			// gridColumn2
			// 
			this.gridColumn2.Caption = "Name";
			this.gridColumn2.FieldName = "Name";
			this.gridColumn2.Name = "gridColumn2";
			this.gridColumn2.Visible = true;
			this.gridColumn2.VisibleIndex = 0;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(653, 522);
			this.Root.TextVisible = false;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.gridControlAllChannels;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(314, 502);
			this.layoutControlItem1.Text = "All Channels";
			this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.gridControlFavoriteChannels;
			this.layoutControlItem2.Location = new System.Drawing.Point(314, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(319, 502);
			this.layoutControlItem2.Text = "Favorite Channels";
			this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
			// 
			// dragDropEvents1
			// 
			this.dragDropEvents1.DragOver += new DevExpress.Utils.DragDrop.DragOverEventHandler(this.dragDropEvents1_DragOver);
			// 
			// dragDropEventsFav
			// 
			this.dragDropEventsFav.DragOver += new DevExpress.Utils.DragDrop.DragOverEventHandler(this.dragDropEventsFav_DragOver);
			this.dragDropEventsFav.DragDrop += new DevExpress.Utils.DragDrop.DragDropEventHandler(this.dragDropEventsFav_DragDrop);
			// 
			// ChannelsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 522);
			this.Controls.Add(this.layoutControl1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ChannelsForm";
			this.Text = "Channels";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlAllChannels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewAllChannels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControlFavoriteChannels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewFavoriteChannels)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControlAllChannels;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewAllChannels;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
		private DevExpress.XtraLayout.LayoutControl layoutControl1;
		private DevExpress.XtraGrid.GridControl gridControlFavoriteChannels;
		private DevExpress.XtraGrid.Views.Grid.GridView gridViewFavoriteChannels;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
		private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
		private DevExpress.Utils.DragDrop.DragDropEvents dragDropEventsFav;
	}
}