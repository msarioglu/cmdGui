using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace cmdGui
{
    class PingException : Exception
    {
        public PingException()
        {
        }

        public PingException(string message) : base(message)
        {
        }

        public PingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
