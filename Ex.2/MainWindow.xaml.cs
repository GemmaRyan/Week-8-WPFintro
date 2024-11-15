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

namespace Ex._2
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

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            //To clear text after each click
            txtInput.Text = "";
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            //Displays name thats entered suing just the button and a message box


            string name = txtInput.Text;
            MessageBox.Show($"Hello {name}");

                   


        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}