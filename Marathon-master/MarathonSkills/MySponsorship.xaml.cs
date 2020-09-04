using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для MySponsorship.xaml
    /// </summary>
    public partial class MySponsorship : Page
    {
        DBController dBController;
        runner runnerActive;
        public MySponsorship(runner runnerActive)
        {
            dBController = new DBController();
            InitializeComponent();
            this.runnerActive = runnerActive;
            registration registration = runnerActive.registration.SingleOrDefault();
            string charitylogo = registration.charity.CharityLogo;
            pictureBox.Source = new BitmapImage(new Uri("Resource/" + charitylogo, UriKind.Relative));
            nameOrg.Content = registration.charity.CharityName;
            description.Text = registration.charity.CharityDescription;
            dataGridView.ItemsSource = dBController.Sonsorship(registration);
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dataGridView.Columns[0].Visibility = Visibility.Hidden;
            dataGridView.Columns[2].Visibility = Visibility.Hidden;
            dataGridView.Columns[4].Visibility = Visibility.Hidden;
            dataGridView.Columns[1].Header = "Спонсор";
            dataGridView.Columns[3].Header = "Взнос $";
        }
    }
}
