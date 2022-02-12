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
using Npgsql;
using System.Collections.ObjectModel;

namespace Library_Books
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string ExteriorColor
        {
            get { return (string)GetValue(ExteriorColorProperty); }
            set { SetValue(ExteriorColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ExteriorColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ExteriorColorProperty =
            DependencyProperty.Register("ExteriorColor", typeof(string), typeof(MainWindow), new PropertyMetadata(0));




        public ObservableCollection<string> Colors
        {
            get { return (ObservableCollection<string>)GetValue(ColorsProperty); }
            set { SetValue(ColorsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Colors.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ColorsProperty =
            DependencyProperty.Register("Colors", typeof(ObservableCollection<string>), typeof(MainWindow), new PropertyMetadata(new ObservableCollection<string>()));



        public ObservableCollection<string> Outside
        {
            get { return (ObservableCollection<string>)GetValue(OutsideProperty); }
            set { SetValue(OutsideProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Outside.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OutsideProperty =
            DependencyProperty.Register("Outside", typeof(ObservableCollection<string>), typeof(MainWindow), new PropertyMetadata(0));



        public ObservableCollection<string> taste
        {
            get { return (ObservableCollection<string> )GetValue(tasteProperty); }
            set { SetValue(tasteProperty, value); }
        }

        // Using a DependencyProperty as the backing store for taste.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty tasteProperty =
            DependencyProperty.Register("taste", typeof(ObservableCollection<string> ), typeof(MainWindow), new PropertyMetadata(0));
        


        public ObservableCollection<string> inside
        {
            get { return (ObservableCollection<string>)GetValue(insideProperty); }
            set { SetValue(insideProperty, value); }
        }

        // Using a DependencyProperty as the backing store for inside.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty insideProperty =
            DependencyProperty.Register("inside", typeof(ObservableCollection<string>), typeof(MainWindow), new PropertyMetadata(0));




        public MainWindow()
        {
            InitializeComponent();
            Colors.Add("Red");
            Colors.Add("Orange");
            Colors.Add("Yellow");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("White");
            Colors.Add("Gray");
            Colors.Add("White");
        }
        public string command = "";
        private void write(string text)
        {
            if (text.IndexOf("LIKE") > 0)
            {
                command += text;
            }
            else
            {
                command += "'" + text + "'";
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            write("SELECT * FROM public.names WHERE color LIKE " + comboBox11.Text.ToLower() + " AND outside LIKE " + comboBox2.Text.ToLower() + " AND taste LIKE " + comboBox3.Text.ToLower() + " AND inside LIKE " + comboBox4.Text.ToLower());
            using (var con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=IGuessItems;User Id=postgres;Password=pass4;"))
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
                                var count = 0;
                                string[] alph1 = { "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
                                string[] alph2 = { "A", "E", "I", "O", "U" };
                                do
                                {
                                    try
                                    {
                                        count++;
                                    }
                                    catch
                                    {
                                        MessageBox.Show("That naughty server is being lazy today! He even  \n let me talk to him!", "Naughty Server", MessageBoxButton.OK, MessageBoxImage.Question);
                                    }
                                    if (reader.GetString(0).IndexOf(alph1[count]) == 0)
                                    {
                                        MessageBox.Show("It is a " + reader.GetString(0) + "!");
                                        count = 27;
                                    }
                                    if (count < 5)
                                    {
                                        if (reader.GetString(0).IndexOf(alph2[count]) == 0)
                                        {
                                            MessageBox.Show("It is a: " + reader.GetString(0) + "!");
                                            count = 27;
                                        }
                                    }
                                } while (count < 26);
                            }
                        }
                    }
                }
                catch { MessageBox.Show("Hmmm... I can't seem to tell what you are thinking of...", "Uh, oh!", MessageBoxButton.OK, MessageBoxImage.Question); }
            }
            command = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
