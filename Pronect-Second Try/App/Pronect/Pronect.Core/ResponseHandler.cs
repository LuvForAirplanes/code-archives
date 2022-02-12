using Newtonsoft.Json;
using Pronect.Core.Models;
using Pronect.Core.Services;
using Pronect.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Pronect.ScreenCaptureServices;

namespace Pronect.Core
{
    public static class ResponseHandler
    {
        public static ConnectionDetails ConnectionDetails { private set; get; }

        public static void IncomingBytes(byte[] bytes)
        {
            TcpSend incomingCommands = JsonConvert.DeserializeObject<TcpSend>(Encoding.ASCII.GetString(bytes));

            foreach (var command in incomingCommands.Commands)
            {
                switch (command.CommandName)
                {
                    case "aaaa":
                     if(command.Parameters[1] == PronectInstance.TempPassword)
                        {
                            ConnectionDetails.IsAuthenticated = true;
                        } else if (command.Parameters[1] == PronectInstance.PermPassword)
                        {
                            ConnectionDetails.IsAuthenticated = true;
                            ConnectionDetails.HasPermKey = true;
                        } else
                        {
                            Server.Stop();
                            Server.Start();
                        }
                        break;
                    case "aaab":
                        if(ConnectionDetails.IsAuthenticated == true)
                        {
                            StartScreenShots();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public static async Task StartScreenShots()
        {
            ScreenCaptureServices screenCaptureServices = new ScreenCaptureServices();
            ConversionService conversionService = new ConversionService();

            Server.DataToSend.Commands.Add(new TcpCommand() { CommandName = "aaac", Parameters = new List<string>() { Encoding.ASCII.GetString(conversionService.ImageToByte(screenCaptureServices.CaptureWindow(User32.GetDesktopWindow()))) } });
        }
    }
}
