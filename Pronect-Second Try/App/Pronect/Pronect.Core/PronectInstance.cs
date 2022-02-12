using Pronect.Services;
using Pronect.Services.Implementations;

namespace Pronect
{
    public static class PronectInstance
    {
        //█████████                                                             ██
        //██     ██                                                             ██
        //██     ██                                                    ██       ██
        //█████████  ███████   ███████   ████████   ██████   ██████  ██████     ██
        //██         ██       ██     ██  ██    ██  ███████  ██         ██       ██
        //██         ██       ██     ██  ██    ██  ██       ██         ██       ██
        //██         ██        ███████   ██    ██   ██████   ██████    ██       ██

        //Single incoming client connections

        public const string Id = "1234567889";
        public const string TempPassword = "123456";
        public const string PermPassword = "tempChris";

        private static readonly INetworkService _networkService;

        static PronectInstance()
        {
            _networkService = new NetworkService();
        }
        /// <summary>
        /// Initializes the Pronect app and begins listening for incoming LAN connections.
        /// </summary>
        public static void Initialize()
        {
            Server.IPAddress = _networkService.GetLocalIP();
            Server.Start();
        }
    }
}
