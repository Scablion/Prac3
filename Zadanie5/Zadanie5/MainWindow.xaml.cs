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
using static System.Math;

namespace Zadanie5
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
            int y = int.Parse(secondMean.Text);

            if (y < Abs(x) || y > 12)
                Answer.Text = "Вне области";
            else if (y > Abs(x) && y < 12)
                Answer.Text = "В области";
            else
                Answer.Text = "На границе";
        }
    }
}
