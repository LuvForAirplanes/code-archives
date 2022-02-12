using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
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
using System.Security.Cryptography;
using System.IO;
using System.Net;
using mshtml;
using System.Text.RegularExpressions;

namespace Micanet_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedCommand MyCommand = new RoutedCommand();
        private string ip = "192.168.1.3";
        string language = "en-us";

        private void MyCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            
        }

        public MainWindow()
        {
            InitializeComponent();
            MyCommand.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
        }

        int currentLocation = -1;
        List<BreadCrumbs> history = new List<BreadCrumbs>();

        System.Windows.Forms.WebBrowser browser = new System.Windows.Forms.WebBrowser();

        public void write(String message)
        {
            // Create the browser
            //component in XML
            var host = WindowsFormsHoster;
            // Assign the Browser control as the host control's child.
            host.Child = browser;
            //decrypt string
            //browser.DocumentText = DecryptString(message);
            browser.DocumentText = message;
        }
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
        public void Connect(String message)
        {
            try
            {
                // Create a TcpClient.
                // Note, for this client to work you need to have a TcpServer 
                // connected to the same address as specified by the server, port
                // combination.
                Int32 port = 56372;
                TcpClient client = new TcpClient(ip, port);
                //encrypt string
                //message = EncryptString(message);
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                // Get a client stream for reading and writing.
                //  Stream stream = client.GetStream();
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer. 
                stream.Write(data, 0, data.Length);

                Console.WriteLine("Sent: {0}", message);

                // Receive the TcpServer.response.
                // Buffer to store the response bytes.
                data = new Byte[1024];

                // String to store the response ASCII representation.
                String responseData = String.Empty;

                // Read the first batch of the TcpServer response bytes.
                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                if(responseData == "404")
                {
                    write(GetLocalContent(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\pages\notfound.html"));
                } else
                {
                    Console.WriteLine("Received: {0}", responseData);
                    write(responseData);
                }
                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}" + e);
                write(GetLocalContent(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\pages\comerror.html"));
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}" + e);
                write(GetLocalContent(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\pages\comerror.html"));
            }
            Console.WriteLine("\n Press Enter to continue...");
            Console.Read();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSettings();
            go("micanet.mn/home", "GET", language);
            address.Text = "micanet.mn/home";
        }

        public string getLocalIP()
        {
            try
            {
                string hostNameOrAddress = Dns.GetHostName();
                var hostEntry = Dns.GetHostEntry(hostNameOrAddress);
                foreach (System.Net.IPAddress ip in hostEntry.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork) //get the first IP V4 address
                        return ip.ToString();
                }
                return "";
            }
            catch { }
            return "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            go(address.Text, "GET", language);
        }

        private void go(string url, string method, string lang)
        {
            Connect("{ \"address\": \"" + url + "\", \"method\": \"" + method + "\", \"lang\": \"" + lang + "\" }");
            address.Text = url;
            var crumb = new BreadCrumbs(address.Text, 0);
            if (currentLocation != -1)
            {
                history.Insert(currentLocation, crumb);
            }
            currentLocation = currentLocation + 1;
        }

        

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application curApp = System.Windows.Application.Current;
            curApp.Shutdown();
        }

        private void WindowsFormsHoster_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            //nav back
            currentLocation = currentLocation - 1;
            if (currentLocation != -1)
            {
                address.Text = history[currentLocation].Url;
                Connect(address.Text);
            }
            else
            {
                back.IsEnabled = false;
            }
        }

        private void front_Click(object sender, RoutedEventArgs e)
        {
            //nav front
            currentLocation = currentLocation + 1;
            address.Text = history[currentLocation].Url;
            Connect(address.Text);
            if (currentLocation == history.Count)
            {
                front.IsEnabled = false;
            }
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void address_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                WindowsFormsHoster.Focus();
                go(address.Text, "GET", language);
            }
        }

        private void LoadSettings()
        {
            using (StreamReader sr = File.OpenText(@"C:\Program Files (x86)\Micanet\MicanetBrowser\0.0.0.5\settings.json"))
            {
                string data = "";
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                        data += s.Trim();
                }

                var regExpForSettings = "(?<=\"ip\": \")[^\"]((\\d)||(\\w)).[^\"]+";
                Match matchesForType = Regex.Match(data, regExpForSettings);
                ip = matchesForType.Groups[0].ToString();
            }
        }

        private void printMenuButton_Click(object sender, RoutedEventArgs e)
        {
           mshtml.IHTMLDocument2 doc = browser.Document.DomDocument as mshtml.IHTMLDocument2;
            doc.execCommand("Print", true, null);
        }

        private void saveAsMenuButton_Click(object sender, RoutedEventArgs e)
        {
            browser.ShowSaveAsDialog();
        }

        private void findMenuButton_Click(object sender, RoutedEventArgs e)
        {
            var boolean = FindFirst("Micanet");
        }

        private string GetSelection()
        {
            IHTMLDocument2 doc = (IHTMLDocument2)browser.Document.DomDocument;
            IHTMLSelectionObject sel = doc.selection;
            IHTMLTxtRange range = (IHTMLTxtRange)sel.createRange();
            return range.text;
        }
        private bool FindFirst(string text)
        {
            IHTMLDocument2 doc = (IHTMLDocument2)browser.Document.DomDocument;
            IHTMLSelectionObject sel = (IHTMLSelectionObject)doc.selection;
            sel.empty(); // get an empty selection, so we start from the beginning
            IHTMLTxtRange rng = (IHTMLTxtRange)sel.createRange();
            if (rng.findText(text, 1000000000, 0))
            {
                rng.select();
                return true;
            }

            return false;
        }
        private bool FindNext(string text)
        {
            IHTMLDocument2 doc = (IHTMLDocument2)browser.Document.DomDocument;
            IHTMLSelectionObject sel = (IHTMLSelectionObject)doc.selection;
            IHTMLTxtRange rng = (IHTMLTxtRange)sel.createRange();
            rng.collapse(false); // collapse the current selection so we start from the end of the previous range
            if (rng.findText(text, 1000000000, 0))
            {
                rng.select();
                return true;
            }

            return false;
        }

        private void helpMenuButton_Click(object sender, RoutedEventArgs e)
        {
            go("micanet.mn/help", "GET", language);
        }
    }

    class BreadCrumbs
    {
        public BreadCrumbs(string url, int tab)
        {
            Url = url;
            Tab = tab;
        }
        public string Url { get; set; }
        public int Tab { get; set; }
    }
}
