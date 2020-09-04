using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_becomeRunner_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterRunner());
        }

        private void button_becomeSponsor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SponsorPage());
        }

        private void button_about_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AboutPage());
        }

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationForm());
        }
    }
}
