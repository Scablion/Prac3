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

namespace Zadanie4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            int[] nums = new int[3];
            nums[0] = int.Parse(firstMean.Text);
            nums[1] = int.Parse(secondMean.Text);
            nums[2] = int.Parse(thirdMean.Text);

            double M = (nums[0] + Pow(nums[1], 2)) / nums[2];
            int k = Convert.ToInt32(M % 3);
            double? y = null;
            if (k == 1)
                y = Exp(M + nums[2]);
            else if (k == 0)
                y = Log10(nums[0] / nums[1]);
            else if (k == 2)
                y = Sqrt(Abs(Pow(nums[0] + nums[1], 2) + nums[2]));
            if (y != null)
                Answer.Text = $"k = {k} \nY = {y:f3}";
        }
    }
}
