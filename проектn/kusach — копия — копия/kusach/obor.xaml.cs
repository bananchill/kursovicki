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
    /// Логика взаимодействия для obor.xaml
    /// </summary>
    public partial class obor : Window
    {
        DbController dBController = new DbController();
        user userActive;
        izdelia izdelia;
        public static tochnokursachEntities db { get; set; }
        public obor(user userActive)
        {
            InitializeComponent();
            db = new tochnokursachEntities();

            Data.ItemsSource = DbController.oborud();
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;

            if (propertyDescriptor.DisplayName == "typeoborud_idtypeoborud")
            {
                e.Cancel = true;
            }


        }

    }
}
