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

namespace Estilos_de_RubénL
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 abrirWindow3 = new Window3();
            this.Close();
            abrirWindow3.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 abrirWindow1 = new Window1();
            this.Close();
            abrirWindow1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow abrirMainWindow = new MainWindow();
            this.Close();
            abrirMainWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 abrirWindow2 = new Window2();
            this.Close();
            abrirWindow2.Show();
        }
    }
}
