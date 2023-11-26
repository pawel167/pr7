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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!double.TryParse(textbox1.Text, out double x))
            {
                MessageBox.Show("Поле А только число!");
            }
            double z = 1;
            for (double i = 1; i <= x; i += 1)
            {
                z *= 1.0 + i / 10;
                answer.Text += $"{z} \n";
            }
        }
    }
}
