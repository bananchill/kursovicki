using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для OrganizationManagenent.xaml
    /// </summary>
    public partial class OrganizationManagenent : Page
    {
        DBController dBController;
        public static MarathonSkillsEntities db { get; set; }
        user userActive;
        public OrganizationManagenent(user userActive)
        {
            this.userActive = userActive;
            InitializeComponent();
            dBController = new DBController();
            db = new MarathonSkillsEntities();
            //dataGridView.ItemsSource = dBController.GetCharity();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        
        private void button_Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrganization(userActive));
        }

        private void button_Click_Edit(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditOrganiation(userActive, null));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listView.ItemsSource = db.charity.ToList();
        }
    }
}
