using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Windows.Controls.Primitives;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.IO;

namespace Kendra_AI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void checkPort()
        {
            TcpClient tcpClient = new TcpClient("localhost", 587);

            //Connects fine
            NetworkStream ns = tcpClient.GetStream();
            StreamWriter sw = new StreamWriter(ns);

            //The code moves on but nothing seems to be sent unless I do
            //a sw.Close() after this line. That would however close the  
            //ns and prevent me from reading the response further down
            sw.Write("hello");

            //I am using a stream reader with ReadToEnd() on the tcpListener
            //which never receives the string from this piece of code

            //Since the above never actually send I get stuck here
            string response = new StreamReader(ns).ReadToEnd();
            MessageBox.Show(response.ToString());
            sw.Close();
            tcpClient.Close();

        }
        public void messageWriter(string text)
        {
                message.Content = text;
        }
        public string username = "Micah";

        List<string> nodeArray = new List<string> { "1 2 3", "3" };
        List<int> processItems = new List<int> { 0 };
        List<int> valueArray = new List<int> { 200 };
        List<int> newProcessItems = new List<int> {  };
        List<int> newValueArray = new List<int> {  };

        public void outText(int index) {

        }
        public void process()
        {
            var regExp = "(\\w)+";
            if (processItems.Count == 0)
            {

            }
            foreach (var loop in processItems)
            {
                int id = 0;
                string tempNode = nodeArray[id]; // "1 2 3"
                Match node2 = Regex.Match(tempNode, regExp); //"1", "2", "3"
                List<int> node = new List<int> { };
                for (int i = 0; i < node2.Length; i++)
                {
                    string a = node2.Value[i].ToString();
                    node.Add(Convert.ToInt16(a));
                }
                double value = valueArray[id] * 2;
                foreach (var doCount in node)
                {
                    value = Math.Floor(value) / 2;
                    if (value > 100)
                    {
                        value = value + 100;
                        if (node[0] == 1 && value > 100)
                        {
                            outText(1);
                        }
                        newProcessItems.Add(node[doCount]);
                        newValueArray.Add(Convert.ToInt16(value));
                    }
                }
            }
            processItems = newProcessItems;
            valueArray = newValueArray;
            newProcessItems.Clear();
            newValueArray.Clear();
        }
            private void button_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("No settings \n are available yet!");
            }

            private void button1_Click(object sender, RoutedEventArgs e)
            {
                form1.Visibility = Visibility.Hidden;
            }

            private void Grid_MouseLeave(object sender, MouseEventArgs e)
            {

            }

            private void button1_Click_1(object sender, RoutedEventArgs e)
            {
                process();
            }

        private void windowload(object sender, RoutedEventArgs e)
        {
            checkPort();
            string path = @"C:\Users\" + username + @"\Desktop\text.txt";
            if(System.IO.File.Exists(path) == true)
            {
                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(path);
               string abc = objReader.ReadToEnd();
                nodeArray.Clear();
                texter.Text = abc;
                for (int i = 0; i < texter.LineCount; i++)
                {
                    nodeArray.Add(texter.GetLineText(i));
                }
                //List<string> reg = new List<string> { };
                //var regExp = @"\w+";
                //Match matches = Regex.Match(abc, regExp);
                //for (int i = 0; matches.Groups.Count < i;  i ++)
                //{
                //    reg.Add(matches.Groups[i].ToString());
                //}
                //string[,] switchArray = { 
                //    { "a", "d", "[", "o", "&", "*", "j", "h", "@", "t" },
                //    { "q", "A", "J", "^", "<", ",", "Z", "-", "%", "f"},
                //    {"c", "m", "l", "K", "L", "U", "V", "T", "S", "M" }
                //};
                //for (int i = 0; reg.Count < 9; i++)
                //{
                //    for (int ii = 0; ii < 9; ii++)
                //    {
                //        for (int iii = 0; iii < 9; iii++)
                //        {
                //            if(reg[i].IndexOf(switchArray[ii, iii]) != -1)
                //            {
                                   //Regex.Replace(reg[i], ii, switchArray[ii, iii);
                //            }
                //        }
                //    }
                //}
                objReader.Close();
                foreach (var item in nodeArray)
                {

                }
            } else
            {
              message.Content = "We could not find the \nKendra Data file. Would\nyou like a Kendra tech to\nassist you?";
                if (output.Text.ToLower().IndexOf("yes") != -1 || output.Text.ToLower().IndexOf("ok") != -1)
                {
                    
                }
            }
        }
    }
}
