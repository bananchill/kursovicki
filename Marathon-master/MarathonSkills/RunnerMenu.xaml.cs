using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для RunnerMenu.xaml
    /// </summary>
    public partial class RunnerMenu : Page
    {
        user userActive;
        public RunnerMenu(user userActive)
        {
            InitializeComponent();
            this.userActive = userActive;
        }

        private void btnRegisterEvent_Click(object sender, RoutedEventArgs e)
        {
            runner runnerActive = userActive.runner.SingleOrDefault();
            if (runnerActive.registration.Count == 0)
            {
                NavigationService.Navigate(new EventRegister(runnerActive));
            }
            else
            {
                MessageBox.Show("Вы уже зарегестрированы на марафон!");
            }
            NavigationService.Navigate(new EventRegister(null, null));
        }

        private void btnRunnerProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditProfileRunner(userActive));
        }
        
        private void btnRunnerContacts_Click(object sender, RoutedEventArgs e)
        {
            var from = new Contacts();
            from.ShowDialog();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
        
        private void buttonMySponsorClick(object sender, RoutedEventArgs e)
        {
            runner runner = userActive.runner.SingleOrDefault();
            NavigationService.Navigate(new MySponsorship(runner));
        }
        
        private void btnMyResults_Click(object sender, RoutedEventArgs e)
        {
            runner runner = userActive.runner.SingleOrDefault();
            NavigationService.Navigate(new MyResults(runner));
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
