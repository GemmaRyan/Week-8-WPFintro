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

namespace Ex._4
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

        private void txtInput_Drop(object sender, DragEventArgs e)
        {

        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            txtInput.Clear(); //clears textbox 

        }

        private void btnButton1_Click(object sender, RoutedEventArgs e)
        {
            //Read number from screen
            string input = txtInput.Text;

            //Check if its a number or not 
            int number;
            bool isNum = int.TryParse(input , out number);

            //Disply approprite number
            if (isNum == true) 
            {
                MessageBox.Show($"Value entered is a valid number");
                txtInput.Background = Brushes.BurlyWood;
            }
            else
            {
                MessageBox.Show($"Value entered is not a valid number");
                txtInput.Background = Brushes.Turquoise;
            }


        }
    }
}