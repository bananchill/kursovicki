using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для SponsorPage.xaml
    /// </summary>
    public partial class SponsorPage : Page
    {
        string runner;
        user userActive;
        DBController dBController;
        public SponsorPage()
        {
            dBController = new DBController();
            InitializeComponent();
            foreach (string runner in dBController.runner().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = runner;
                cmbRunner.Items.Add(item);
            }
        }

        private void ComboBox_Selected_Runner(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            runner = selectedItem.Content.ToString();
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            if (int.Parse(countMoney.Text) > 10)
            {
                countMoney.Text = (int.Parse(countMoney.Text) - 10).ToString();
                sum.Content = "$" + countMoney;
            }
            else countMoney.Text = 0.ToString();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            countMoney.Text = (int.Parse(countMoney.Text) + 10).ToString();
            sum.Content = "$" + countMoney;
        }

        private void Button_Click_Pay(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Length > 2 && Card.Text.Length > 3 && NumberCard.Text.Length == 16 && DayCard.Text.Length == 2 && YearCard.Text.Length == 4 && CVCCard.Text.Length == 3)
            {
                string[] mystring = runner.Split(' ');
                sponsorship sponsorship = new sponsorship();
                sponsorship.SponsorName = txtName.Text;
                sponsorship.RegistrationId = dBController.getIdRunner(int.Parse(mystring[0]));
                sponsorship.Amount = int.Parse(countMoney.Text);
                dBController.AddSponsorship(sponsorship);
                MessageBox.Show("Данные добавлены!");
                NavigationService.Navigate(new SponsorConfirm());
            }
            else
            {
                MessageBox.Show("Введите корректные данные!");
            }
        }

        private void Button_Click_Cancel(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Card_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0)) e.Handled = true;
            else { MessageBox.Show("Только буквы!"); }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
            else { MessageBox.Show("Только цифры!"); }
        }

        private void DayCard_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
            else { MessageBox.Show("Только цифры!"); }
        }

        private void YearCard_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
            else { MessageBox.Show("Только цифры!"); }
        }

        private void CVCCard_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
            else { MessageBox.Show("Только цифры!"); }
        }
    }
}
