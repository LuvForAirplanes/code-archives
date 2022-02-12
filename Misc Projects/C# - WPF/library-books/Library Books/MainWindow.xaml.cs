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

namespace Library_Books
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
            using (var con = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=Library Books;User Id=postgres;Password=pass4;"))
            {
                con.Open();
                using (var cmd = new NpgsqlCommand("Select * FROM Books WHERE Id=@RogersFirstParamter", con))
                {
                    cmd.Parameters.AddWithValue("@RogersFirstParamter", Convert.ToInt64(myText.Text));
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show(reader.GetString(1));
                        }
                    }
                }
            }
		}
	}
}
