using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static public void StringToCharArray1(ref string inputString, out string[] subStrings, out int count)
        {
            subStrings = inputString.Split(' ');
            count = subStrings.Length;
        }

        static public void WordRevers(ref string inputString, out string[] subStrings, out int count, out string outputString)
        {
            StringToCharArray1(ref inputString, out subStrings, out count);

            string probel = " ";
            string newString = null;
            outputString = null;
            for (int j = (count - 1); j >= 0; j--)
            {
                newString = subStrings[j];
                outputString += newString + " ";
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            string input = first.Text;
            string[] arraywords;
            int outarayword;
            StringToCharArray1(ref input, out arraywords, out outarayword);
            //box1.Items.Clear();
            box1.ItemsSource = arraywords;
        }

        private void change_Click(object sender, RoutedEventArgs e)
        {
            string input = second.Text;
            string[] arraywords;
            int outarayword;
            string output;
            WordRevers(ref input, out arraywords, out outarayword, out output);
            box2.Content = output;
        }
    }
}