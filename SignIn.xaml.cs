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
using System.Security.Cryptography;
using System.Data;

namespace Cake
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            bool find = false;
            SHA1 sHA1 = new SHA1CryptoServiceProvider();
            //туть уже самая умняшечка моя
            //перебираешь юзеров ищешь что есть такой логин и пароль и если есть то окрывашь окошечко))) удачи

            if (string.IsNullOrEmpty(Login_TextBox.Text))
            {
                find = false;
                throw new Exception("Введите пароль");

            }
                if (string.IsNullOrEmpty(Password_TextBox.Text))
            {

                find = false;
                throw new Exception("Введите логин");

            }
            
      (User.Password.SequenceEqual(sHA1.ComputeHash(Encoding.ASCII.GetBytes(Password_TextBox.Text)))) ;







            }
            private void CreateNewAcc_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("Registr.xaml", UriKind.Relative));
        }
    }
}
