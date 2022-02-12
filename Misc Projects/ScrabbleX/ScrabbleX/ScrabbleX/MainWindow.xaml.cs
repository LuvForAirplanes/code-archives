using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ScrabbleX
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

        private List<List<string>> dictionary = new List<List<string>>();
        private List<String> letters = new List<string>();

        private void process_Click(object sender, RoutedEventArgs e)
        {
            LoadLetters();
            ShowResults(Convert.ToInt32(length.Text));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowResults(int length)
        {
            for (int currentWordIndex = 0; currentWordIndex < dictionary.Count; currentWordIndex++)
            {
                List<string> tempDict = letters;
                for (int currentLetterIndex = 0; currentLetterIndex < dictionary[currentWordIndex].Count;  currentLetterIndex++)
                {
                    if(dictionary[currentWordIndex][currentLetterIndex] == "")
                    {

                    }
                }
            }
        }

        private void ScrabbleXLoaded(object sender, RoutedEventArgs e)
        {
            LoadDictionary();
        }

        private void LoadDictionary()
        {
            using (StreamReader sr = File.OpenText("C:/alpha-words.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    var matches = Regex.Matches(s, "\\w");
                    List<string> listOfMatches = new List<string>();
                    foreach(var match in matches)
                    {
                        listOfMatches.Add(match.ToString());
                    }
                    dictionary.Add(listOfMatches);
                }
            }
        }

        private void LoadLetters()
        {
            letters.Add(letter1.Text);
            letters.Add(letter2.Text);
            letters.Add(letter3.Text);
            letters.Add(letter4.Text);
            letters.Add(letter5.Text);
            letters.Add(letter6.Text);
            letters.Add(letter7.Text);
            letters.Add(letter8.Text);
            letters.Add(letter9.Text);
            letters.Add(letter10.Text);
        }
    }
}
