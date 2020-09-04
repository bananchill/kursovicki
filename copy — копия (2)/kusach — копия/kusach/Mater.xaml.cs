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
    /// Логика взаимодействия для Mater.xaml
    /// </summary>
    public partial class Mater : Window
    {
        DbController dBController = new DbController();
        user userActive = new user();
        public static tochnokursachEntities db { get; set; }
        private bool isDirty = true;
        izdelia zakaz;
        public Mater(user userActive)
        {
            InitializeComponent();
            Datamater.ItemsSource = DbController.Zakupkamater();
            Datafurn.ItemsSource = DbController.Zakupkafurn();
        }
        private void Datafurn_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            if (propertyDescriptor.DisplayName == "ves")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "specificmater")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "postavchikidpostavchik")
            {
                e.Cancel = true;
            }
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            if (propertyDescriptor.DisplayName == "izobr")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "specificmater")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "haracteristic")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "postavchikidpostavchik")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "specificfurniture")
            {
                e.Cancel = true;
            }
        }
       
    }
}
