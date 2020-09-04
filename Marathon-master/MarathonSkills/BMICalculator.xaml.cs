using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для BMICalculator.xaml
    /// </summary>
    public partial class BMICalculator : Page
    {
        bool sex = false;
        public BMICalculator()
        {
            InitializeComponent();
            pictureBoxMale.Source = new BitmapImage(new Uri("Resource/male-icon.png", UriKind.Relative));
            pictureBoxFemale.Source = new BitmapImage(new Uri("Resource/female-icon.png", UriKind.Relative));
            pictureBoxResult.Source = new BitmapImage(new Uri("Resource/bmi-healthy-icon.png", UriKind.Relative));
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double num = 0.0;
            if (double.TryParse(txtHeight.Text, out num) && double.TryParse(txtWeight.Text, out num))
            {
                if (double.Parse(txtHeight.Text) < 30 || double.Parse(txtHeight.Text) > 240 || double.Parse(txtWeight.Text) < 20 || double.Parse(txtWeight.Text) > 500)
                {
                    MessageBox.Show("Введите кореектные данные");
                }
                else
                {
                    double height = double.Parse(txtHeight.Text) / 100;
                    double weight = double.Parse(txtWeight.Text);
                    double bmi = (weight / (height * height));
                    if (bmi < 18.5f)
                    {
                        polii.Margin = new Thickness(bmi * 2, 0, 0, 0);
                        pictureBoxResult.Source = new BitmapImage(new Uri("Resource/bmi-underweight-icon.png", UriKind.Relative));
                        labelSum.Text = "Недостаточный";
                        MessageBox.Show(bmi.ToString());
                    }
                    else if (bmi > 18.5f && bmi < 24.9f)
                    {
                        polii.Margin = new Thickness(bmi * 4, 0, 0, 0);
                        pictureBoxResult.Source = new BitmapImage(new Uri("Resource/bmi-healthy-icon.png", UriKind.Relative));
                        labelSum.Text = "Здоровый";
                        MessageBox.Show((bmi * 4).ToString());
                    }
                    else if (bmi > 25f && bmi < 29.9f)
                    {
                        polii.Margin = new Thickness(bmi * 5, 0, 0, 0);
                        pictureBoxResult.Source = new BitmapImage(new Uri("Resource/bmi-overweight-icon.png", UriKind.Relative));
                        labelSum.Text = "Избыточный";
                        MessageBox.Show((bmi * 5).ToString());
                    }
                    else if (bmi > 30f)
                    {
                        if (bmi * 7 >= 280)
                        {
                            polii.Margin = new Thickness(280, 0, 0, 0);
                        }
                        else polii.Margin = new Thickness(bmi * 7, 0, 0, 0);
                        pictureBoxResult.Source = new BitmapImage(new Uri("Resource/bmi-obese-icon.png", UriKind.Relative));
                        labelSum.Text = "Ожирение";
                        MessageBox.Show((bmi * 7).ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Можно вводить только цифры!");
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
    }
}
