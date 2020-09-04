using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для CheckPointForm.xaml
    /// </summary>
    public partial class CheckPointForm : Page
    {
        public CheckPointForm()
        {
            InitializeComponent();
            panel1.Opacity = 0;
           
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_Click_CheckFirst(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 1";
            labelLandmark.Content = "Авенида Рудж";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName2.Content = "Энерг. батончики";
            pictureBoxServ3.Opacity = 0;
            labelServiceName3.Opacity = 0;
            pictureBoxServ4.Opacity = 0;
            labelServiceName4.Opacity = 0;
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
        }

        private void button_Click_CheckSecond(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 2";
            labelLandmark.Content = "Муниципальный Театр";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName1.Content = "Туалет";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-medical.png", UriKind.Relative));
            labelServiceName2.Content = "Медпункт";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName3.Content = "Стенд информации";
            pictureBoxServ4.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName4.Content = "Стенд питья";
            pictureBoxServ5.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName5.Content = "Энерг. батончики";
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
            pictureBoxServ4.Opacity = 100;
            labelServiceName4.Opacity = 100;
            pictureBoxServ5.Opacity = 100;
            labelServiceName5.Opacity = 100;
        }

        private void button_Click_CheckThird(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 3";
            labelLandmark.Content = "Парк ду Ибирапуэра";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName2.Content = "Энерг. батончики";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName3.Content = "Туалет";
            pictureBoxServ4.Opacity = 0;
            labelServiceName4.Opacity = 0;
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
        }

        private void button_Click_CheckFourth(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 4";
            labelLandmark.Content = "Жардим Лузитания";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName2.Content = "Энерг. батончики";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName3.Content = "Туалет";
            pictureBoxServ4.Source = new BitmapImage(new Uri("Map/map-icon-medical.png", UriKind.Relative));
            labelServiceName4.Content = "Медпункт";
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
            pictureBoxServ4.Opacity = 100;
            labelServiceName4.Opacity = 100;
        }

        private void button_Click_CheckFifth(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 5";
            labelLandmark.Content = "Игуатеми";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName2.Content = "Энерг. батончики";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName3.Content = "Туалет";
            pictureBoxServ4.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName4.Content = "Стенд информации";
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
            pictureBoxServ4.Opacity = 100;
            labelServiceName4.Opacity = 100;
        }

        private void button_Click_CheckSixth(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 6";
            labelLandmark.Content = "Руа Лиссабон";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName2.Content = "Энерг. батончики";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName3.Content = "Туалет";
            pictureBoxServ4.Opacity = 0;
            labelServiceName4.Opacity = 0;
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
        }

        private void button_Click_CheckSeventh(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 7";
            labelLandmark.Content = "Консоласан";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName1.Content = "Туалет";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-medical.png", UriKind.Relative));
            labelServiceName2.Content = "Медпункт";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName3.Content = "Стенд информации";
            pictureBoxServ4.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName4.Content = "Стенд питья";
            pictureBoxServ5.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName5.Content = "Энерг. батончики";
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
            pictureBoxServ4.Opacity = 100;
            labelServiceName4.Opacity = 100;
            pictureBoxServ5.Opacity = 100;
            labelServiceName5.Opacity = 100;
        }

        private void button_Click_CheckEigth(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Чекпойнт 8";
            labelLandmark.Content = "Консоласан";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName1.Content = "Туалет";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-medical.png", UriKind.Relative));
            labelServiceName2.Content = "Медпункт";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName3.Content = "Стенд информации";
            pictureBoxServ4.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName4.Content = "Стенд питья";
            pictureBoxServ5.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName5.Content = "Энерг. батончики";
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
            pictureBoxServ4.Opacity = 100;
            labelServiceName4.Opacity = 100;
            pictureBoxServ5.Opacity = 100;
            labelServiceName5.Opacity = 100;
        }

        private void button_Click_Start1(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Старт \"Самба\"";
            labelTitle1.Content = "Полный Марафон \"Самба\"\n" + "Руа-Ду-Американо 6:00";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-toilets.png", UriKind.Relative));
            labelServiceName1.Content = "Туалет";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-medical.png", UriKind.Relative));
            labelServiceName2.Content = "Медпункт";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName3.Content = "Стенд информации";
            pictureBoxServ4.Opacity = 0;
            labelServiceName4.Opacity = 0;
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
        }

        private void button_Click_Start2(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Старт \"Джонго\"";
            labelLandmark.Content = "Полумарафон \"Джонго\"\n" +
                "ул. Руа Ciniciata и Авенида 7:00";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-medical.png", UriKind.Relative));
            labelServiceName2.Content = "Медпункт";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName3.Content = "Стенд информации";
            pictureBoxServ4.Opacity = 0;
            labelServiceName4.Opacity = 0;
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
        }

        private void button_Click_Start3(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 100;
            labelTitle.Content = "Старт \"Капоэйра\"";
            labelLandmark.Content = "Забег в 5 км. \"Капоэйра\"\n" + "Мемориал Унинове 15:00";
            pictureBoxServ1.Source = new BitmapImage(new Uri("Map/map-icon-drinks.png", UriKind.Relative));
            labelServiceName1.Content = "Стенд питья";
            pictureBoxServ2.Source = new BitmapImage(new Uri("Map/map-icon-energy-bars.png", UriKind.Relative));
            labelServiceName2.Content = "Энерг. батончики";
            pictureBoxServ3.Source = new BitmapImage(new Uri("Map/map-icon-information.png", UriKind.Relative));
            labelServiceName3.Content = "Стенд информации";
            pictureBoxServ4.Opacity = 0;
            labelServiceName4.Opacity = 0;
            pictureBoxServ5.Opacity = 0;
            labelServiceName5.Opacity = 0;
            pictureBoxServ1.Opacity = 100;
            labelServiceName1.Opacity = 100;
            pictureBoxServ2.Opacity = 100;
            labelServiceName2.Opacity = 100;
            pictureBoxServ3.Opacity = 100;
            labelServiceName3.Opacity = 100;
        }

        private void button_Click_Close(object sender, RoutedEventArgs e)
        {
            panel1.Opacity = 0;
        }
    }
}
