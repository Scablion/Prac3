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

namespace Zadanie1
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

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(firstMean.Text);
            int second = num / 10 % 10, last = num % 10;
            if (second > last)
                Answer.Text = "Вторая цифра \nбольше последней";
            else if (second == last)
                Answer.Text = "Цифры равны";
            else
                Answer.Text = "Последняя цифра \nбольше второй";

        }
    }
}
