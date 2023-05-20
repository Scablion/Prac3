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

namespace Zadanie3
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

            int min = nums[0], max = nums[0];
            for (int i = 1; i < 3; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
                if (nums[i] < min)
                    min = nums[i];
            }
            Answer.Text = $"Минимальное: {min} \nМаксимальное: {max}";
        }
    }
}
