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

namespace TeplicaIS
{
    /// <summary>
    /// Логика взаимодействия для Work.xaml
    /// </summary>
    public partial class Work : Window
    {
        public Work()
        {
            InitializeComponent();
        }

        private void MenuItemHeat_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PageHeat());
        }
        private void MenuItemWater_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new water());
        }
    
    
    
    }
}

