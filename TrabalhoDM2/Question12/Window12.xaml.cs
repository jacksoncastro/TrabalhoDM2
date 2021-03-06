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
using System.Windows.Shapes;

namespace TrabalhoDM2.Question12
{
    /// <summary>
    /// Lógica interna para Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        public String BackgroundColor { get; set; }

        public Window12()
        {
            InitializeComponent();
        }

        private void Button_Background_Click(object sender, RoutedEventArgs e)
        {
            this.TextBlockDraw.Background = (sender as Button).Background;
        }

        private void Button_Foreground_Click(object sender, RoutedEventArgs e)
        {
            this.TextBlockDraw.Foreground = (sender as Button).Background;
        }
    }
}
