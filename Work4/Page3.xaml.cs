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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            if (!int.TryParse(NumberTextBox.Text, out int n))
            {
                MessageBox.Show("Введите число больше 0");
            }

            while (n > 0)
            {
                if (n % 10 == 2)
                {
                    flag = true;
                }
                n /= 10;
            }

            AnswerTextBox.Text = $"{flag}";
        }
    }
}
