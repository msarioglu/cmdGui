using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace cmdGui
{
	public class PingAPI
	{

        private Ping ping = null;
        private PingReply pingReply = null;

        #region Class Contstructor
        public PingAPI()
		{
            ping = new Ping();

        }
        #endregion


        #region pingRequest
        public String pingRequest(PingDetails pingDetails)
        {
            try
            {
                pingReply = ping.Send(pingDetails.hostName, pingDetails.timeout, pingDetails.buffer);
            } catch (Exception exception)
            {
                throw new PingException(exception.Message);
            }
            return ToString();
        }
        #endregion
        
        public List<PingReply> pingRequest(List<PingDetails> pingDetails)
        {
            List<PingReply> resultSet = new List<PingReply>();
            foreach (PingDetails pingDetail in pingDetails)
            {
                try
                {
                    pingReply = ping.Send(pingDetail.hostName, pingDetail.timeout, pingDetail.buffer);
                    resultSet.Add(pingReply);
                }
                catch (Exception ex)
                {
                    throw new PingException(ex.Message);
                }

            }
            return resultSet;
        }

        public String ToString()
        {
            return "Host: " + pingReply.Address +
                "\r\nStatus: " + pingReply.Status +
                "\r\nBytes = " + pingReply.Buffer.Length +
                "\r\nTime = " + pingReply.RoundtripTime + " ms" +
                "\r\nTTL = " + pingReply.Options.Ttl;
        }


        #region Multi Ping Function
        public string MultiPingResult(string Hostname, int timeout)
		{
			string State = "";
			byte[] buffer = new byte[1];		
			try {
				Ping sender = new Ping();
				PingReply reply = sender.Send(Hostname, timeout, buffer);
				if (reply.Status == IPStatus.Success){
					State = "";
				} else {
					State = "#";
				}
			} catch {
				State = "#";
			}
			return State.ToString() + Hostname.ToString();
		}
		#endregion
		
	}
}
