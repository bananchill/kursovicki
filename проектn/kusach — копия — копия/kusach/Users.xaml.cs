using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Window
    {
        DbController dBController = new DbController();
        user userActive;
        izdelia izdelia ;
        public static tochnokursachEntities db { get; set; }
        public Users(user userActive, izdelia izdelia)
        {
            InitializeComponent();
            db = new tochnokursachEntities();
            this.userActive = userActive;

            labelname.Content = userActive.namepat;

            DataZakaz.ItemsSource = DbController.ZAkazus(userActive, izdelia);
           
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            if (propertyDescriptor.DisplayName == "shemi" )
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "user_iduser")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "izdelia")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "user")
            {
                e.Cancel = true;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mater mat = new Mater(userActive);
            mat.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mat = new MainWindow();
            mat.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Addzakaz add = new Addzakaz();
            add.Show();
            this.Close();
        }
    }
}
