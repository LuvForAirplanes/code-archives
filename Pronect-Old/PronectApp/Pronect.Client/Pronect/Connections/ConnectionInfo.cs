using Pronect.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronect.Connections
{
    public static class ConnectionInfo
    {
        private static string connectionServerDomain = "pronect.hopto.org";
        private static string directoryServerDomain = "pronect.hopto.org";

        private static string connectionServerIp = "";
        private static string connectionServerPort = "";
        private static string directoryServerIp = "";
        private static string directoryServerPort = "";

        /// <summary>
        /// The domain at which the connection server is located.
        /// </summary>
        public static string ConnectionServerDomain {
            get
            {
                return connectionServerDomain;
            }
            set
            {
                connectionServerDomain = value;
            }
        }
        /// <summary>
        /// The domain at which the directory server is located.
        /// </summary>
        public static string DirectoryServerDomain
        {
            get
            {
                return directoryServerDomain;
            }
            set
            {
                directoryServerDomain = value;
            }
        }
        /// <summary>
        /// The Ip on which the connection server is available at.
        /// </summary>
        public static string ConnectionServerIp
        {
            get
            {
                connectionServerIp = Network.ResolveDomainName(connectionServerDomain)[0].ToString();
                return connectionServerIp;
            }
            set
            {
                connectionServerIp = value;
            }
        }
        /// <summary>
        /// The port on which the connection server is listening on.
        /// </summary>
        public static string ConnectionServerPort
        {
            get
            {
                return connectionServerPort;
            }
            set
            {
                connectionServerPort = value;
            }
        }
        /// <summary>
        /// The Ip on which the directory server is available at.
        /// </summary>
        public static string DirectoryServerIp
        {
            get
            {
                directoryServerIp = Network.ResolveDomainName(directoryServerIp)[0].ToString();
                return directoryServerIp;
            }
            set
            {
                directoryServerIp = value;
            }
        }
        /// <summary>
        /// The port on which the directory server is listening on.
        /// </summary>
        public static string DirectoryServerPort
        {
            get
            {
                return directoryServerPort;
            }
            set
            {
                directoryServerPort = value;
            }
        }
    }
}
