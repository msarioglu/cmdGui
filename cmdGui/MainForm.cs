using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace cmdGui
{
	public partial class MainForm : Form
	{	
		#region Variables
			PingDialog pDialog = new PingDialog();
			ContextMenu m_menu = new ContextMenu();	
			List<string> DataList = new List<string>();
		public int offline = 0, online = 0, total = 0;
		#endregion
		
		#region Main Constructor
		public MainForm()
		{
			InitializeComponent();
			ContextMenu();	
			lblBuild.Text = "Build: " + Application.ProductVersion.ToString();
		}
		#endregion
		
		#region Context Menu
		void ContextMenu(){
			m_menu.MenuItems.Add(0, new MenuItem("Open",new EventHandler(Open_Click))); 
			m_menu.MenuItems.Add(1, new MenuItem("Ping",new EventHandler(Ping_Click))); 
			m_menu.MenuItems.Add(2, new MenuItem("Exit",new EventHandler(Exit_Click)));
			nIcon.ContextMenu = m_menu;	}
		#endregion
						
		#region Start Button
		void CmdStartClick(object sender, EventArgs e){
			cout.Enabled = false;
			cmdStart.Enabled = false;
			cmdStop.Enabled = true;
			impIn.Enabled = false;
			expOut.Enabled = false;
			ResetState();
			PingConfig();}
		#endregion
						
		#region Reset State
		void ResetState(){
				total = 0;
				online = 0;
				offline = 0;
				this.Refresh();
				initStatusStrip();
				cout.Items.Clear();}
		#endregion
		
		#region Initialize Status Strip		
		void initStatusStrip(){
				Application.DoEvents();
				pBar.Value = total;
				lblOn.Text = "Online: " + online;
				lblOff.Text = "Offline: " + offline;
				lblTotal.Text = "Total: " + total + "/" + DataList.Count;}
		#endregion
		
		#region Show Balloon
		public void showBalloon(){	
				nIcon.BalloonTipText = ResultPing.SinglePingResult(pDialog.txtIP.Text).ToString();
				nIcon.BalloonTipTitle = pDialog.txtIP.Text;
			    nIcon.ShowBalloonTip(1);		
}
		#endregion
				
		#region Online Offline Check
		void OnOff(string multiIP){
			this.Invoke( ( MethodInvoker )delegate(){
			Application.DoEvents();			
			ListViewItem nItem = new ListViewItem(multiIP);
			string ipState = "Offline";
			switch (ResultPing.MultiPingResult(multiIP)) 
			{	case true:
					ipState = "Online";
					nItem.BackColor = Color.Green;
					nItem.ForeColor = Color.White;
					online++;
					total++;
					initStatusStrip();
					break;
				case false:
					ipState = "Offline";
					nItem.BackColor = Color.Red;
					nItem.ForeColor = Color.Black;
					offline++;
					total++;
					initStatusStrip();
					break;}
			
			cout.Items.Add(nItem).SubItems.Add(ipState);
			pBar.Value = total;
			this.Invalidate(); 
			if  (DataList.Count == cout.Items.Count)
			{	cout.Enabled = true;cmdStart.Enabled = true;cmdStop.Enabled = false;expOut.Enabled = true;}});}
		#endregion
				
		#region Ping Config
		void PingConfig(){     
				foreach (var ip in DataList) {	
					string multiIP = ip;
					Application.DoEvents();					
					WaitCallback cBack = delegate(object state){
						if (cmdStop.Enabled == true)
						{	OnOff(multiIP);	}
					};
					Thread.Sleep(300);
					ThreadPool.QueueUserWorkItem(cBack);
				}
		}
		#endregion
				
		#region Stop Button
		void CmdStopClick(object sender, EventArgs e)
		{pBar.Value = 0;autoPing.Enabled = false;cout.Enabled = true;cmdStart.Enabled = true;cmdStop.Enabled = false;impIn.Enabled = true;expOut.Enabled = true;}
		#endregion
		
		#region Import Button
		void ImpInClick(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK) {
				DataList.AddRange(File.ReadAllLines(openFile.FileName));
				pBar.Maximum = DataList.Count;
				MessageBox.Show("Found " + DataList.Count + " IP addresses!","PiNGeR",MessageBoxButtons.OK,MessageBoxIcon.Information);
				initStatusStrip();
				pBar.Value = 0;autoPing.Enabled = false;cout.Enabled = true;cmdStart.Enabled = true;cmdStop.Enabled = false;impIn.Enabled = true;
			}
		}
		#endregion
		
		#region Export Button
		void ExpOutClick(object sender, EventArgs e){
			if (saveFile.ShowDialog() == DialogResult.OK) {
				using (StreamWriter exporter = new StreamWriter(saveFile.OpenFile())){
				exporter.WriteLine("IP/Host,Online,Offline");
				foreach(ListViewItem Host in cout.Items){
						foreach(ListViewItem.ListViewSubItem State in Host.SubItems)
							if(State.Text.EndsWith("Online"))
							{
								exporter.WriteLine(Host.Text + State.Text.Replace("Online",",X,O"));
							}
							else if(State.Text.EndsWith("Offline"))
							{
								exporter.WriteLine(Host.Text + State.Text.Replace("Offline",",O,X"));
							}
					}
				}
			}
		}
		#endregion
		
		#region Context Button Open Handler
		void Open_Click(Object sender, System.EventArgs e) 
			{Show();WindowState = FormWindowState.Normal;this.Focus();}
		#endregion
		
		#region Context Button Exit Handler	
		void Exit_Click(Object sender, System.EventArgs e) 
			{nIcon.Visible = false;Environment.Exit(0);}
		#endregion
		
		#region Context Button Ping Handler
		void Ping_Click(Object sender, System.EventArgs e) 
			{pDialog.ShowDialog();pDialog.Focus();}
		#endregion
		
		#region Notify Icon Click Handler
		void NIconMouseClick(object sender, MouseEventArgs e){
			if(e.Button == MouseButtons.Left)
			{pDialog.Show();}}
		#endregion
		
		#region Form Resize
		void MainFormResize(object sender, EventArgs e){
			if (FormWindowState.Minimized == this.WindowState)
			{this.Hide();}}
		#endregion
		
		#region Form Closing
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
			{ nIcon.Visible = false;Environment.Exit(0);}
		#endregion
		
		
		void CmdShowPingClick(object sender, EventArgs e)
		{this.Hide();pDialog.ShowDialog();pDialog.Focus();}
	}
}