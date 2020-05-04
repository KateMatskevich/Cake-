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
    /// Логика взаимодействия для BansCatalog.xaml
    /// </summary>
    public partial class BansCatalog : Page
    {
        public BansCatalog()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Catalog.xaml", UriKind.Relative));
        }

        private void Main_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("HelloUser.xaml", UriKind.Relative));
        }

        private void GoOut_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("SignIn.xaml", UriKind.Relative));
        }

        private void CakeCatalog_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("CakeCatalog.xaml", UriKind.Relative));
        }

        private void MakaronsCatalog_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("MacaronsCatalog.xaml", UriKind.Relative));
        }
    }
}
