using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для EditOrganiation.xaml
    /// </summary>
    public partial class EditOrganiation : Page
    {
        user userActive;
        charity charityEdit;
        string bytes;
        DBController dBController;
        public EditOrganiation(user userActive, charity charityEdit)
        {
            InitializeComponent();
            dBController = new DBController();
            this.userActive = userActive;
            this.charityEdit = charityEdit;
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length > 1 && txtDescription.Text.Length > 10)
            {
                charityEdit.CharityName = txtName.Text;
                charityEdit.CharityDescription = txtDescription.Text;
                if (txtPhoto.Text.Length > 0) charityEdit.CharityLogo = bytes;
                dBController.Edit();
                System.Windows.MessageBox.Show("Данные обновлены!");
                NavigationService.Navigate(new OrganizationManagenent(userActive));
            }
            else
            {
                System.Windows.MessageBox.Show("Имя не может быть меньше 2 символов, а описание меньше 10!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Check(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.PNG)|*.BMP;*.JPG;*.JPEG;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtPhoto.Text = ofd.FileName;
                    Uri fileUri = new Uri(ofd.FileName);
                    pictureBox.Source = new BitmapImage(fileUri);
                    System.Drawing.Image image = System.Drawing.Image.FromFile(ofd.FileName);
                    var ms = new MemoryStream();
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    bytes = ms.ToString();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Ошибка");
                }
            }
        }
    }
}
