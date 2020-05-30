namespace SatIPlayer
{
	partial class AboutForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
			this.textEditVlcVersion = new DevExpress.XtraEditors.TextEdit();
			this.textEditVlcLibDirectory = new DevExpress.XtraEditors.TextEdit();
			this.textEditSatIPlayerVersion = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditVlcVersion.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditVlcLibDirectory.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSatIPlayerVersion.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// textEdit1
			// 
			this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEdit1.EditValue = "Homepage: https://github.com/donid/SatIPlayer";
			this.textEdit1.Location = new System.Drawing.Point(12, 12);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Properties.ReadOnly = true;
			this.textEdit1.Size = new System.Drawing.Size(495, 20);
			this.textEdit1.TabIndex = 2;
			// 
			// textEdit2
			// 
			this.textEdit2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEdit2.EditValue = "GUI and other icons from DevExpress  https://www.devexpress.com";
			this.textEdit2.Location = new System.Drawing.Point(12, 141);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.ReadOnly = true;
			this.textEdit2.Size = new System.Drawing.Size(495, 20);
			this.textEdit2.TabIndex = 2;
			// 
			// textEdit3
			// 
			this.textEdit3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEdit3.EditValue = "Icons from Icons8 https://icons8.com";
			this.textEdit3.Location = new System.Drawing.Point(12, 115);
			this.textEdit3.Name = "textEdit3";
			this.textEdit3.Properties.ReadOnly = true;
			this.textEdit3.Size = new System.Drawing.Size(495, 20);
			this.textEdit3.TabIndex = 2;
			// 
			// textEditVlcVersion
			// 
			this.textEditVlcVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEditVlcVersion.EditValue = "VlcVersion";
			this.textEditVlcVersion.Location = new System.Drawing.Point(12, 63);
			this.textEditVlcVersion.Name = "textEditVlcVersion";
			this.textEditVlcVersion.Properties.ReadOnly = true;
			this.textEditVlcVersion.Size = new System.Drawing.Size(495, 20);
			this.textEditVlcVersion.TabIndex = 2;
			// 
			// textEditVlcLibDirectory
			// 
			this.textEditVlcLibDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEditVlcLibDirectory.EditValue = "VlcLibDirectory";
			this.textEditVlcLibDirectory.Location = new System.Drawing.Point(12, 89);
			this.textEditVlcLibDirectory.Name = "textEditVlcLibDirectory";
			this.textEditVlcLibDirectory.Properties.ReadOnly = true;
			this.textEditVlcLibDirectory.Size = new System.Drawing.Size(495, 20);
			this.textEditVlcLibDirectory.TabIndex = 2;
			// 
			// textEditSatIPlayerVersion
			// 
			this.textEditSatIPlayerVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textEditSatIPlayerVersion.EditValue = "SatIPlayer Version";
			this.textEditSatIPlayerVersion.Location = new System.Drawing.Point(12, 38);
			this.textEditSatIPlayerVersion.Name = "textEditSatIPlayerVersion";
			this.textEditSatIPlayerVersion.Properties.ReadOnly = true;
			this.textEditSatIPlayerVersion.Size = new System.Drawing.Size(495, 20);
			this.textEditSatIPlayerVersion.TabIndex = 2;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(519, 217);
			this.Controls.Add(this.textEditVlcLibDirectory);
			this.Controls.Add(this.textEditVlcVersion);
			this.Controls.Add(this.textEdit3);
			this.Controls.Add(this.textEdit2);
			this.Controls.Add(this.textEditSatIPlayerVersion);
			this.Controls.Add(this.textEdit1);
			this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AboutForm.IconOptions.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AboutForm";
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditVlcVersion.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditVlcLibDirectory.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEditSatIPlayerVersion.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.TextEdit textEdit3;
		private DevExpress.XtraEditors.TextEdit textEditVlcVersion;
		private DevExpress.XtraEditors.TextEdit textEditVlcLibDirectory;
		private DevExpress.XtraEditors.TextEdit textEditSatIPlayerVersion;
	}
}