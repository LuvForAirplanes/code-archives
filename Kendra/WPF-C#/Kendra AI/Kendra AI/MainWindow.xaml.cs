using System;
using System.Windows;
using System.Windows.Input;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kendra_AI
{   //Classified Information: For official use only!
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.Manual;
            this.Left = 48;
            this.Top = 240;
        }
<<<<<<< HEAD
        List<string> tabs = new List<string>();
=======

>>>>>>> bcd3ed9... initial commit of files
        List<string> browserHistory = new List<string>();
        public int currentLocation = 0;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            form1.Visibility = Visibility.Hidden;
        }


        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }

        private void notifyClick(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private System.Windows.Forms.NotifyIcon notify = null;
        private void form1_Loaded(object sender, RoutedEventArgs e)
        {
            notify = new System.Windows.Forms.NotifyIcon();
            notify.Click += new EventHandler(notifyClick);
            notify.Visible = true;
        }

        private void goClick(object sender, RoutedEventArgs e)
        {
            if(source.Text.IndexOf("http") == -1)
            {
                source.Text = "http://" + source.Text;
            }
            try
            {
                browser.Navigate(source.Text);
                browserHistory.Add(source.Text);
            }
            catch (UriFormatException)
            {
                browser.Navigate(@"C:\Kendra\Client\Exceptions\UriFormatException.html");
            }
            
        }

        private void frontNav(object sender, RoutedEventArgs e)
        {
            try
            {
                int clTemp = currentLocation;
                browser.Navigate(browserHistory[clTemp++]);
                currentLocation++;
            } catch (Exception){}
        }

        private void backNav(object sender, System.Windows.Controls.ContextMenuEventArgs e)
        {
            try
            {
                int clTemp = currentLocation;
                browser.Navigate(browserHistory[clTemp--]);
                currentLocation--;
            }
            catch (Exception) { }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            nmgh
=======

>>>>>>> bcd3ed9... initial commit of files
        }

        private void button7_Copy_Click(object sender, RoutedEventArgs e)
        {
            var request = WebRequest.Create("http://localhost:56909/api/Kendra/" + "a aa");
            var stream = request.GetResponse().GetResponseStream();
            using (var reader = new StreamReader(stream))
            {
                string text = reader.ReadToEnd();
                Regex.Replace(text, "\"", "");
                MessageBox.Show(text);
            }
        }
    }
}