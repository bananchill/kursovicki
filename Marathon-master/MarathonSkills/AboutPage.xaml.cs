using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_list_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CharitiesPage());
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Map());
        }

        private void button1_BMI_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BMICalculator());
        }

        private void button1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BMR());
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LongMarathon());
        }
    }
}
