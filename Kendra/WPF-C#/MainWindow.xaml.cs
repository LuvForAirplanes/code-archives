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
using Npgsql;

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
        public string[] words = { };
        public string[] synonyms = { };
        public string[] def = { };

        public string[] nodeArray = { "1 2 3", "3" };
        public int[] processItems =  { 0 };
        public int[] valueArray = { 200 };
        public int[] newProcessItems = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public int[] newValueArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public void outText(int index)
        {
            MessageBox.Show(index.ToString());
        }

        public void loadData()
        {
            var command = "";
            using (var con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Kendra;User Id=postgres;Password=pass4;"))
            {
                con.Open();
                try
                {
                    using (var cmd = new NpgsqlCommand(command, con))
                    {
                        cmd.Parameters.AddWithValue("@RogersFirstParamter", Convert.ToInt64(1));
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < 50000; i++)
                                {
                                    reader.GetString(i);
                                }
                                
                            }
                        }
                    }
                }
                catch { }
                finally { }

            }
        }

        public void process()
        {
            var regExp = "(\\w)+";
            if (processItems.Length == 0)
            {

            }
            foreach (var loop in processItems)
            {
                int id = 0;
                string tempNode = nodeArray[id]; // "1 2 3"
                Match node2 = Regex.Match(tempNode, regExp); //"1", "2", "3"
                int[] node = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < node2.Length; i++)
                {
                    string a = node2.Value[i].ToString();
                    node[i] = Convert.ToInt16(a);
                }
                var value = valueArray[id] * 2;
                foreach (var doCount in node)
                {
                    value = value /*Math.Floor(value)*/ / 2;
                    if (value > 100)
                    {
                        value = value + 100;
                        if (node[0] == 1 && value > 100)
                        {
                            outText(1);
                        }
                        newProcessItems[doCount] = node[doCount];
                        newValueArray[doCount] = value;
                    }
                }
            }
            processItems = newProcessItems;
            valueArray = newValueArray;
            newProcessItems.SetValue( 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 );
            newValueArray.SetValue(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
            private void button_Click(object sender, RoutedEventArgs e)
            {
                MessageBox.Show("No settings are available yet!");
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

        private void form1_Loaded(object sender, RoutedEventArgs e)
        {
            //loadData();
        }
    }
    }
