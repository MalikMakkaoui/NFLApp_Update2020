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

namespace FootballApp
{
    /// <summary>
    /// Interaction logic for WideReceievers.xaml
    /// </summary>
    public partial class WideReceievers : Window
    {
        public WideReceievers()
        {
            InitializeComponent();
        }

        private void Compare_Click(object sender, RoutedEventArgs e)
        {
            var WindowWR_Results = new WR_Results();
            WindowWR_Results.Show();
            this.Close();
        }
    }
}