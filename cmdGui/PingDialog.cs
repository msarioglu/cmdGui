using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace cmdGui
{
	public partial class PingDialog : Form
	{
		#region Variables
		#endregion
		
		#region Class Constructor
		public PingDialog()
		{
			InitializeComponent();
		}
		#endregion
		
		#region Ping Button	
		void CmdPingClick(object sender, EventArgs e)
		{
			Thread s_ping = new Thread(chkPingFunction);
			s_ping.Start();
			this.Hide();
		}
		#endregion

		#region Cancel Button	
		void CmdCancelClick(object sender, EventArgs e)
		{
			chkRepeat.Checked = false;
			this.Hide();
		}
		#endregion
		
		#region Dialog Closing
		void PingDialogFormClosing(object sender, FormClosingEventArgs e)
		{
			this.Hide();
			e.Cancel = true;
		}
		#endregion
		
		
		void chkPingFunction()
		{
			try {
			do {
				pingFunction();
				Thread.Sleep(5000);
			} while (chkRepeat.Checked);					
			} catch {
				pingFunction();
				Thread.Sleep(5000);
			}
		}
		
		void pingFunction()
		{
			this.Invoke( ( MethodInvoker )delegate()
            {
				MainForm mf = (MainForm)Application.OpenForms["MainForm"];
				mf.showBalloon();
			});
		}
		
		void TxtIPKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				Thread s_ping = new Thread(chkPingFunction);
				s_ping.Start();
				this.Hide();
			}
		}
		
		void PingDialogLoad(object sender, EventArgs e)
		{
			txtIP.Focus();
		}
	}
}
