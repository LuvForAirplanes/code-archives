using MailKit;
using MailKit.Net.Imap;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MicanetMessageServiceDotnetCore.Email
{
    class MonitorEmail
    {
        public static string from = "";
        public static void GetEmail2()
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 993, true);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate("micanetmessageservice@gmail.com", "mms@gmail");
                
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ContentHandler.ContentHandler.HandleContent(message.GetTextBody(MimeKit.Text.TextFormat.Text), message.Sender.Address);
                }
                client.Disconnect(true);
            }
        }

        public static int scoreKeeper = 0;

        public static void GetEmail()
        {
            using (var client = new MailKit.Net.Pop3.Pop3Client())
            {
                try
                {
                    // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect("pop.gmail.com", 995, true);

                    // Note: since we don't have an OAuth2 token, disable
                    // the XOAUTH2 authentication mechanism.
                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    client.Authenticate("micanetmessageservice@gmail.com", "mms@gmail");
                } catch
                {
                    if(scoreKeeper < 25)
                    {
                        scoreKeeper = scoreKeeper++;
                    } else if(scoreKeeper > 26)
                    {
                        Environment.Exit(0);
                    }
                }
                try
                {
                    for (int i = 0; i < client.Count; i++)
                    {
                        var message = client.GetMessage(i);
                        ContentHandler.ContentHandler.HandleContent(message.TextBody, message.Sender.ToString());
                    }
                } catch
                {

                }
                client.Disconnect(true);
            }
        }
    }
}
