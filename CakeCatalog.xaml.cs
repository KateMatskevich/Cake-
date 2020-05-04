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
using Cake;

namespace Cake.Properties
{
    /// <summary>
    /// Логика взаимодействия для CakeCatalog.xaml
    /// </summary>
    public partial class CakeCatalog : Page
    {
        public CakeCatalog()
        {
            InitializeComponent();
        }

        private void GoOut_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SignIn.xaml", UriKind.Relative));
        }

        private void Main_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("HelloUser.xaml", UriKind.Relative));
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Catalog.xaml", UriKind.Relative));
        }

        private void Bans_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("BansCatalog.xaml", UriKind.Relative));
        }

        private void Macarons_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("MacaronsCatalog.xaml", UriKind.Relative));
        }
    }
}
