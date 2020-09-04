using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для CharityModal.xaml
    /// </summary>
    public partial class CharityModal : Window
    {
        public CharityModal(string name, string desc, string logo)
        {
            InitializeComponent();
            Name.Text = name;
            description.Text = desc;
            image.Source = new BitmapImage(new Uri("Resource/" + logo, UriKind.Relative));
        }
    }
}
