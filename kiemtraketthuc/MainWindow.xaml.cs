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

namespace kiemtraketthuc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btncho_Click(object sender, RoutedEventArgs e)
        {
            cho Cho = new cho();
            Cho.dongvatName = "Gâu gâu";
            Cho.dongvatmaulong = "đen";
            Cho.Talk();
        }

        private void btnmeo_Click(object sender, RoutedEventArgs e)
        {
            meo Meo = new meo();
            Meo.dongvatName = "Meo meo";
            Meo.dongvatmaulong = "trắng";
            Meo.Talk();
        }
    }
}
