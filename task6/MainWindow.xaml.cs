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

namespace task6
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
            if (!int.TryParse(Number.Text, out int number)) ;
            if (number == 0)
            {
                otvet.Text = ("Нулевое число").ToString();
            }
            else if (number > 0)
            {
                if (number % 2 == 0)
                {
                    otvet.Text = ("Положительное четное число").ToString();
                }
                else
                {
                    otvet.Text = ("Положительное нечетное число").ToString();
                }
            }
            else
            {
                if (number % 2 == 0)
                {
                    otvet.Text = ("Отрицательное четное число").ToString();
                }
                else
                {
                    otvet.Text = ("Отрицательное нечетное число").ToString();
                }

            }
        }
    }
}
