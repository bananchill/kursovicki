using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для EventRegister.xaml
    /// </summary>
    public partial class EventRegister : Page
    {
        string vznos = null;
        DBController dBController = new DBController();
        int lastSum = 0, radioSum;
        runner activeRunner;
        user activeUser;
        public EventRegister(user user, runner runner)
        {
            InitializeComponent();
            activeUser = user;
            activeRunner = runner;
            RadioButton rb = new RadioButton { IsChecked = true, Content = dBController.list("A"), Tag = "0" };
            rb.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb);
            RadioButton rb1 = new RadioButton { Content = dBController.list("B"), Tag = "20" };
            rb1.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb1);
            RadioButton rb2 = new RadioButton { Content = dBController.list("C"), Tag = "45" };
            rb2.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb2);

            foreach (string vznos in dBController.LoadCharity().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = vznos;
                comboVznos.Items.Add(item);
            }
        }

        public EventRegister(runner runner)
        {
            InitializeComponent();
            activeUser = runner.user;
            activeRunner = runner;
            RadioButton rb = new RadioButton { IsChecked = true, Content = dBController.list("A"), Tag = "0" };
            rb.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb);
            RadioButton rb1 = new RadioButton { Content = dBController.list("B"), Tag = "20" };
            rb1.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb1);
            RadioButton rb2 = new RadioButton { Content = dBController.list("C"), Tag = "45" };
            rb2.Checked += RadioButton_Checked;
            stackPanel.Children.Add(rb2);

            foreach (string vznos in dBController.LoadCharity().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = vznos;
                comboVznos.Items.Add(item);
            }
        }
        private void btnModal_Click(object sender, RoutedEventArgs e)
        {
            if(vznos == null)
            {
                MessageBox.Show("Вам необходимо выбрать организацию!");
            }
            else
            {
                var from = new CharityModal(vznos, dBController.getCharityDescription(vznos), dBController.getCharityPhoto(vznos));
                from.ShowDialog();
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            tbTotal.Text = (double.Parse(tbTotal.Text) - lastSum + double.Parse(pressed.Tag.ToString())).ToString();
            radioSum = int.Parse(pressed.Tag.ToString());
            lastSum = int.Parse(pressed.Tag.ToString());
        }

        private void ComboBox_Selected_Vznos(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            vznos = selectedItem.Content.ToString();
        }

        private void cbFullMarathon_Click(object sender, RoutedEventArgs e)
        {
            if (cbFullMarathon.IsChecked == true)
            {
                tbTotal.Text = (double.Parse(tbTotal.Text) + double.Parse((sender as CheckBox).Tag.ToString())).ToString();
            }
            else
            {
                tbTotal.Text = (double.Parse(tbTotal.Text) - double.Parse((sender as CheckBox).Tag.ToString())).ToString();
            }
        }

        private void cbHalfMarathon_Click(object sender, RoutedEventArgs e)
        {
            if (cbHalfMarathon.IsChecked == true)
            {
                tbTotal.Text = (double.Parse(tbTotal.Text) + double.Parse((sender as CheckBox).Tag.ToString())).ToString();
            }
            else
            {
                tbTotal.Text = (double.Parse(tbTotal.Text) - double.Parse((sender as CheckBox).Tag.ToString())).ToString();
            }
        }

        private void cbFunRun_Click(object sender, RoutedEventArgs e)
        {
            if (cbFunRun.IsChecked == true)
            {
                tbTotal.Text = (double.Parse(tbTotal.Text) + double.Parse((sender as CheckBox).Tag.ToString())).ToString();
            }
            else
            {
                tbTotal.Text = (double.Parse(tbTotal.Text) - double.Parse((sender as CheckBox).Tag.ToString())).ToString();
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

        private void Button_Click_Registred(object sender, RoutedEventArgs e)
        {
            if (double.Parse(txtCountVznos.Text) < 0 || double.Parse(txtCountVznos.Text) > int.MaxValue)
            {
                MessageBox.Show("Введите корректное число! Оно должно быть больше 0");
            }
            registration registration = new registration();
            registration.RunnerId = activeRunner.RunnerId;
            registration.RegistrationDateTime = DateTime.Now;

            if (radioSum == 0)
            {
                registration.RaceKitOptionId = 'A'.ToString();
            }
            if (radioSum == 20)
            {
                registration.RaceKitOptionId = 'B'.ToString();
            }
            if (radioSum == 45)
            {
                registration.RaceKitOptionId = 'C'.ToString();
            }
            registration.Cost = Decimal.Parse(tbTotal.Text);
            registration.RegistrationStatusId = 1;
            registration.CharityId = Int32.Parse(comboVznos.SelectedIndex.ToString());
            registration.SponsorshipTarget = Decimal.Parse(txtCountVznos.Text);
            dBController.AddRegistration(registration);

            registrationevent registrationEvent = new registrationevent();
            registrationEvent.RaceTime = null;
            registrationEvent.RegistrationId = registration.RegistrationId;

            if (cbFullMarathon.IsChecked == true)
            {
                int bibNumberFM = dBController.CountRegEventFM() + 1;
                registrationEvent.EventId = "20_2FM";
                registrationEvent.BibNumber = (short)bibNumberFM;
                dBController.AddRegistrationEvent(registrationEvent);
            }
            if (cbHalfMarathon.IsChecked == true)
            {
                int bibNumberHM = dBController.CountRegEventHM() + 1;
                registrationEvent.EventId = "20_2HM";
                registrationEvent.BibNumber = (short)bibNumberHM;
                dBController.AddRegistrationEvent(registrationEvent);
            }
            if (cbFunRun.IsChecked == true)
            {
                int bibNumberFR = dBController.CountRegEventFR() + 1;
                registrationEvent.EventId = "20_2FR";
                registrationEvent.BibNumber = (short)bibNumberFR;
                dBController.AddRegistrationEvent(registrationEvent);
            }

            NavigationService.Navigate(new RunnerRegisterConfirm(activeUser));
        }

        private void txtCountVznos_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
