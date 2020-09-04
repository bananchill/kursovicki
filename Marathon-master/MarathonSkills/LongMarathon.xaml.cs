using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для LongMarathon.xaml
    /// </summary>
    public partial class LongMarathon : Page
    {
        double formulaCount = (Math.Round(42f / 345f, 2)) * 60;
        double chervCount = (Math.Round(42f / 0.03f, 2)) * 60;
        double lenCount = (Math.Round(42f / 0.12f, 2)) * 60;
        double capybaraCount = (Math.Round(42f / 35f, 2)) * 60;
        double yagaCount = (Math.Round(42f / 80f, 2)) * 60;
        double flyCount = Math.Ceiling(42f / (73f / 1000));
        double slanciCount = Math.Ceiling(42f / (0.245f / 1000));
        double footballCount = Math.Ceiling(42f / (105f / 1000));
        double ronCount = Math.Ceiling(42f / (1.81f / 1000));
        double busCount = Math.Ceiling(42f / (10f / 1000));
        public LongMarathon()
        {
            InitializeComponent();
            imageBox.Source = new BitmapImage(new Uri("Resource/f1-car.jpg", UriKind.Relative));
            Formula.Source = new BitmapImage(new Uri("Resource/f1-car.jpg", UriKind.Relative));
            Cherv.Source = new BitmapImage(new Uri("Resource/worm.jpg", UriKind.Relative));
            Len.Source = new BitmapImage(new Uri("Resource/sloth.jpg", UriKind.Relative));
            Capibara.Source = new BitmapImage(new Uri("Resource/capybara.jpg", UriKind.Relative));
            Yaga.Source = new BitmapImage(new Uri("Resource/jaguar.jpg", UriKind.Relative));
            Fly.Source = new BitmapImage(new Uri("Resource/airbus-a380.jpg", UriKind.Relative));
            Slanci.Source = new BitmapImage(new Uri("Resource/pair-of-havaianas.jpg", UriKind.Relative));
            FootbalStadium.Source = new BitmapImage(new Uri("Resource/football-field.jpg", UriKind.Relative));
            Ron.Source = new BitmapImage(new Uri("Resource/ronaldinho.jpg", UriKind.Relative));
            Bus.Source = new BitmapImage(new Uri("Resource/bus.jpg", UriKind.Relative));
            Description.Text = "Формула 1";
            Name.Text = "Максимальная скорость машины формулы 1 345 км/ч. Это займет " + formulaCount + " мин. чтобы завершить 42 км. марафон";
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void FlyClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/airbus-a380.jpg", UriKind.Relative));
            Description.Text = "Самолет";
            Name.Text = "Длина Авиалайнера А380 73 м. Это займет " + flyCount + " шт. из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void SlanciClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/pair-of-havaianas.jpg", UriKind.Relative));
            Description.Text = "Сланцы";
            Name.Text = "Длина Сланцев 0.245 м. Это займет " + slanciCount + " шт. из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void FootbalStadiumClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/pair-of-havaianas.jpg", UriKind.Relative));
            Description.Text = "Футбольное поле";
            Name.Text = "Длина Сланцев 0.245 м. Это займет " + footballCount + " шт. из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void RonClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/ronaldinho.jpg", UriKind.Relative));
            Description.Text = "Рональдиньо";
            Name.Text = "Рост Роналдиньо 1.81 м. Это займет " + ronCount + " шт. из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void BusClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/bus.jpg", UriKind.Relative));
            Description.Text = "Автобус";
            Name.Text = "Длина Автобуса 10 м. Это займет " + busCount + " шт. из них, чтобы покрыть расстояние в 42 км марафона";
        }

        private void FormulaClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/f1-car.jpg", UriKind.Relative));
            Description.Text = "Формула 1";
            Name.Text = "Максимальная скорость машины формулы 1 345 км/ч. Это займет " + formulaCount + " мин. чтобы завершить 42 км. марафон";
        }

        private void ChervClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/worm.jpg", UriKind.Relative));
            Description.Text = "Червь";
            Name.Text = "Максимальная скорость Червя 0.03 км/ч. Это займет " + chervCount + " мин. чтобы завершить 42 км марафон.";
        }

        private void LenClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/sloth.jpg", UriKind.Relative));
            Description.Text = "Ленивец";
            Name.Text = "Максимальная скорость Ленивца 0.12 км / ч.Это займет " + lenCount + " мин. чтобы завершить 42 км марафон.";
        }

        private void CapibaraClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/capybara.jpg", UriKind.Relative));
            Description.Text = "Капибара";
            Name.Text = "Максимальная скорость Капибары 35 км/ч. Это займет " + capybaraCount + " мин. чтобы завершить 42 км марафон.";
        }

        private void YagaClick(object sender, RoutedEventArgs e)
        {
            imageBox.Source = new BitmapImage(new Uri("Resource/jaguar.jpg", UriKind.Relative));
            Description.Text = "Ягуар";
            Name.Text = "Максимальная скорость Ягуара 80 км/ч. Это займет " + yagaCount + " мин. чтобы завершить 42 км марафон.";
        }
    }
}
