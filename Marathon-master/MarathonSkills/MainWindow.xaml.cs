using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;

namespace MarathonSkills
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string Time
        {
            get
            {
                DateTime dateTime1 = DateTime.Now;
                DateTime dateTime2 = DateTime.Parse("2016-10-21 6:00");
                TimeSpan timeSpan = dateTime2 - dateTime1;

                return string.Format("{0} дней {1} часов {2} минут до старта марафона!", timeSpan.Days, timeSpan.Hours, timeSpan.Seconds);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Window_Loaded(object sender, RoutedEvent e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;

            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PropertyChange("Time");
        }

        private void PropertyChange(string name)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
