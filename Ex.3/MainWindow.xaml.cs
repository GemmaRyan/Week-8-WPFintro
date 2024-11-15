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

namespace Ex._3
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

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            //Update();   //Using this too call another method
            Update2();
        }

        public void Update()
        {
            Random rng = new Random();

            int randomNumber = rng.Next(1, 7);       //Starting at 1 but less than 7 // 1 < 7 

            txtblkResult.Text = randomNumber.ToString();

        }
        public async void Update2() //Threaded message / threaded code
        {
            Random rng = new Random();
            int randomNumber;


            for(int i = 0; i < 20; i++)
            {
                randomNumber = rng.Next(1, 7); // 1 - 6  random Number
                txtblkResult.Text = randomNumber.ToString();

                //Wait for task
                await Task.Delay(50);   //Add a pause for 50 milliseconds to add suspense to the game 



            }
        }
    }
}