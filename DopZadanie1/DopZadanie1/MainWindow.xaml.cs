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

namespace DopZadanie1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {

            int x = int.Parse(firstMean.Text);
            string description = "Число ";
            if (x == 0)
                description += "равно нулю.";
            if (x > 0)
            {
                description += "положительное, \n";
                if (x % 2 == 0)
                    description += "четное, \n";
                else
                    description += "нечетное, \n";

                if (x < 10 && x != 0)
                    description += "однозначное.";
                else if (x < 100)
                    description += "двухзначное.";
                else if (x < 1000)
                    description += "трехзначное.";
                else if (x < 10000)
                    description += "четырехзначное.";
                else if (x < 100000)
                    description += "пятизначное.";
                else
                    description += "многозначное.";
            }
            if (x < 0)
            {
                description += "отрицательное, \n";
                if (x % 2 == 0)
                    description += "четное,\n";
                else
                    description += "нечетное, \n";

                if ((x > -10) && x != 0)
                    description += "однозначное.";
                else if (x > -100)
                    description += "двухзначное.";
                else if (x > -1000)
                    description += "трехзначное.";
                else if (x > -10000)
                    description += "четырехзначное.";
                else if (x > -100000)
                    description += "пятизначное.";
                else
                    description += "многозначное.";
            }
            Answer.Text = description;
        }
    }
}
