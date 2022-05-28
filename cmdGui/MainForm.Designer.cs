/*
 * Created by SharpDevelop.
 * User: m.sarioglu
 * Date: 28-6-13
 * Time: 11:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cmdGui
{
	partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblCaption = new System.Windows.Forms.Label();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.autoPing = new System.Windows.Forms.Timer(this.components);
            this.expOut = new System.Windows.Forms.Button();
            this.cout = new System.Windows.Forms.ListView();
            this.clmIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.pBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOn = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOff = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.impIn = new System.Windows.Forms.Button();
            this.cmdShowPing = new System.Windows.Forms.Button();
            this.lblBuild = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Location = new System.Drawing.Point(12, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(75, 13);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "IP Adresses:";
            // 
            // cmdStart
            // 
            this.cmdStart.Enabled = false;
            this.cmdStart.Location = new System.Drawing.Point(15, 161);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(120, 23);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start Scan";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.CmdStartClick);
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(15, 190);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(120, 22);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "Stop Scan";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.CmdStopClick);
            // 
            // nIcon
            // 
            this.nIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "Pinger - MS-AR";
            this.nIcon.Visible = true;
            this.nIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NIconMouseClick);
            // 
            // expOut
            // 
            this.expOut.Enabled = false;
            this.expOut.Location = new System.Drawing.Point(324, 78);
            this.expOut.Name = "expOut";
            this.expOut.Size = new System.Drawing.Size(120, 21);
            this.expOut.TabIndex = 2;
            this.expOut.Text = "Export Results";
            this.expOut.UseVisualStyleBackColor = true;
            this.expOut.Click += new System.EventHandler(this.ExpOutClick);
            // 
            // cout
            // 
            this.cout.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.cout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cout.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmIP,
            this.clmStatus});
            this.cout.FullRowSelect = true;
            this.cout.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cout.HideSelection = false;
            this.cout.Location = new System.Drawing.Point(12, 24);
            this.cout.MultiSelect = false;
            this.cout.Name = "cout";
            this.cout.ShowGroups = false;
            this.cout.Size = new System.Drawing.Size(306, 131);
            this.cout.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.cout.TabIndex = 4;
            this.cout.TabStop = false;
            this.cout.UseCompatibleStateImageBehavior = false;
            this.cout.View = System.Windows.Forms.View.Details;
            // 
            // clmIP
            // 
            this.clmIP.Text = "IP / Host";
            this.clmIP.Width = 210;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 98;
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pBar,
            this.lblTotal,
            this.lblOn,
            this.lblOff});
            this.statusBar.Location = new System.Drawing.Point(0, 220);
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusBar.Size = new System.Drawing.Size(471, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 8;
            this.statusBar.Text = "staStrip";
            // 
            // pBar
            // 
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 17);
            this.lblTotal.Text = "Total: 0/0";
            // 
            // lblOn
            // 
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(54, 17);
            this.lblOn.Text = "Online: 0";
            // 
            // lblOff
            // 
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(55, 17);
            this.lblOff.Text = "Offline: 0";
            // 
            // openFile
            // 
            this.openFile.Filter = "Notepad|*.txt";
            this.openFile.Title = "Import IP List";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Excel|*.csv|Notepad|*.txt";
            this.saveFile.Title = "Export List";
            // 
            // impIn
            // 
            this.impIn.Location = new System.Drawing.Point(324, 51);
            this.impIn.Name = "impIn";
            this.impIn.Size = new System.Drawing.Size(120, 21);
            this.impIn.TabIndex = 9;
            this.impIn.Text = "Import IP List";
            this.impIn.UseVisualStyleBackColor = true;
            this.impIn.Click += new System.EventHandler(this.ImpInClick);
            // 
            // cmdShowPing
            // 
            this.cmdShowPing.Location = new System.Drawing.Point(324, 24);
            this.cmdShowPing.Name = "cmdShowPing";
            this.cmdShowPing.Size = new System.Drawing.Size(120, 21);
            this.cmdShowPing.TabIndex = 10;
            this.cmdShowPing.Text = "Single PING";
            this.cmdShowPing.UseVisualStyleBackColor = true;
            this.cmdShowPing.Click += new System.EventHandler(this.CmdShowPingClick);
            // 
            // lblBuild
            // 
            this.lblBuild.Location = new System.Drawing.Point(232, -1);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(135, 15);
            this.lblBuild.TabIndex = 11;
            this.lblBuild.Text = "Build: 1.1.0";
            this.lblBuild.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 242);
            this.Controls.Add(this.lblBuild);
            this.Controls.Add(this.cmdShowPing);
            this.Controls.Add(this.impIn);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.cout);
            this.Controls.Add(this.expOut);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PiNGeR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Resize += new System.EventHandler(this.MainFormResize);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblBuild;
		private System.Windows.Forms.Button cmdShowPing;
		private System.Windows.Forms.Button impIn;
		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.OpenFileDialog openFile;
		private System.Windows.Forms.ColumnHeader clmStatus;
		private System.Windows.Forms.ColumnHeader clmIP;
		private System.Windows.Forms.ToolStripStatusLabel lblOff;
		private System.Windows.Forms.ToolStripStatusLabel lblTotal;
		private System.Windows.Forms.ToolStripProgressBar pBar;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.ToolStripStatusLabel lblOn;
		private System.Windows.Forms.ListView cout;
		private System.Windows.Forms.Button expOut;
		private System.Windows.Forms.Timer autoPing;
		internal System.Windows.Forms.NotifyIcon nIcon;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.Button cmdStart;
		private System.Windows.Forms.Label lblCaption;
	}
}
