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

namespace task7
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
            if (number % 2 == 0 && number < 10)
            {
                otvet.Text = ("Четное однозначное").ToString();
            }
            else if (number % 2 == 0 && number < 100)
            {
                otvet.Text = ("Четное двузначное").ToString();
            }
            else
            {
                otvet.Text = ("Четное трехзначеное").ToString();
            }
            if (number % 2 != 0 && number < 10)
            {
                otvet.Text = ("Нечетное однозначное").ToString();
            }
            else if (number % 2 != 0 && number < 100)
            {
                otvet.Text = ("Нечетное двузначное").ToString();
            }
            else if (number % 2 != 0 && number < 1000)
            {
                otvet.Text = ("Нечетное трехзначеное").ToString();
            }
        }
    }
}
