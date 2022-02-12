using System;
using System.Windows;
using System.Net.Mail;
using Npgsql;
using System.Xml;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AE.Net.Mail;
using System.Diagnostics;

namespace Daquest
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
        public string[] cardinalNums = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};
        public string[] ordinalNums = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "13", "14", "15", "16", "17", "18", "19", "20" };
        public string[] fruit = { "Red Apple", "Green Apple", "Apricot", "Banana", "Blackberries", "Sweet Blueberries", "Tart Blueberries", "Cantaloupe", "Red Cherry", "Black Cherries", "Yellow Cherries", "Coconut", "Coffee", "Date", "Fig", "Red Grape", "White Grape", "Grapefruit", "Gooseberries", "Honeydew", "Kiwi", "Lemon", "Lime", "Loquat", "Nutmeg", "Peach", "Peanut", "Pineapple", "Pumpkin", "Paspberry", "Strawberry", "Watermelon", "Vegetables", "lettuce", "carrots", "turnip", "radish" };
        public string[] bibleNew = { "Matthew", "Mark", "Luke", "John", "Acs", "Romans", "Corinthians", "Galatians", "Ephesians", "Philippians", "Colossions", "Thessalonians", "Timothy", "titus", "Philemon", "Hebrews", "James", "Peter", "John" ,"Jude", "Revelations"};
        public string[] bibleOld = { "Genesis", "Exodus", "Liviticus", "Numbers", "Deuteronomy", "Joshua", "Judjges", "Ruth", "Samuel", "Kings", "Chronicles", "Ezra" ,"Nehemiah", "Eather", "Job",  "Psalms", "Proverbs", "Ecclesiastes", "Solomon", "Isaiah", "Jeremiah", "Ezekiel", "Daniel", "Hosea", "Joel" ,"Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi"};
        public string[] outgoingInfo = { "", "", "", ""};
        public string [] incomingInfo = { "", "", "", ""};
        public string sender = "7178215700@txt.att.net";
        //mailAddress smtp passwords ports
        public void write(string text){
            DateTime dt = new DateTime(2017, 6, 30, 2, 13, 30);
            output.Text += text + ": " + dt + "\n";
        }
        public void send(string mailMessage)
        {
            try {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient SmtpServer = new SmtpClient(outgoingInfo[1]);
                mail.From = new MailAddress(outgoingInfo[0]);
                mail.To.Add(sender);
                mail.Body = mailMessage;
                SmtpServer.Port = Convert.ToInt16(outgoingInfo[2]);
                SmtpServer.Credentials = new System.Net.NetworkCredential(outgoingInfo[0], outgoingInfo[3]);
                // SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            } catch (Exception ex) {
                if (Debugger.IsAttached)
                    throw ex;
                else
                {
                    while (ex.InnerException != null)
                    {
                        ex = ex.InnerException;
                    }
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void process(string text)
        {
            text.ToLower();
            if (text.IndexOf("what") != -1)
            {
                people(text);
            }
            else if (text.IndexOf("phone") != -1)
            {
                people(text);
            }
            else if (text.IndexOf("address") != -1)
            {
                people(text);
            }
            //foreach (var item in fruit)
            //{
            //    if (text.IndexOf(item) != -1)
            //    {
            //        fruitLookup(item);
            //    }
            //}

            if(text.IndexOf("weather") != -1)
            {
                var regExp = @"(?<=[in, at]\s)(\w+)";
                Match micah = Regex.Match(text, regExp);

               
                weather(micah.Groups[0].ToString());
            }

            if(text.IndexOf("look-up") != -1 || text.IndexOf("lookup") != -1 || text.IndexOf("look up") != -1 || text.IndexOf("search") != -1 || text.IndexOf("research") != -1)
            {
                if(text.IndexOf("dictionary") != -1)
                {
                    var me = @"(?<=[up, search, research]\s)(\w+)";
                    Match micah = Regex.Match(text, me);
                    WordLookup(micah.Value[0].ToString(), true);
                } if(text.IndexOf("thesaurus") != -1)
                {
                    var me = @"(?<=[up, search, research]\s)(\w+)";
                    Match micah = Regex.Match(text, me);
                    WordLookup(micah.Value[0].ToString(), false);
                }
            }
            foreach (var item in bibleNew)
            {
                if (text.IndexOf(item) != -1)
                {
                    var me = @"[abcdefghijklmnopqrstuvwxyz]+ \\d+:\\d+";
                    Match micah = Regex.Match(text, me);
                    bible(micah.Value[0].ToString());
                }
            }
        }
        public void people(string businessText)
        {
            var businessReg_ = @"(for|up|search) [abcdefghijklmnopqrstuvwxyz ]{4,}+";
            var businessReg = $"\\w+";
            var whereReg_ = @"(in|to) \\b\\w+\\b";
            var whereReg = $"\\w+";
            Match business_ = Regex.Match(businessText, businessReg_);
            Match business = Regex.Match(business_.ToString(), businessReg);
            Match where_ = Regex.Match(businessText, whereReg_);
            Match where = Regex.Match(where_.ToString(), whereReg);

            WebClient yp = new WebClient();
            string businessString = yp.DownloadString("http://api.yellowapi.com/FindBusiness/?what=" + business.ToString() + "&where=" + where.ToString() + "&UID=127.0.0.1&apikey=" + businessKey.Text);
            dynamic businessObject = JObject.Parse(businessString);

            WebClient ypDetail = new WebClient();
            string businessStringDetails = yp.DownloadString("http://api.yellowapi.com/GetBusinessDetails/?prov=US&city=" + where.ToString() + "&bus-name=" + business.ToString() + "&fmt=JSON&apikey=" + businessKey.Text);
            dynamic businessObjectDetails = JObject.Parse(businessStringDetails);
            send("Adress: " + businessObject.listings.address.street + "PostalCode: " + businessObject.listings.address.pcode + "Phone(s): " + businessObjectDetails.phones.ToString() + " Web Site: " + businessObjectDetails.products.webUrl.ToString());
        }
        public void bible(string verse) { 
            var bookReg = @"[ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz]+";
            Match book = Regex.Match(verse, bookReg); //get the book
            var chapterReg = @"[ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+] \\d+"; //get the book and chapter
            Match chapterUm = Regex.Match(verse, chapterReg);
            var chapter2Reg = "\\d+";
            Match chapter = Regex.Match(chapterUm.ToString(), chapter2Reg); //get the final chapter
            var verseReg = ":\\d+"; //get the partial verse num
            Match verseUm = Regex.Match(verse, verseReg);
            var verseReg2 = "\\d+";//get the final verse
           Match verseFinal = Regex.Match(verse.ToString(), verseReg2);

            WebClient c = new WebClient();
            var data = c.DownloadString("http://getbible.net/json?scrip=" + book + " " + chapter + ":" + verseFinal);
            int count = 0;
            do
            {
                data.Replace(ordinalNums[count], cardinalNums[count]);
                count++;
            } while (count < 21);
            dynamic stuff = JObject.Parse(data);
            var referance = stuff.book.chapter.verse.four;
        }
        public void WordLookup(string word, bool dict)
        {
            string APIKEYT = thesarusKey.Text;
            string APIKEYD = dictKey.Text;
            if(dict)
            {
                XmlDocument xmlDocument = new XmlDocument();
                string CurrentURL = "http://www.dictionaryapi.com/api/v1/references/collegiate/xml/"
                   + word + "?key=[" + APIKEYD + "]";
                using (WebClient client = new WebClient())
                {
                    var xmlContent = client.DownloadString(CurrentURL);
                    xmlDocument.LoadXml(xmlContent);
                }
                XmlNode pro_ = xmlDocument.SelectSingleNode("//entry/pr/text()"); //pro
                XmlNode lang_ = xmlDocument.SelectSingleNode("//entry/fl/text()"); //language part
                XmlNode exp_ = xmlDocument.SelectSingleNode("//entry/dt/text()"); //explanation
                string tempstring = pro_.Value + ", " + lang_.Value + ", " + exp_.Value;
                send(float.Parse(tempstring).ToString());
            } else
            {
                XmlDocument xmlDocument = new XmlDocument();
                string CurrentURL = "http://www.dictionaryapi.com/api/v1/references/thesaurus/xml/"
                   + word + "?key=[" + APIKEYT + "]";
                using (WebClient client = new WebClient())
                {
                    var xmlContent = client.DownloadString(CurrentURL);
                    xmlDocument.LoadXml(xmlContent);
                }
                XmlNode fl_ = xmlDocument.SelectSingleNode("//entry/fl/text()"); //language part
                XmlNode syn_ = xmlDocument.SelectSingleNode("//entry/sens/syn/text()"); //synonymes
                XmlNode rel_ = xmlDocument.SelectSingleNode("//entry/sens/rel/text()"); //related phrases
                string tempstring = fl_.Value + ", " + syn_.Value + ", related: " + rel_.Value;
                send(float.Parse(tempstring).ToString());
            }
        }
        public void weather(string location)
        {
            XmlDocument xmlDocument = new XmlDocument();
            string APIKEY = API.Text;
        string CurrentURL = "http://api.openweathermap.org/data/2.5/weather?q="
            + location + "&mode=xml&units=Imperial&APPID=" + APIKEY;
            using (WebClient client = new WebClient())
            {
                var xmlContent = client.DownloadString(CurrentURL);
                xmlDocument.LoadXml(xmlContent);
         }
            XmlNode tempn = xmlDocument.SelectSingleNode("//temperature");
            System.Xml.XmlAttribute tempv = tempn.Attributes["value"];
            string tempstring = tempv.Value;
            send(float.Parse(tempstring).ToString());
        }
        private void fruitLookup(string text)
        {
            {
                using (var con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=IGuessItems;User Id=postgres;Password=pass4;"))
                {
                    con.Open();
                    using (var cmd = new NpgsqlCommand("SELECT * FROM public.names WHERE name LIKE '%" + text + "'", con))
                    {
                        cmd.Parameters.AddWithValue("@RogersFirstParamter", 0);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                send("Its color is " + reader.GetString(1) + ". It's it's mostly " + reader.GetString(2) + " and feels " + reader.GetString(3) + ". It tastes pretty " + reader.GetString(4) + " and it's " + reader.GetString(5) + " inside.");
                            }
                        }
                    }
                }
            }
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            incomingInfo[0] = userName.Text + "@" + server.Text;
            incomingInfo[1] = comboBox_Copy.Text + "." + server.Text;
            incomingInfo[3] = password.Password.ToString();
            incomingInfo[2] = portNum.Text;
            outgoingInfo[0] = userName_Copy.Text + "@" + server.Text;
            outgoingInfo[1] = comboBox_Copy1.Text + "." + server.Text;
            outgoingInfo[3] = password_Copy1.Password.ToString();
            outgoingInfo[2] = portNum_Copy.Text;
    }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                SmtpClient SmtpServer = new SmtpClient(outgoingInfo[1]);
                mail.From = new MailAddress(outgoingInfo[0]);
                mail.To.Add(smsTo.Text + "@" + smsService.Text);
                mail.Body = smsMessage.Text;
                SmtpServer.Port = Convert.ToInt16(outgoingInfo[2]);
                SmtpServer.Credentials = new System.Net.NetworkCredential(outgoingInfo[0], outgoingInfo[3]);
                SmtpServer.EnableSsl = false;
                SmtpServer.Send(mail);
            }
            catch
            { write("Could not reply to sender "); }
        }
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            //using (ImapClient ic = new ImapClient(incomingInfo[1], incomingInfo[0], incomingInfo[2], AuthMethods.Login, 587))
            //{
            //    ic.SelectMailbox("INBOX");
            //    AE.Net.Mail.MailMessage mm = ic.GetMessage(0);
            //    process(mm.Body);
            //}
            process("Whats the weather in Myerstown");
        }
    }
}
