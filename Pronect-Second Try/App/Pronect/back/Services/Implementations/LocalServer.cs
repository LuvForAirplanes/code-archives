using Pronect.Models.TcpServers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pronect.Services.Implementations
{
    public class LocalServer : IMachineService
    {
        private readonly Client _client;

        public LocalServer()
        {
            _client = new Client();
        }

        public string Ip { get; set; }

        public void Authorize()
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            
        }
    }
}
