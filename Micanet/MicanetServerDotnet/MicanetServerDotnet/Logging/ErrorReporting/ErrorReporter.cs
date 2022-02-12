using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Timers;
using System.Xml;

namespace MicanetServerDotnet
{
    class ErrorReporter
    {
        public static string sentFrom = "";
        public static List<string> contacts = new List<string>();

        public static string SendSMS(string errorMsg)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("micanetproject@gmail.com");
            foreach (var contact in contacts)
            {
                msg.To.Add(contact);
            }
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

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 60000;
            aTimer.Start();

            return "";
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Mail2();
        }

        private static void Mail2()
        {
            var client = new ImapX.ImapClient("imap.gmail.com", 993, true);
            client.Connect();
            client.Login("micanetproject@gmail.com", "micanet@gmail");
            var messages = client.Folders["INBOX"].Search("ALL");
            string msg = messages[0].Body.Text;
            if (msg.IndexOf("stop") != -1)
            {
                messages[0].Remove();
                EnviromentManagement.Controls.Stop();
            } else if(msg.IndexOf("restart") != -1) {
                EnviromentManagement.Controls.Restart();
            }
        }
    }
}
