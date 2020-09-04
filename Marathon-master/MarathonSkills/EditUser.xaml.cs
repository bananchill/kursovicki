using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Page
    {
        user userActive;
        DBController dBController;
        string role;
        public EditUser(user userActive)
        {
            this.userActive = userActive;
            InitializeComponent();
            dBController = new DBController();
            txtEmail.Content = userActive.Email;
            foreach (string role in dBController.roles().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = role;
                cmbRole.Items.Add(item);
            }
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
                if (txtPassword.Text.Length > 0)
            {
                if (txtPassword.Text.Length < 5) MessageBox.Show("Пароль слишком маленький");
                else
                {
                    userActive.Password = txtPassword.Text;
                    userActive.FirstName = txtFirstName.Text;
                    userActive.LastName = txtLastName.Text;
                    userActive.role.RoleName = role;
                    if (txtPassword.Text.Equals(txtSecondPassword.Text))
                    {
                        dBController.Edit();
                        MessageBox.Show("Данные обновлены!");
                        NavigationService.Navigate(new RunnerMenu(userActive));
                    }
                    else
                    {
                        MessageBox.Show("Выши пароли не совпадают!");
                    }
                }
            }
            else
            {
                userActive.Password = txtPassword.Text;
                userActive.FirstName = txtFirstName.Text;
                userActive.LastName = txtLastName.Text;
                userActive.role.RoleName = role;
                if (txtPassword.Text.Equals(txtSecondPassword.Text))
                {
                    dBController.Edit();
                    MessageBox.Show("Данные обновлены!");
                    NavigationService.Navigate(new UserManagement(userActive));
                }
                else
                {
                    MessageBox.Show("Выши пароли не совпадают!");
                }
            }
        }

        private void ComboBox_Selected_Role(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (System.Windows.Controls.ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            role = selectedItem.Content.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
