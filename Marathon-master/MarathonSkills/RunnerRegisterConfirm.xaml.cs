using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для RunnerRegisterConfirm.xaml
    /// </summary>
    public partial class RunnerRegisterConfirm : Page
    {
        user userActive;
        public RunnerRegisterConfirm(user userActive)
        {
            InitializeComponent();
            this.userActive = userActive;
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RunnerMenu(userActive));
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
