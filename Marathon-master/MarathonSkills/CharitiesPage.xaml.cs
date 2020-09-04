using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для CharitiesPage.xaml
    /// </summary>
    public partial class CharitiesPage : Page
    {
        public static MarathonSkillsEntities db { get; set; }
        public CharitiesPage()
        {
            InitializeComponent();
            db = new MarathonSkillsEntities();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = db.charity.ToList();
        }
    }
}
