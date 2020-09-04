using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для EditProfileRunner.xaml
    /// </summary>
    public partial class EditProfileRunner : Page
    {
        string sex = null, country = null;
        DateTime? birthDate = null;
        byte[] bytes;
        DBController dBController = new DBController();
        runner runnerActive;
        user userActive;
        public EditProfileRunner(user userActive)
        {
            this.userActive = userActive;
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
            txtEmail.Content = userActive.Email;
            runnerActive = userActive.runner.SingleOrDefault();
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
            if (txtPassword.Text.Length > 0)
            {
                if (txtPassword.Text.Length < 5) System.Windows.MessageBox.Show("Пароль слишком маленький");
                else
                {
                    userActive.Password = txtPassword.Text;
                    userActive.FirstName = txtFirstName.Text;
                    userActive.LastName = txtLastName.Text;
                    userActive.Photo = bytes;
                    runnerActive.Gender = sex;
                    runnerActive.DateOfBirth = birthDate;
                    runnerActive.CountryCode = country;
                    if (txtPassword.Text.Equals(txtSecondPassword.Text))
                    {
                        dBController.Edit();
                        System.Windows.MessageBox.Show("Данные обновлены!");
                        NavigationService.Navigate(new RunnerMenu(userActive));
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Выши пароли не совпадают!");
                    }
                }
            }
            else
            {
                userActive.FirstName = txtFirstName.Text;
                userActive.LastName = txtLastName.Text;
                userActive.Photo = bytes;
                runnerActive.Gender = sex;
                runnerActive.DateOfBirth = birthDate;
                runnerActive.CountryCode = country;
                if (txtPassword.Text.Equals(txtSecondPassword.Text))
                {
                    dBController.Edit();
                    System.Windows.MessageBox.Show("Данные обновлены!");
                    NavigationService.Navigate(new RunnerMenu(userActive));
                }
                else
                {
                    System.Windows.MessageBox.Show("Выши пароли не совпадают!");
                }
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
                catch
                {
                    System.Windows.MessageBox.Show("Ошибка загрузки");
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
