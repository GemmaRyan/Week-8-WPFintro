using System.Diagnostics.Eventing.Reader;
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

namespace Ex._6
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

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {

            string input = txtInput.Text;
            
            int number;
            bool isNum = int.TryParse(input, out number);

            double oddOrEven = number % 2;

            if (oddOrEven != 0 && isNum == true)
            {
                txtblkResult.Text = "Odd number";
                txtblkResult.Foreground = Brushes.Red;
            }
            else if (oddOrEven == 0 && isNum == true)
            {
                txtblkResult.Text = "Even number";
                txtblkResult.Foreground = Brushes.Green;
            }
            else if (isNum == false)
            { 
                MessageBox.Show($"Incorrect Formatt, try again"); 
                txtblkResult.Foreground = Brushes.Gray; 
            }
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
           
        }
    }
}