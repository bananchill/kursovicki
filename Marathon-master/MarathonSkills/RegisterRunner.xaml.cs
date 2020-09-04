using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для RegisterRunner.xaml
    /// </summary>
    public partial class RegisterRunner : Page
    {
        public RegisterRunner()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_becomeOldRunner_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationForm());
        }

        private void button_becomeNewRunner_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegisterNewRunner());
        }
        
        private void button_Authorization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationForm());
        }
    }
}
