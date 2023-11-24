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

namespace task5
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
            if (!double.TryParse(x.Text, out double X)) ;
            {

            }
            if (!double.TryParse(y.Text, out double Y)) ;
            {
            }
            if (Y > 0 && Y < 5 && X > 0 && X < 10)
            {
                otvet.Text = ("Да").ToString();
            }
            else if (Y == 5 || Y == 0 && X == 10 || X == 1)
            {
                otvet.Text = ("На границе").ToString();
            }
            else
            {
                otvet.Text = ("Нет").ToString();
            }
        }
    }
}
