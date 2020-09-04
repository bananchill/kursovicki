using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для MyResults.xaml
    /// </summary>
    public partial class MyResults : Page
    {
        runner runnerActive;
        DBController dBController;
        public MyResults(runner runnerActive)
        {
            dBController = new DBController();
            this.runnerActive = runnerActive;
            InitializeComponent();
            List<marathon> marathons = dBController.LoadMarathon();
            List<@event> events = dBController.LoadEvent();
            List<eventtype> eventTypes = dBController.LoadEventType();
            List<registrationevent> registrationEvents = dBController.LoadRegistrationEvent();
            List<registration> registrations = dBController.LoadRegistration();

            var result = from regev in registrationEvents
                         join reg in registrations on regev.RegistrationId equals reg.RegistrationId
                         join ev in events on regev.EventId equals ev.EventId
                         join evtype in eventTypes on ev.EventTypeId equals evtype.EventTypeId
                         join mr in marathons on ev.MarathonId equals mr.MarathonId
                         select new { Marathon = mr.MarathonName, Distance = ev.EventName + " " + evtype.EventTypeName, Time = regev.RaceTime, Runner = reg.RunnerId };
            var res = result.Where(r => r.Runner == runnerActive.RunnerId);

            registration registration = runnerActive.registration.SingleOrDefault();

            DateTime dt2 = DateTime.Parse("2020-01-01 00:00");
            if (registration.RegistrationDateTime.Year < dt2.Year)
            {
                dataGridView.DataContext = res.ToList();
                //dataGridView.Columns["Runner"].Visible = false;
            }
            else
            {
                System.Windows.MessageBox.Show("Вы еще не принимали участиве в марафонах!", "Вы новый участник", (MessageBoxButton)MessageBoxButtons.OK, (MessageBoxImage)MessageBoxIcon.Warning);
            }
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
        
        private void button_AllResults_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RaceResult());
        }
    }
}
