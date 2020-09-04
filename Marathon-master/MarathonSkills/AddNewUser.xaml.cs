using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для AddNewUser.xaml
    /// </summary>
    public partial class AddNewUser : Page
    {
        string role;
        user userActive;
        DBController dBController = new DBController(); 
        public AddNewUser(user userActive)
        {
            this.userActive = userActive;
            InitializeComponent();
            foreach (string sex in dBController.roles().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = sex;
                cmbRole.Items.Add(item);
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            user user = new user();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.RoleId = role;
            if (txtPassword.Text.Equals(txtSecondPassword.Text))
            {
                dBController.AddUser(user);
                MessageBox.Show("Пользователь добавлен!");
                NavigationService.Navigate(new UserManagement(userActive));
            }
            else
            {
                MessageBox.Show("Выши пароли не совпадают!");
            }
        }

        private void ComboBox_Selected_Role(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            role = dBController.roleId(selectedItem.Content.ToString());
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
