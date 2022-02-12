using Pronect.Services;
using System.Drawing;
using System;
using Pronect.DTOs.StreamData;
using System.Collections.Generic;
using System.Windows;
using System.Timers;
using Newtonsoft.Json;
using static Pronect.ScreenCapture;
using System.Text;
using Pronect.Connections;

namespace Pronect
{
    public class RemoteMachine
    {
        public RemoteMachine()
        {

        }

        

        public enum ClickDirection
        {
            Right,
            Left
        }
        /// <summary>
         /// A list of browsers that possibly could be opened on the remote machine.
         /// </summary>
        public enum Browsers
        {
            GoogleChrome,
            InternetExplorer,
            Firefox,
            Opera,
            DefaultBrowser
        }
        /// <summary>
        /// Gets the total amount of running processes on the remote machine.
        /// </summary>
        /// <returns></returns>
        public int GetTotalProcesses()
        {
            Command command = new Command()
            {
                Name = "aaa"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets the current CPU load on the remote machine in GHz.
        /// </summary>
        /// <returns></returns>
        public long GetCPULoad()
        {
            Command command = new Command()
            {
                Name = "aab"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets the CPU's max speed on the remote machine in GHz.
        /// </summary>
        /// <returns></returns>
        public long GetCPUMax()
        {
            Command command = new Command()
            {
                Name = "aac"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets the CPU's base speed on the remote machine in GHz.
        /// </summary>
        /// <returns></returns>
        public long GetCPUBaseSpeed()
        {
            Command command = new Command()
            {
                Name = "aad"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets the total RAM on the remote machine in gigabytes.
        /// </summary>
        /// <returns></returns>
        public int GetTotalRAM()
        {
            Command command = new Command()
            {
                Name = "aae"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets the total used RAM on the remote machine in gigabytes.
        /// </summary>
        /// <returns></returns>
        public int GetTotalUsedRam()
        {
            Command command = new Command()
            {
                Name = "aaf"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets a list of disks from the remote machine.
        /// </summary>
        /// <returns></returns>
        public List<string> GetDisks()
        {
            Command command = new Command()
            {
                Name = "aag"
            };
            ConnectionServer.Commands.Add(command);
            return null;
        }
        /// <summary>
        /// Gets a disk name by the diskId.
        /// </summary>
        /// <param name="diskId"></param>
        /// <returns></returns>
        public string GetDiskName(string diskId)
        {
            Command command = new Command()
            {
                Name = "aah"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the disk serial number by the diskId.
        /// </summary>
        /// <param name="diskId"></param>
        /// <returns></returns>
        public string GetDiskSerialNumber(string diskId)
        {
            Command command = new Command()
            {
                Name = "aaj"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets a list of disk partitions by the diskId.
        /// </summary>
        /// <param name="driveId"></param>
        /// <returns></returns>
        public List<string> GetDiskPartitions(string driveId)
        {
            Command command = new Command()
            {
                Name = "aak"
            };
            ConnectionServer.Commands.Add(command);
            return null;
        }
        /// <summary>
        /// Gets the manufacture of the remote device.
        /// </summary>
        /// <returns></returns>
        public string GetDeviceManufacturer()
        {
            Command command = new Command()
            {
                Name = "aal"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the model number of the remote device.
        /// </summary>
        /// <returns></returns>
        public string GetDeviceModelNumber()
        {
            Command command = new Command()
            {
                Name = "aam"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the serial number of the remote device.
        /// </summary>
        /// <returns></returns>
        public string GetDeviceSerialNumber()
        {
            Command command = new Command()
            {
                Name = "aan"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the bios version of the remote machine. (If its a desktop OS)
        /// </summary>
        /// <returns></returns>
        public string GetBiosVersion()
        {
            Command command = new Command()
            {
                Name = "aao"
            };
            return "";
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Gets the Operating System of the current machine.
        /// </summary>
        /// <returns></returns>
        public string GetOperatingSystem()
        {
            Command command = new Command()
            {
                Name = "aap"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the current computer name of the remote machine.
        /// </summary>
        /// <returns></returns>
        public string GetComputerName()
        {
            Command command = new Command()
            {
                Name = "aaq"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the system up-time of the remote machine.
        /// </summary>
        /// <returns></returns>
        public DateTime GetUptime()
        {
            Command command = new Command()
            {
                Name = "aar"
            };
            ConnectionServer.Commands.Add(command);
            return new DateTime();
        }
        /// <summary>
        /// Gets the battery status (in percent) of the remote machine.
        /// </summary>
        /// <returns></returns>
        public int GetBatteryState()
        {
            Command command = new Command()
            {
                Name = "aas"
            };
            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Gets a list of the network adapters from the remote host.
        /// </summary>
        /// <returns></returns>
        public List<string> GetNetworkAdapters()
        {
            Command command = new Command()
            {
                Name = "aat"
            };
            ConnectionServer.Commands.Add(command);
            return null;
        }
        /// <summary>
        /// Gets the network adapter's name from the adapterId.
        /// </summary>
        /// <param name="adapterId"></param>
        /// <returns></returns>
        public string GetAdapterName(string adapterId)
        {
            Command command = new Command()
            {
                Name = "aau"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the network adapter's IPv4 address from the adapterId.
        /// </summary>
        /// <param name="adapterId"></param>
        /// <returns></returns>
        public string GetAdapterIPv4(string adapterId)
        {
            Command command = new Command()
            {
                Name = "aav"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the network adapter's subnet mask from the adapterId.
        /// </summary>
        /// <param name="adapterId"></param>
        /// <returns></returns>
        public string GetAdapterSubnetMask(string adapterId)
        {
            Command command = new Command()
            {
                Name = "aaw"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Gets the network adapter's IPv6 address from the adapterId.
        /// </summary>
        /// <param name="adapterId"></param>
        /// <returns></returns>
        public string GetAdapterIPv6(string adapterId)
        {
            Command command = new Command()
            {
                Name = "aax"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Clicks the remote machines mouse.
        /// </summary>
        /// <param name="point"></param>
        /// <param name="clickDirection"></param>
        public void ClickMouse(System.Windows.Point point, ClickDirection clickDirection)
        {
            var commandName = "";
            if (clickDirection == ClickDirection.Left)
                commandName = "aay";
            else
                commandName = "aaz";

            Command command = new Command()
            {
                Name = commandName,
                Parameters = new List<string>() { point.X.ToString(), point.Y.ToString() }
            };
            ConnectionServer.Commands.Add(command);
        }

        public void ClickMouse(ClickDirection clickDirection)
        {
            var commandName = "";
            if (clickDirection == ClickDirection.Left)
                commandName = "aay";
            else
                commandName = "aaz";

            Command command = new Command()
            {
                Name = commandName
            };
            ConnectionServer.Commands.Add(command);
        }
             
        /// <summary>
        /// Clicks the remote machines mouse.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="clickDirection"></param>
        public void ClickMouse(int x, int y, ClickDirection clickDirection)
        {
            var commandName = "";
            if (clickDirection == ClickDirection.Left)
                commandName = "aay";
            else
                commandName = "aaz";

            Command command = new Command()
            {
                Name = commandName,
                Parameters = new List<string>() { y.ToString(), y.ToString() }
            };
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Moves the remote machines mouse.
        /// </summary>
        /// <param name="point"></param>
        public void MoveMouse(System.Windows.Point point)
        {
            Command command = new Command()
            {
                Name = "aba",
                Parameters = new List<string>() { point.X.ToString(), point.Y.ToString() }
            };
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Moves the remote machines mouse.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MoveMouse(int x, int y)
        {
            Command command = new Command()
            {
                Name = "aba",
                Parameters = new List<string>() { x.ToString(), y.ToString() }
            };
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Starts a process on the remote machines.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public string StartProcess(string path, string parameters = "")
        {
            Command command = new Command()
            {
                Name = "abb"
            };
            ConnectionServer.Commands.Add(command);
            return "";
        }
        /// <summary>
        /// Type characters on the remote machine from a <see cref="String"/>.
        /// </summary>
        /// <param name="characterString"></param>
        public void TypeCharacters(string characterString)
        {

        }
        /// <summary>
        /// Type characters on the remote machine from a <see cref="Char[]"/>.
        /// </summary>
        /// <param name="characters"></param>
        public void TypeCharacters(char[] characters)
        {

        }
        /// <summary>
        /// Type a character on the remote machine from a <see cref="Char"/>.
        /// </summary>
        /// <param name="character"></param>
        public void TypeCharacters(char character)
        {

        }
        /// <summary>
        /// Logs out the current user of the remote machine.
        /// </summary>
        public void Logout()
        {
            Command command = new Command()
            {
                Name = "abd"
            };
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Shuts down the remote machine.
        /// </summary>
        public void Shutdown()
        {
            Command command = new Command()
            {
                Name = "abe"
            };
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Restarts the remote machine.
        /// </summary>
        public void Restart()
        {
            Command command = new Command()
            {
                Name = "abf"
            };
            ConnectionServer.Commands.Add(command);
        }
        /// <summary>
        /// Gets the volume level from the remote machine
        /// </summary>
        /// <returns>The current volume level</returns>
        public int GetVolume()
        {
            Command command = new Command
            {
                Name = "abg"
            };

            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Adjusts the volume of the remote machine's speakers to an accuracy of 1 volume level.
        /// </summary>
        /// <returns>The adjusted volume level.</returns>
        public int ChangeVolume(int newVolume)
        {
            Command command = new Command
            {
                Name = "abh",
                Parameters = new List<string>() { newVolume.ToString() }
            };

            ConnectionServer.Commands.Add(command);
            return 0;
        }
        /// <summary>
        /// Opens Task Manager on the remote machine.
        /// </summary>
        public void OpenTaskManager()
        {
            StartProcess(@"C:\Windows\SysWOW64\Taskmgr.exe");
        }
        
        /// <summary>
        /// Opens the specified web browser on the local machine - url is optional.
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="url"></param>
        public void OpenWebBrowser(Browsers browser, string url = "")
        {
            if (browser == Browsers.GoogleChrome)
            {
                StartProcess("google", url);
            }
            else if (browser == Browsers.Firefox)
            {
                StartProcess("firefox", url);
            }
            else if (browser == Browsers.InternetExplorer)
            {
                StartProcess("iexplore", url);
            }
            else if (browser == Browsers.Opera)
            {
                StartProcess(@"C:\Program Files\Opera\opera.exe", url);
            }
            else if (browser == Browsers.DefaultBrowser)
            {
                StartProcess(url);
            }
        }
    }
}
