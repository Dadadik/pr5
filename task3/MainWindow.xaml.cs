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

namespace task3
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
            if (!double.TryParse(A.Text, out double a))
            {

            }
            if (!double.TryParse(B.Text, out double b))
            {

                if (!double.TryParse(C.Text, out double c))
                {

                }

                if ((a < b && b < c) || (a > b && b > c))
                {
                    a *= 2;
                    b *= 2;
                    c *= 2;
                }
                else
                {
                    a = -a;
                    a = -b;
                    a = -c;
                }
                MessageBox.Show($"Новые значения A ={a} ,B={b} ,C={c}");

            }
        }
    }
}
