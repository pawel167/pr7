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
using static System.Math;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int u))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!int.TryParse(textbox2.Text, out int v))
            {
                MessageBox.Show("Поле B только число!");
            }
            if (!int.TryParse(textbox3.Text, out int n))
            {
                MessageBox.Show("Поле C только число!");
            }
            double a = u;
            double b = v;
            double s = a * b / 2.0;
            for (int i = 2; i <= n; i++)
            {
                double new_a = 2 * b + a;
                b += 2 * Pow(a, 2);
                a = new_a;
                double k = 1;
                    for (int j = 1; j <= i; j++)
                {
                     k = k * j;
                }
                s += a * b / k;
            }
            answer.Text += s;
        }
    }
}
