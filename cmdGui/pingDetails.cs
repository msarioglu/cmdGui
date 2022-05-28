using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cmdGui
{
    public class PingDetails
    {
        public string hostName { get; set; }
        public int timeout { get; set; }
        public byte[] buffer { get; set; }

        public PingDetails(String hostName, int timeout, int bufferSize)
        {
            this.hostName = hostName;
            this.timeout = timeout;
            this.buffer = new byte[bufferSize];
        }
    }
}
