using System;
using System.Net.NetworkInformation;

namespace cmdGui
{
	static class ResultPing
	{
		
		#region Multi Ping Function
		internal static bool MultiPingResult(string Hostname)
		{
			bool state = false;
			byte[] buffer = new byte[1];
			int timeout = 300;				
			try {
				Ping sender = new Ping();
				PingReply reply = sender.Send(Hostname, timeout, buffer);
				if (reply.Status == IPStatus.Success)
					state = true;
			} catch {
				state = false;
			}
			return state;
		}
		#endregion
		
		
		#region Single Ping Function
		internal static string SinglePingResult(string Hostname)
		{
			string State = "Status: Offline";
			byte[] buffer = new byte[1];
			int timeout	= 300;		
			try {
				Ping sender = new Ping();
				PingReply reply = sender.Send(Hostname, timeout, buffer);
			if (reply.Status == IPStatus.Success)
				State = "[Status] Online\r\n[IP] " + reply.Address.ToString() + "\r\n[Time] " + reply.RoundtripTime + "ms";
			} catch {
				State = "Status: Offline";
			}
			return State.ToString();
		}
		#endregion
	}
}
