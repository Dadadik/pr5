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

namespace task4
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
            if (!double.TryParse(x.Text, out double X))
            {

            }
            if (X > (-Math.PI / 2) && X < (Math.PI / 2))
            {
                tBox.Text = (Math.Sqrt(Math.Abs(Math.Sin(X) + Math.Pow(Math.Tan(X), 2) / 3.5 * Math.Cos(X)))).ToString();
            }
            else if (X < Math.PI && X > (Math.PI / 2)) ;
            {
                tBox.Text = (Math.Cos((X / 3) / Math.Sin(X) + Math.Pow(Math.Tan(X), 2))).ToString();
            }
        }
    }
}
