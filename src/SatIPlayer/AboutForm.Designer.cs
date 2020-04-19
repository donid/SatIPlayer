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
			this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.SuspendLayout();
			// 
			// hyperlinkLabelControl1
			// 
			this.hyperlinkLabelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
			this.hyperlinkLabelControl1.Location = new System.Drawing.Point(12, 45);
			this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
			this.hyperlinkLabelControl1.Size = new System.Drawing.Size(179, 13);
			this.hyperlinkLabelControl1.TabIndex = 0;
			this.hyperlinkLabelControl1.Text = "Icons from Icons8 https://icons8.com";
			// 
			// hyperlinkLabelControl2
			// 
			this.hyperlinkLabelControl2.Location = new System.Drawing.Point(12, 78);
			this.hyperlinkLabelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
			this.hyperlinkLabelControl2.Size = new System.Drawing.Size(330, 13);
			this.hyperlinkLabelControl2.TabIndex = 0;
			this.hyperlinkLabelControl2.Text = "GUI and other icons from DevExpress  https://www.devexpress.com";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 215);
			this.Controls.Add(this.hyperlinkLabelControl2);
			this.Controls.Add(this.hyperlinkLabelControl1);
			this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("AboutForm.IconOptions.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AboutForm";
			this.Text = "About";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
		private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
	}
}