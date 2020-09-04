using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace kusach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        user userActive;
        int countt = 0;
        DbController dBController = new DbController();
        izdelia zakaz;
        public MainWindow()
        {
            InitializeComponent();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_login(object sender, RoutedEventArgs e)
        {
            if (loginbox.Text == "" || passwordbox.Password == "")
                MessageBox.Show("Поля не миогут быть пустыми", "Повторите ввод");
            //if (check())
            //    return;
            userActive = DbController.Activeus(loginbox.Text, passwordbox.Password);

            if (userActive != null)
            {
                MessageBox.Show("Здравствйте " + userActive.namepat.ToString() + "вы вошли в систему", "Вход");
                switch (dBController.autorization(loginbox.Text, passwordbox.Password))
                {
                    case "Заказчик":
                        Users us = new Users(userActive, zakaz);
                        us.Show();
                        this.Close();
                        break;
                    case "Менеджер":
                        Manager man = new Manager(userActive);
                        man.Show();
                        this.Close();
                        break;
                    case "Мастер":
                        Master mas = new Master(userActive);
                        mas.Show();
                        this.Close();
                        break;
                    case "0":
                        ZamDirectora zam = new ZamDirectora(userActive);
                        zam.Show();
                        this.Close();
                        break;
                    case "Директор":
                        Director dir = new Director(userActive);
                        dir.Show();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Что-то пошло не так, повторите ввод");
                        break;
                }
            }
            if (userActive == null)
            {
                countt++;
                MessageBox.Show("Пароль неверный");
            }
            if (countt == 3)
            {
                MessageBox.Show("Три раза введен неверный логин или пароль", "Повторите запуск приложения");
                this.Close();
            }

        }

        private void Button_registr(object sender, RoutedEventArgs e)
        {
            registr reg = new registr();
            reg.Show();
            this.Close();
        }
    }

    //public Boolean check() {

    //    user user = new user();

    //    MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `password`=@pas", db.getConnection());
    //    command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = passwordbox.Password;

    //    adapter.SelectCommand = command; // указывает , какую команду выполняем 
    //    adapter.Fill(table);    // adapter- выбирает данные из бд 

    //    if (user.password != passwordbox.Password)
    //        return false;
    //    else
    //        return true;
    //}

}





