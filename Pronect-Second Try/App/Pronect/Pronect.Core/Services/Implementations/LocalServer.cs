using Newtonsoft.Json;
using Pronect.Models;
using Pronect.Models.TcpServers;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
        
        public void Connect()
        {
            _client.IPAddress = IPAddress.Parse(Ip);
            _client.Port = 56372;
            _client.Connect();

            Reader();
        }

        public void Authorize(string password)
        {
            _client.Write(Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new TcpSend() { Commands = new List<TcpCommand>() { new TcpCommand() { CommandName = "aaaa", Parameters = new List<string>() { password } } } })));
        }
        
        public bool Authorized
        {
            get
            {
                return authorized;
            }
        }

        private bool authorized { get; set; }

        public async Task Reader()
        {
            while(true)
            {
                var returns = JsonConvert.DeserializeObject<TcpSend>(Encoding.ASCII.GetString(await _client.ReadAsync()));

                foreach (var command in returns.Commands)
                {
                    switch (command.CommandName)
                    {
                        case "aaaa":
                            if(command.Parameters[0] == "true")
                            {
                                authorized = true;
                            }
                            else
                            {
                                authorized = false;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
