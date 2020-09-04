using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для RegisterNewRunner.xaml
    /// </summary>
    public partial class RegisterNewRunner : Page
    {
        string sex = null, country = null;
        DateTime? birthDate = null;
        byte[] bytes;
        DBController dBController = new DBController();
        public RegisterNewRunner()
        {
            InitializeComponent();
            foreach (string sex in dBController.gender().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = sex;
                cmbGender.Items.Add(item);
            }

            foreach (string country in dBController.country().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = country;
                cmbCountry.Items.Add(item);
            }
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            user user = new user();
            runner runner = new runner();
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.RoleId = "R";
            user.Photo = bytes;
            runner.Email = txtEmail.Text;
            runner.Gender = sex;
            runner.DateOfBirth = birthDate;
            runner.CountryCode = country;
            if (txtPassword.Text.Equals(txtSecondPassword.Text))
            {
                dBController.AddRunner(user, runner);
                NavigationService.Navigate(new EventRegister(user, runner));
            }
            else
            {
                System.Windows.MessageBox.Show("Выши пароли не совпадают!");
            }
        }

        private void ComboBox_Selected_Gender(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = (System.Windows.Controls.ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            sex = selectedItem.Content.ToString();
        }

        private void ComboBox_Selected_Country(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.ComboBox comboBox = (System.Windows.Controls.ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            country = selectedItem.Content.ToString();
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
                    bytes = ms.ToArray();
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.ToString());
                }
            }
        }

        private void selectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = dpBirth.SelectedDate;
            birthDate = selectedDate;
        }
    }
}
