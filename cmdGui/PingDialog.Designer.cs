/*
 * Created by SharpDevelop.
 * User: m.sarioglu
 * Date: 3-7-13
 * Time: 8:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cmdGui
{
	partial class PingDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingDialog));
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmdPing = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(110, 10);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(152, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIPKeyDown);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(15, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(89, 14);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Host/IP Address:";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdPing
            // 
            this.cmdPing.Location = new System.Drawing.Point(15, 30);
            this.cmdPing.Name = "cmdPing";
            this.cmdPing.Size = new System.Drawing.Size(96, 23);
            this.cmdPing.TabIndex = 1;
            this.cmdPing.Text = "Ping";
            this.cmdPing.UseVisualStyleBackColor = true;
            this.cmdPing.Click += new System.EventHandler(this.CmdPingClick);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(117, 30);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(77, 23);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancelClick);
            // 
            // chkRepeat
            // 
            this.chkRepeat.Location = new System.Drawing.Point(200, 30);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(62, 23);
            this.chkRepeat.TabIndex = 4;
            this.chkRepeat.Text = "Repeat";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // PingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 62);
            this.Controls.Add(this.chkRepeat);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdPing);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PingDialog";
            this.ShowInTaskbar = false;
            this.Text = "Ping";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PingDialogFormClosing);
            this.Load += new System.EventHandler(this.PingDialogLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkRepeat;
		private System.Windows.Forms.Button cmdCancel;
		private System.Windows.Forms.Button cmdPing;
		private System.Windows.Forms.Label lblInfo;
		public System.Windows.Forms.TextBox txtIP;
	}
}
