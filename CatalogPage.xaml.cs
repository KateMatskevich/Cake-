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

namespace Cake
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
        }

        private void Cake_button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CakeCatalog.xaml", UriKind.Relative));
        }

        private void GoOut_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SignIn.xaml", UriKind.Relative));
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("HelloUser.xaml", UriKind.Relative));
        }

        private void Buns_button_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("BansCatalog.xaml", UriKind.Relative));
        }

        private void Capcakes_button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("MacaronsCatalog.xaml", UriKind.Relative));
        }
    }
}
