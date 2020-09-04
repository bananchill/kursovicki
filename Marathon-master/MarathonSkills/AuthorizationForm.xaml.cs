using System.Windows;
using System.Windows.Controls;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationForm.xaml
    /// </summary>
    public partial class AuthorizationForm : Page
    {
        DBController dBController = new DBController();
        user userActive;
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            userActive = dBController.ActiveUser(email.Text, password.Text);
            if (userActive != null)
            {
                NavigationService.Navigate(new AdministrationMenu(userActive));
                //switch (dBController.autorization(email.Text, password.Text))
                //{
                //    case "R":
                //        NavigationService.Navigate(new RunnerMenu(userActive));
                //        break;
                //    case "A":
                //        NavigationService.Navigate(new AdministrationMenu(userActive));
                //        break;
                //    case "C":
                //        NavigationService.Navigate(new CoordinatorMenu());
                //        break;
                //    default:
                //        MessageBox.Show("Что-то пошло не так, повторите ввод");
                //        break;
                //}
            }
        }
    }
}
