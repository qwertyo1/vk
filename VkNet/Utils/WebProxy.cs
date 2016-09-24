using System;
using System.Net;

namespace VkNet.Utils
{
    public class WebProxy : IWebProxy
    {
        public string Host { get; }

        public int Port { get; }

        public WebProxy(string host, int port)
        {
            Host = host;
            Port = port;
        }

        #region Implementation of IWebProxy

        public Uri GetProxy(Uri destination)
        {
            return destination;
        }

        public bool IsBypassed(Uri host)
        {
            return false;
        }

        public ICredentials Credentials { get; set; }

        #endregion
    }
}