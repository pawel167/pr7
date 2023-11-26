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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!double.TryParse(textbox1.Text, out double a))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!int.TryParse(textbox2.Text, out int n))
            {
                MessageBox.Show("Поле А только число!");
            }
            for (double i = 0; i <= n; i++)
            {
                a += Pow(a, i);
                answer.Text += $"{a}\n";
            }
        }
    }
}
