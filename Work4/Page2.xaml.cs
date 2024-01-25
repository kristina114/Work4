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

namespace Work4
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(NumberTextBox.Text, out int n) || n < 20 || n > 69)
            {
                MessageBox.Show("Введите число от 20 до 69");
            }

            int fisrt = n / 10;
            int last = n % 10;
            string f = null, l = null;

            switch (fisrt)
            {
                case 2:
                    f = "Двадцать";
                    break;
                case 3:
                    f = "Тридцать";
                    break;
                case 4:
                    f = "Сорок";
                    break;
                case 5:
                    f = "Пятдесят";
                    break;
                case 6:
                    f = "Шестдесят";
                    break;
            }

            switch (last)
            {
                case 1:
                    l = " один год";
                    break;
                case 2:
                    l = " два года";
                    break;
                case 3:
                    l = " три года";
                    break;
                case 4:
                    l = " четыре года";
                    break;
                case 5:
                    l = " пять лет";
                    break;
                case 6:
                    l = " шесть лет";
                    break;
                case 7:
                    l = " семь лет";
                    break;
                case 8:
                    l = " восемь лет";
                    break;
                case 9:
                    l = " девять лет";
                    break;
            }

            AnswerTextBox.Text = f + l;
        }
    }
}
