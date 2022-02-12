using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace MicanetBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConnectToDirectory("{ \"relays\": \"1\" }");
        }
        //   public static System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();
        System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();

        public static List<string> ips = new List<string>();
        public static List<int> ports = new List<int>();

        //public static string GetLocalContent(String address)
        public string GetLocalContent(string address)
        {
            string data = "";
            using (StreamReader sr = File.OpenText(address))
            {
                string s = "";
                int incrementer = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    if (incrementer == 0)
                    {
                        data = s;
                    }
                    else
                    {
                        data += s;
                    }
                    incrementer++;
                }
            }
            return data;
        }

        //public static void write(String message)
        public void write(String message)
        {
            var host = WindowsFormsHoster;
            host.Child = browser;
            browser.DocumentText = message;
        }

        public void Connect(String message)
        {
            try
            {
                TcpClient client = new TcpClient(ips[0], ports[0]);
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                
                NetworkStream stream = client.GetStream();
                
                stream.Write(data, 0, data.Length);

                data = new Byte[1024];
                
                String responseData = String.Empty;
                
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                if (responseData == "404")
                {
                    write("404 Not Found");
                    write(GetLocalContent(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\pages\notfound.html"));
                }
                else
                {
                    //write(Encryption.Decrypt(responseData, "pass"));
                    write(responseData);
                }
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e) { write(e.ToString()); }
            catch (SocketException e) { write(e.ToString()); }
        }

        public static void HandleDirectoryResponse(string data)
        {
            var matchesForIp = Regex.Matches(data, @"((\d)+\.){3}(\d)+");
            for (int index = 0; index < matchesForIp.Count; index++)
            {
                ips.Add(matchesForIp[index].ToString());
            }

            var matchesForPort = Regex.Matches(data, @"(?<=:)(\d)+");
            for (int index = 0; index < matchesForPort.Count; index++)
            {
                ports.Add(Int32.Parse(matchesForPort[index].ToString()));
            }
        }

        public void ConnectToDirectory(String message)
        {
            try
            {
                TcpClient client = new TcpClient("192.168.1.2", 56374);
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                data = new Byte[1024];

                String responseData = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                if (responseData == "404")
                {
                    write(GetLocalContent(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\pages\notfound.html"));
                }
                else
                {
                    HandleDirectoryResponse(responseData);
                }
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e) { write(e.ToString()); }
            catch (SocketException e) { write(e.ToString()); }
        }

        private void go(string url, string method, string lang)
        {
            Connect("{ \"address\": \"" + url + "\", \"method\": \"" + method + "\", \"lang\": \"" + lang + "\" }");
            address.Text = url;
        }

        private void address_keyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                WindowsFormsHoster.Focus();
                go(address.Text, "GET", "en-us");
            }
        }
    }
}
