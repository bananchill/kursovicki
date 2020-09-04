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
    /// Логика взаимодействия для ZamDirectora.xaml
    /// </summary>
    public partial class ZamDirectora : Window
    {
        DbController dBController = new DbController();
        user i = new user();
        izdelia izdelia;
        zakaz zaka;
        public static tochnokursachEntities db { get; set; }
        private bool isDirty = true;
        public ZamDirectora(user userActive)
        {
            InitializeComponent();
            DataZakupka.ItemsSource = DbController.Zakupka(userActive);
            DataProizv.ItemsSource = DbController.Proizv(userActive);
            
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;

            if (propertyDescriptor.DisplayName == "idzakaz")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "shemi")
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
            if (propertyDescriptor.DisplayName == "izdelia_idizdelia")
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int k = 0;
            Material mat = new Material(i,k);
            mat.Show();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mat = new MainWindow();

            mat.Show();
            this.Close();
        }
    }
}
