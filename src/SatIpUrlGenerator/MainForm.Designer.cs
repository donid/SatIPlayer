namespace SatIpUrlGenerator
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.simpleButtonReadClipboard = new DevExpress.XtraEditors.SimpleButton();
            this.textEditServerIp = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonOpenWebsite = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonOpenSatIndex = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonReadClipboardSatIndex = new DevExpress.XtraEditors.SimpleButton();
            this.textEditVlcUrl = new DevExpress.XtraEditors.ButtonEdit();
            this.textEditM3uUrl = new DevExpress.XtraEditors.ButtonEdit();
            this.textEditM3uComment = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerIp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVlcUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditM3uUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditM3uComment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButtonReadClipboard
            // 
            this.simpleButtonReadClipboard.Location = new System.Drawing.Point(160, 27);
            this.simpleButtonReadClipboard.Name = "simpleButtonReadClipboard";
            this.simpleButtonReadClipboard.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonReadClipboard.TabIndex = 0;
            this.simpleButtonReadClipboard.Text = "ReadClipboard";
            this.simpleButtonReadClipboard.Click += new System.EventHandler(this.simpleButtonReadClipboard_Click);
            // 
            // textEditServerIp
            // 
            this.textEditServerIp.EditValue = "TSS400-MKII";
            this.textEditServerIp.Location = new System.Drawing.Point(135, 8);
            this.textEditServerIp.Name = "textEditServerIp";
            this.textEditServerIp.Size = new System.Drawing.Size(158, 20);
            this.textEditServerIp.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 65);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(951, 246);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Sat>IP Server Name/IP:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(12, 452);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "VLC Url:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Location = new System.Drawing.Point(12, 478);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "M3U Url:";
            // 
            // simpleButtonOpenWebsite
            // 
            this.simpleButtonOpenWebsite.Location = new System.Drawing.Point(12, 27);
            this.simpleButtonOpenWebsite.Name = "simpleButtonOpenWebsite";
            this.simpleButtonOpenWebsite.Size = new System.Drawing.Size(142, 23);
            this.simpleButtonOpenWebsite.TabIndex = 6;
            this.simpleButtonOpenWebsite.Text = "Open digitalfernsehen.de";
            this.simpleButtonOpenWebsite.Click += new System.EventHandler(this.simpleButtonOpenWebsite_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(253, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(262, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Hint: Copy the complete channel-table to the clipboard";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl5.Location = new System.Drawing.Point(12, 505);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "M3U Comment:";
            // 
            // simpleButtonOpenSatIndex
            // 
            this.simpleButtonOpenSatIndex.Location = new System.Drawing.Point(12, 32);
            this.simpleButtonOpenSatIndex.Name = "simpleButtonOpenSatIndex";
            this.simpleButtonOpenSatIndex.Size = new System.Drawing.Size(142, 23);
            this.simpleButtonOpenSatIndex.TabIndex = 8;
            this.simpleButtonOpenSatIndex.Text = "Open Satindex.de";
            this.simpleButtonOpenSatIndex.Click += new System.EventHandler(this.simpleButtonOpenSatIndex_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(253, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(362, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Hint: Copy the URL of the Satindex.de page of the channel to the clipboard";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // simpleButtonReadClipboardSatIndex
            // 
            this.simpleButtonReadClipboardSatIndex.Location = new System.Drawing.Point(160, 32);
            this.simpleButtonReadClipboardSatIndex.Name = "simpleButtonReadClipboardSatIndex";
            this.simpleButtonReadClipboardSatIndex.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonReadClipboardSatIndex.TabIndex = 9;
            this.simpleButtonReadClipboardSatIndex.Text = "ReadClipboard";
            this.simpleButtonReadClipboardSatIndex.Click += new System.EventHandler(this.simpleButtonReadClipboardSatIndex_Click);
            // 
            // textEditVlcUrl
            // 
            this.textEditVlcUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditVlcUrl.Location = new System.Drawing.Point(91, 449);
            this.textEditVlcUrl.Name = "textEditVlcUrl";
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.textEditVlcUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.textEditVlcUrl.Size = new System.Drawing.Size(897, 22);
            this.textEditVlcUrl.TabIndex = 5;
            this.textEditVlcUrl.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit_ButtonClick);
            // 
            // textEditM3uUrl
            // 
            this.textEditM3uUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditM3uUrl.Location = new System.Drawing.Point(91, 475);
            this.textEditM3uUrl.Name = "textEditM3uUrl";
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.textEditM3uUrl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.textEditM3uUrl.Size = new System.Drawing.Size(897, 22);
            this.textEditM3uUrl.TabIndex = 5;
            this.textEditM3uUrl.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit_ButtonClick);
            // 
            // textEditM3uComment
            // 
            this.textEditM3uComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditM3uComment.Location = new System.Drawing.Point(91, 502);
            this.textEditM3uComment.Name = "textEditM3uComment";
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.textEditM3uComment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.textEditM3uComment.Size = new System.Drawing.Size(897, 22);
            this.textEditM3uComment.TabIndex = 5;
            this.textEditM3uComment.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.simpleButtonOpenWebsite);
            this.groupControl1.Controls.Add(this.simpleButtonReadClipboard);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 112);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(976, 325);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "DigitalFernsehen.de";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.simpleButtonReadClipboardSatIndex);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.simpleButtonOpenSatIndex);
            this.groupControl2.Location = new System.Drawing.Point(12, 34);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(976, 72);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Satindex.de";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditServerIp);
            this.Controls.Add(this.textEditVlcUrl);
            this.Controls.Add(this.textEditM3uUrl);
            this.Controls.Add(this.textEditM3uComment);
            this.Name = "MainForm";
            this.Text = "SAT>IP URL-Generator";
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerIp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditVlcUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditM3uUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditM3uComment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButtonReadClipboard;
		private DevExpress.XtraEditors.TextEdit textEditServerIp;
		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.SimpleButton simpleButtonOpenWebsite;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.SimpleButton simpleButtonOpenSatIndex;
		private DevExpress.XtraEditors.LabelControl labelControl6;
		private DevExpress.XtraEditors.SimpleButton simpleButtonReadClipboardSatIndex;
		private DevExpress.XtraEditors.ButtonEdit textEditVlcUrl;
		private DevExpress.XtraEditors.ButtonEdit textEditM3uUrl;
		private DevExpress.XtraEditors.ButtonEdit textEditM3uComment;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
	}
}

