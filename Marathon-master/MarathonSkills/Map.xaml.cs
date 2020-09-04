using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        public Map()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        
        private void button_Click_Map(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckPointForm());
        }
    }
}
