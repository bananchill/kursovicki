using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для CoordinatorMenu.xaml
    /// </summary>
    public partial class CoordinatorMenu : Page
    {
        public CoordinatorMenu()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_Runners_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CoordinatorMenu());
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CoordinatorMenu());
        }
        
        private void button_Sponsors_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
