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

namespace Ex_1_
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
            //Read data entered into text box 
            string input = txtInput.Text;

            //display in text block
            txtblkDisplay.Text = input;
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            //method to clear the text when reclicking textbox
            txtInput.Text = "";

            //clears the textblock          //both the textblock and the text box are cleared everytime the text box is clicked

            txtblkDisplay.Text = "";
        }
    }
}