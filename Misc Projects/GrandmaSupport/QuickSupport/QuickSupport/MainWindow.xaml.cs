using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuickSupport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static object EnviromentManagement { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        
        public void WriteOutput(string text, bool overwrite = true)
        {
            if(overwrite)
            {
                output.Text = text;
            } else
            {
                output.Text = output.Text + " " + text;
            }
        }

        private void otherBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WriteOutput("OK, were sending him a notification...");
            SendSMS("Grandma Stauffer needs help with her computer.");
        }

        private void errorBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WriteOutput("OK, were sending him a notification...");
            SendSMS("Grandma Stauffer is having an error box appear on her screen and needs help.");
        }

        private void pictureBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WriteOutput("OK, were sending him a notification...");
            SendSMS("Grandma Stauffer needs help with her pictures.");
        }

        public void SendSMS(string errorMsg)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("micanetproject@gmail.com");
                msg.To.Add("micah@abcrun.com");
                msg.To.Add("7173449250@txt.att.net");
                msg.Subject = "";
                msg.Body = errorMsg;
                SmtpClient client = new SmtpClient();
                client.UseDefaultCredentials = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new NetworkCredential("micanetproject@gmail.com", "micanet@gmail");
                client.Timeout = 20000;
                client.Send(msg);
                Thread.Sleep(2000);
                WriteOutput("OK, it went. He will be with you shortly.", true);
            } catch
            {
                WriteOutput("An error occured while we were asking Micah's help.");
            }
        }

        private void output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
