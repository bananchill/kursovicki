using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace kusach
{
    /// <summary>
    /// Логика взаимодействия для Addzakaz.xaml
    /// </summary>
    public partial class Addzakaz : Window
    {
        DbController dBController = new DbController();

        user userActive = new user();
        izdelia izdelia;
        zakaz zaka;
        public static tochnokursachEntities db { get; set; }
        private bool isDirty = true;
        public Addzakaz()
        {
            InitializeComponent();
            foreach (string roles in DbController.user().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = roles;
                numberzakaz.Items.Add(item);
            }
            //foreach (string roles in DbController.izd().ToArray())
            //{
            //    ComboBoxItem item = new ComboBoxItem();
            //    item.Content = roles;
            //    numberizd.Items.Add(item);
            //}
        }


       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            registr add = new registr();
            add.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                int days = 40;
                zakaz zakaz = new zakaz();
                izdelia izdelia = new izdelia();
                zakaz.user_iduser = int.Parse(numberzakaz.Text);
                zakaz.izdelia_idizdelia = int.Parse(haha.Text);
                zakaz.name = statusbox.Text;
                zakaz.cost = costbox.Text;
                zakaz.datestart = DateTime.Now;
                zakaz.datestart = DateTime.Now + new TimeSpan(days, 0, 0, 0);


                dBController.Addzakaz(zakaz);
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            catch (Exception l) {
                MessageBox.Show("Заполните все поля");
            }


        }
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            numberizd.ItemsSource = DbController.Loadizd();
            numberizd.SelectedValuePath = "izdelia";
            numberizd.SelectedIndex = 0;
            izdelia izdelia = numberizd.SelectedItem as izdelia;

            haha.Text = izdelia.idizdelia.ToString();
            
        }

        private void Numberizd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            izdelia izdelia = numberizd.SelectedItem as izdelia;

            haha.Text = izdelia.idizdelia.ToString();
            
        }
    }
}
