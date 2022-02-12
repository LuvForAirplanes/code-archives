using Pronect.Core.Models;
using Pronect.Services;
using Pronect.Services.Implementations;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pronect
{
    /// <summary>
    /// A Pronect Session in which you can connect and control a remote machine.
    /// </summary>
    public class PronectSession
    {
        IMachineService machineService;

        public PronectSession() { }

        public PronectSession(string id, string password)
        {
            Id = id;
            Password = password;
        }

        /// <summary>
        /// The Id of your partner.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The Password of your partner.
        /// </summary>
        public string Password { get; set; }

        public void Connect()
        {
            if (Id.Contains("."))
            {
                machineService = new LocalServer();
                machineService.Connect();
            } else
            {
                machineService = new RemoteServer();
            }
        }

        public AuthoToken Authorize()
        {
            machineService.Authorize(Password);
            return new AuthoToken() { IsAuthorized = true };
        }

        public void OpenDesktopConnection()
        {
            
        }
    }
}
