using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для BMR.xaml
    /// </summary>
    public partial class BMR : Page
    {
        bool sex = false;
        public BMR()
        {
            InitializeComponent();
            pictureBoxMale.Source = new BitmapImage(new Uri("Resource/male-icon.png", UriKind.Relative));
            pictureBoxFemale.Source = new BitmapImage(new Uri("Resource/female-icon.png", UriKind.Relative));
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double num = 0.0;
            if (double.TryParse(txtHeight.Text, out num) && double.TryParse(txtWeight.Text, out num) && double.TryParse(txtAge.Text, out num))
            {
                if (double.Parse(txtHeight.Text) < 30 || double.Parse(txtHeight.Text) > 240 || double.Parse(txtWeight.Text) < 20 || double.Parse(txtWeight.Text) > 500 || double.Parse(txtAge.Text) < 5 || double.Parse(txtAge.Text) > 120)
                {
                    MessageBox.Show("Введите кореектные данные");
                }
                else
                {
                    double height = double.Parse(txtHeight.Text) / 100;
                    double weight = double.Parse(txtWeight.Text);
                    double age = double.Parse(txtAge.Text);
                    double bmr;
                    if(sex == false)
                    {
                        bmr = Math.Round((66.47f + (13.75f * weight + (5.003f * height)) - (6.755f * age)) / 1000, 3);
                        txtBMR.Text = bmr.ToString();
                    }
                    else
                    {
                        bmr = Math.Round((655.1f + (9.563f * weight + (1.85f * height)) - (4.676f * age)) / 1000, 3);
                        txtBMR.Text = bmr.ToString();
                    }
                    txtSit.Text = Math.Round(Convert.ToDouble(txtBMR.Text) * 1.2f, 3).ToString();
                    txtMin.Text = Math.Round(Convert.ToDouble(txtBMR.Text) * 1.375f, 3).ToString();
                    txtSred.Text = Math.Round(Convert.ToDouble(txtBMR.Text) * 1.55f, 3).ToString();
                    txtHigh.Text = Math.Round(Convert.ToDouble(txtBMR.Text) * 1.725f, 3).ToString();
                    txtMax.Text = Math.Round(Convert.ToDouble(txtBMR.Text) * 1.9f, 3).ToString();
                }
            }
            else
            {
                MessageBox.Show("Ну ты Валера, только цифры!");
            }
        }

        private void ImageMaleClick(object sender, RoutedEventArgs e)
        {
            pictureBoxFemale.InvalidateArrange();
            sex = false;
        }

        private void ImageFemaleClick(object sender, RoutedEventArgs e)
        {
            pictureBoxMale.InvalidateArrange();
            sex = true;
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnCancelClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_Click_Information(object sender, RoutedEventArgs e)
        {
            var from = new BMRAbout();
            from.ShowDialog();
        }
    }
}
