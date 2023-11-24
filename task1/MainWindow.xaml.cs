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

namespace task1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(a.Text, out double A))
            {

            }
            if (!double.TryParse(a.Text, out double B))
            {

            }
            if (!double.TryParse(a.Text, out double C))
            {

            }
            double D = B * B - 4 * A * C;
            if (D >= 0)
            {
                MessageBox.Show("Уравнение имеет решение");

            }
            else
            {
                MessageBox.Show("Уравнение не имеет решения");
            }
        }
    }
}
