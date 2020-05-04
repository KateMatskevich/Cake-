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
using System.Data.Entity;//подключение
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;


namespace Cake
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>



    public partial class Registr
    {
        public Registr()
        {

        }
        
        private void OK_Button_Click(object sender, RoutedEventArgs e)
        {
           
            SHA1 sHA1 = new SHA1CryptoServiceProvider(); //класс для хэширования
                                                         //если не удовлетврояет то ты солнышко мое любимое но глупенькое ))) ставишь check в false я очень зоооооооооооол
            bool check = true;
            
            if (string.IsNullOrEmpty(name_TextBox.Text))
            {
                 check = false;
                 MessageBox.Show("Введите имя") ;
                   
                
            }
            if (string.IsNullOrEmpty(surname_TextBox.Text))
            {

                check = false;
                MessageBox.Show("Введите фамилию");

            }
            if (string.IsNullOrEmpty(phone_TextBox.Text))
            {

                check = false;
                MessageBox.Show("Введите телефон");

            }
            if (string.IsNullOrEmpty(Password_TextBox.Text))
            {

                check = false;
                MessageBox.Show("Введите логин");

            }

            if (string.IsNullOrEmpty(login_TextBox.Text))
            {
                check = false;
                MessageBox.Show("Введите пароль");

            }


            if (check)
            {
                try
                {
                    //туть мы создаем объект для работы с бд
                    CakeEntities entities = new CakeEntities();
                    List<User> users= entities.User.ToList();//примерно так мы можем получить всех наших дружочков пирожочков
                    //воть туть проверяешь а вдруг такой дружочек у нас уже есть
                  
                    foreach (var item in users)
                    {
                        //туть логи надеюсь что в бл логин у тебя уникальный или вообше ключ
                        //можжно этот цикл и убрать тебе выдаст ошибку но catch ее обработает все равно
                        if (item.Login=="")
                        {
                            check = false;
                        }
                    }
                    if (check)
                    {
                        User newuser = new User
                        {
                            Name = name_TextBox.Text,
                            Surname = surname_TextBox.Text,
                            Phone = Convert.ToDecimal(phone_TextBox.Text),
                            Login = login_TextBox.Text,
                            Password = sHA1.ComputeHash(Encoding.ASCII.GetBytes(Password_TextBox.Text))
                        };
                    
                        entities.User.Add(newuser);
                        entities.SaveChanges();
                        MessageBox.Show("Registration was successful");
                        NavigationService nav = NavigationService.GetNavigationService(this);
                        nav.Navigate(new Uri("HelloUser.xaml", UriKind.Relative));
                    }
                    else
                    {
                        MessageBox.Show("Просто дружочек на сердечко занято возьми другой логин, мяв");
                    }
                }
                catch
                {
                    MessageBox.Show("This Login is busy");
                }
            }
            else
                MessageBox.Show("Простите но вы не внимательная прямо как я, но мы с вами цветочки и у нас все еще впереди, мяв");
        }

    }
 }
  
