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

namespace Ex._5
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

        private async void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            int randomNumber;
            string pickedNum;


            for (int i = 0; i < 20; i++)
            {
                randomNumber = rng.Next(1, 21); // 1 - 20  random Number
                txtblkNum.Text = randomNumber.ToString();

                //Wait for task
                await Task.Delay(70);   //Add a pause for 70 milliseconds to add suspense to the game 
            }
        }
        public void BiggerOrSmaller()
        {
           if (radioBigger.IsChecked == true) 
            {
                BiggerNum();
            }
            else if (radioSmaller.IsChecked == true)
            {
                SmallerNum();
            }
           else { MessageBox.Show($"Please pick bigger or smaller."); }
        }

        private async void btnGuess_Click(object sender, RoutedEventArgs e)
        {
            Random rng = new Random();
            int randomNumber;
            string pickedNum;


            for (int i = 0; i < 20; i++)
            {
                randomNumber = rng.Next(1, 21); // 1 - 20  random Number
                txtblkEndNum.Text = randomNumber.ToString();

                

                //Wait for task
                await Task.Delay(70);   //Add a pause for 70 milliseconds to add suspense to the game 
            }
            BiggerOrSmaller();
        }
        public async void SmallerNum()
        {
            int num = 0;
            string endNum = txtblkEndNum.Text;
            int.TryParse(endNum, out num);

            await Task.Delay(70);

            if (num < int.Parse(txtblkNum.Text))
            {
                MessageBox.Show($"You Win!!");
            }
            else if (num == int.Parse(txtblkNum.Text))
            {
                MessageBox.Show($"Draw");
            }
            else { MessageBox.Show($"You Lose:("); }

        }
        public async void BiggerNum()
        {
            int num = 0;
            string endNum = txtblkEndNum.Text;
            int.TryParse(endNum, out num);

            await Task.Delay(70);

            if (num > int.Parse(txtblkNum.Text))
            {
                MessageBox.Show($"You Win!!");
            }
            else if (num == int.Parse(txtblkNum.Text))
            {
                MessageBox.Show($"Draw");
            }
            else { MessageBox.Show($"You Lose:("); }
        }
    }
}