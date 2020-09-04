using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для registr.xaml
    /// </summary>
    public partial class registr : Window
    {
        DbController dBController = new DbController();
        string roles = null;
        public registr()
        {
            InitializeComponent();
            foreach (string roles in DbController.User().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = roles;
                RoleBox.Items.Add(item);
            }

        }

        private void Button_registr(object sender, RoutedEventArgs e)
        {
            if (text.Text == "" || passwordbox.Password == "" || NamePatBox.Text == "" || loginbox.Text == "")
            {
                MessageBox.Show("Введите Все Данные", "Повторный ввод");
                return;
            }

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login`=@login", db.getConnection()); // @uL - заглушка для более хорошой защиты бд

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginbox.Text;

            adapter.SelectCommand = command; // указывает , какую команду выполняем 
            adapter.Fill(table);    // adapter- выбирает данные из бд 


            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин существует");
                return;
            }
            try
            {
                Regex pravilo1 = new Regex(@"[*&{}|+,]+");
                Regex pravilo2 = new Regex(@"[a-zA-Z]+");
                Regex pravilo4 = new Regex(@"[0-9]+");

                user user = new user();

                user.lastname = text.Text;
                user.password = passwordbox.Password;
                user.namepat = NamePatBox.Text;
                user.login = loginbox.Text;
                user.role = RoleBox.Text;

                if (passwordbox.Password.Equals(passwordrepeatBox.Password) && passwordbox.MaxLength < 18 || passwordbox.MaxLength > 3
                && pravilo2.IsMatch(passwordbox.Password) && pravilo4.IsMatch(passwordbox.Password) != pravilo1.IsMatch(passwordbox.Password))
                {
                    dBController.Adduser(user);
                    MainWindow main = new MainWindow();
                    main.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Выши пароли не совпадают!");
            }
            catch (Exception l)
            {

                MessageBox.Show("Произошла оошибка при вводе данных , повторите заного");
            }




        }
        //public Boolean check()
        //{
        //    DB db = new DB();

        //    DataTable table = new DataTable();

        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `login`=@login", db.getConnection()); // @uL - заглушка для более хорошой защиты бд

        //    command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginbox.Text;

        //    adapter.SelectCommand = command; // указывает , какую команду выполняем 
        //    adapter.Fill(table);    // adapter- выбирает данные из бд 


        //    if (table.Rows.Count > 0)
        //    {
        //        MessageBox.Show("Такой логин существует");
        //        return true;
        //    }


        //    else
        //    {
        //        MessageBox.Show("неверный Логин или пароль", "Повторите ввод");
        //        return false;
        //    }
        //}

        private void RoleBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = (System.Windows.Controls.ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            roles = selectedItem.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
