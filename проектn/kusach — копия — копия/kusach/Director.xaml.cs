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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kusach
{
    /// <summary>
    /// Логика взаимодействия для Director.xaml
    /// </summary>
    public partial class Director : Window
    {
        DbController dBController = new DbController();
        user userActive = new user();
        izdelia izdelia;
        public static tochnokursachEntities db { get; set; }
        public Director(user user)
        {
            InitializeComponent();
            db = new tochnokursachEntities();

            Data.ItemsSource = DbController.Allzakaz();
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            if (propertyDescriptor.DisplayName == "shemi")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "user_iduser")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "izdeliaizdizdelia")
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            obor obo = new obor(userActive);
            obo.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int k = 1;
            Material obo = new Material(userActive,k);
            obo.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow obo = new MainWindow();
            obo.Show();
            this.Close();
        }
    }
}
