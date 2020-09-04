using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для AdministrationMenu.xaml
    /// </summary>
    public partial class AdministrationMenu : Page
    {
        user userActive;
        public AdministrationMenu(user userActive)
        {
            InitializeComponent();
            this.userActive = userActive;
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void btnRegisterEvent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserManagement(userActive));
        }

        private void btnRunnerProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrganizationManagenent(userActive));
        }
    }
}
