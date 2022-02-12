using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Pronect.Services
{
    public interface INetworkService 
    {
        IPAddress GetLocalIP();
    }
}
