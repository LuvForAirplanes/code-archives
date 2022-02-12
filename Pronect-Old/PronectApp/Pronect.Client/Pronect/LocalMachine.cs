using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Interop;

namespace Pronect
{
    public class LocalMachine : Window
    {
        /// <summary>
        /// Adjusts the local computer's system volume to the specified integer to an accuracy of 1 volume level.
        /// </summary>
        /// <param name = "newVolume" ></ param >
        /// < returns > Returns the adjusted volume.</returns>
        public int ChangeVolume(int newVolume)
        {
            int currentVolume = GetMasterVolume();
            if (currentVolume == newVolume)
            {
                return GetMasterVolume();
            }
            else if (newVolume > currentVolume)
            {
                int diff = newVolume - currentVolume;
                do
                {
                    SendMessageW(new WindowInteropHelper(this).Handle, WM_APPCOMMAND, new WindowInteropHelper(this).Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
                    diff = diff - 2;
                } while (diff > 1);
                return GetMasterVolume();
            }
            else if (currentVolume > newVolume)
            {
                int diff = currentVolume - newVolume;
                do
                {
                    SendMessageW(new WindowInteropHelper(this).Handle, WM_APPCOMMAND, new WindowInteropHelper(this).Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
                    diff = diff - 2;
                } while (diff > 1);
                return GetMasterVolume();
            }
            else if (newVolume == 0)
            {
                SendMessageW(new WindowInteropHelper(this).Handle, WM_APPCOMMAND, new WindowInteropHelper(this).Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
                return GetMasterVolume();
            }
            return GetMasterVolume();
        }
        /// <summary>
        /// Gets the master volume of the local machine's audio system.
        /// </summary>
        /// <returns></returns>
        public int GetMasterVolume()
        {
            // get the speakers (1st render + multimedia) device
            IMMDeviceEnumerator deviceEnumerator = (IMMDeviceEnumerator)(new MMDeviceEnumerator());
            const int eRender = 0;
            const int eMultimedia = 1;
            deviceEnumerator.GetDefaultAudioEndpoint(eRender, eMultimedia, out IMMDevice speakers);

            speakers.Activate(typeof(IAudioEndpointVolume).GUID, 0, IntPtr.Zero, out object o);
            IAudioEndpointVolume aepv = (IAudioEndpointVolume)o;
            float volume = aepv.GetMasterVolumeLevelScalar();
            Marshal.ReleaseComObject(aepv);
            Marshal.ReleaseComObject(speakers);
            Marshal.ReleaseComObject(deviceEnumerator);
            string stringifiedVolume = volume.ToString();
            if (stringifiedVolume.Length == 3)
            {
                stringifiedVolume = stringifiedVolume + "0";
            }
            return Int32.Parse(stringifiedVolume.Replace(".", ""));
        }

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        
        [ComImport]
        [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
        private class MMDeviceEnumerator
        {
        }
        [Guid("5CDF2C82-841E-4546-9722-0CF74078229A"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IAudioEndpointVolume
        {
            void _VtblGap1_6();
            float GetMasterVolumeLevelScalar();
        }
        [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IMMDeviceEnumerator
        {
            void _VtblGap1_1();

            [PreserveSig]
            int GetDefaultAudioEndpoint(int dataFlow, int role, out IMMDevice ppDevice);
        }
        [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        private interface IMMDevice
        {
            [PreserveSig]
            int Activate([MarshalAs(UnmanagedType.LPStruct)] Guid iid, int dwClsCtx, IntPtr pActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object ppInterface);
        }

        private string HKLM_GetString(string path, string key)
        {
            try
            {
                RegistryKey rk = Registry.LocalMachine.OpenSubKey(path);
                if (rk == null) return "";
                return (string)rk.GetValue(key);
            }
            catch { return ""; }
        }
        /// <summary>
        /// Gets the friendly operating system name of the local machine.
        /// </summary>
        /// <returns></returns>
        public string GetOsFriendlyName()
        {
            try
            {
                string ProductName = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
                string CSDVersion = HKLM_GetString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion");
                if (ProductName != "")
                {
                    return (ProductName.StartsWith("Microsoft") ? "" : "Microsoft ") + ProductName +
                                (CSDVersion != "" ? " " + CSDVersion : "");
                }
            }
            catch
            {

            }
            return "";
        }
        /// <summary>
        /// Gets the friendly name of the local computers Operating System.
        /// </summary>
        /// <returns></returns>
        public string GetOsVersion()
        {
            return Environment.OSVersion.Version.ToString();
        }
        /// <summary>
        /// Gets the friendly string of information about the processor.
        /// </summary>
        /// <returns>string</returns>
        public string GetProcessorFriendlyInfo()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                return mo["Name"].ToString();
            }
            return "";
        }
        /// <summary>
        /// Gets the processors manfacturers name from the local machine.
        /// </summary>
        /// <returns>string</returns>
        public string GetProcessorManufacturer()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (ManagementObject mo in mos.Get())
            {
                return mo["Manufacturer"].ToString();
            }
            return "";
        }
        /// <summary>
        /// Gets the name of the CPU core, e.g. i7, Pentium, Celeron (from the local machine)
        /// </summary>
        /// <returns>string</returns>
        public string GetCoreName()
        {
            Match coreNameMatch = Regex.Match(GetProcessorFriendlyInfo(), @"(?<=Core\(TM\) )(\w)+-?(\w)+");
            return coreNameMatch.Value;
        }
        /// <summary>
        /// Gets the max speed of the processor from the local machine.
        /// </summary>
        /// <returns>string</returns>
        public string GetCoreSpeed()
        {
            Match processorSpeed = Regex.Match(GetProcessorFriendlyInfo(), @"(?<=\@ )(\w)+.(\w)+");
            return processorSpeed.Value;
        }
        /// <summary>
        /// Retrieves the local computers current CPU speed.
        /// </summary>
        /// <returns></returns>
        public string GetCurrentCpuSpeed()
        {
            ManagementObject Mo = new ManagementObject("Win32_Processor.DeviceID='CPU0'");
            uint sp = (uint)(Mo["CurrentClockSpeed"]);
            Mo.Dispose();
            return sp.ToString();
        }
        /// <summary>
        /// Returns the local machines total physical RAM
        /// </summary>
        /// <returns></returns>
        public string GetTotalRam()
        {
            var nu = new Microsoft.VisualBasic.Devices.ComputerInfo();
            return nu.TotalPhysicalMemory.ToString();
        }

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void Mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        /// <summary>
        /// Click the local machine's mouse.
        /// </summary>
        public void ClickMouse()
        {
            Mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        /// <summary>
        /// Moves the local machines mouse to the specified position then clicks it.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void ClickMouse(int x, int y)
        {
            SetCursorPos(x, y);
            Mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            Mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
        /// <summary>
        /// Move the local machines mouse to the specified position.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MoveMouse(int x, int y)
        {
            SetCursorPos(x, y);
        }
        /// <summary>
        /// Shutdown the local computer.
        /// </summary>
        public void ShutdownComputer()
        {
            Process.Start("shutdown", "/s /t 0");
        }
        /// <summary>
        /// Restart the local computer.
        /// </summary>
        public void RestartComputer()
        {
            Process.Start("shutdown", "/g");
        }
        /// <summary>
        /// Logout of the local computer.
        /// </summary>
        public void LogoutComputer()
        {
            Process.Start("shutdown", "/l");
        }
        /// <summary>
        /// Sends a command to Command Prompt on the local machine.
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public string SendToCommandLine(string command)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c " + command;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string myString = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return myString;
        }
        /// <summary>
        /// Opens a file, application, or directory on the local machine.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="parameters"></param>
        public string OpenFileOrDirectory(string path, string parameters)
        {
            Process p = new Process();
            p.StartInfo.FileName = path;
            p.StartInfo.Arguments = parameters;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            string returnText = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return returnText;
        }
        public enum Browsers
        {
            GoogleChrome,
            InternetExplorer,
            Firefox,
            DefaultBrowser
        }
        /// <summary>
        /// Opens the specified web browser on the local machine - url is optional.
        /// </summary>
        /// <param name="browser"></param>
        /// <param name="url"></param>
        public void OpenWebBrowser(Browsers browser, string url = "")
        {
            if (url == "")
            {
                if (browser == Browsers.GoogleChrome)
                {
                    Process.Start("chrome");
                }
                else if (browser == Browsers.Firefox)
                {
                    Process.Start("firefox");
                }
                else if (browser == Browsers.InternetExplorer)
                {
                    Process.Start("iexplore");
                }
                else if (browser == Browsers.DefaultBrowser)
                {
                    Process.Start("http://bing.com/");
                }
            }
            else
            {
                if (browser == Browsers.GoogleChrome)
                {
                    Process.Start("chrome", url);
                }
                else if (browser == Browsers.Firefox)
                {
                    Process.Start("firefox", url);
                }
                else if (browser == Browsers.InternetExplorer)
                {
                    Process.Start("iexplore", url);
                }
                else if (browser == Browsers.DefaultBrowser)
                {
                    Process.Start(url);
                }
            }
        }
    }
}
