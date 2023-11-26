﻿using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void FirstPage_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page1());
        }
        private void SecondPage_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page2());
        }
        private void ThreePage_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page3());
        }
        private void FourPage_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page4());
        }

        private void FivePage_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page5());
        }
    }
}
