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
    /// Логика взаимодействия для Master.xaml
    /// </summary>
    public partial class Master : Window
    {
        DbController dBController = new DbController();
        user i = new user();
        izdelia izdelia;
        zakaz zaka;
        public static tochnokursachEntities db { get; set; }
        private bool isDirty = true;
        public Master(user userActive)
        {
            InitializeComponent();
            DataMaster.ItemsSource = DbController.POdtmaster(userActive);
            DataProizv.ItemsSource = DbController.Oplachen(userActive);
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
            if (propertyDescriptor.DisplayName == "izdelia")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "izdelia_idizdelia")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "user")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "idzakaz")
            {
                e.Cancel = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы  точно хотите изменить ?", "Проверьте", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.No || result == MessageBoxResult.Cancel)
            { }
            else
            {
                if (edit.Text == "Отклонен" || edit.Text == "отклонен" || edit.Text == "Закупка" || edit.Text == "закупка")
                {
                    
                   
                    string s = edit.Text;
                    zakaz zakaz = DbController.koko(int.Parse(s));
                    zakaz.name = s;
                     DbController.save();
                    DataMaster.ItemsSource = DbController.POdtmaster(i);
                }
                else
                    MessageBox.Show("Можно изменять только на " + "Отклонен или Закупка", "Повторите ввод");
            }
        }
       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mat = new MainWindow();
            mat.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Mater mat = new Mater(i);
            mat.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var selectedCell = DataMaster.SelectedCells[0];
            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            if (cellContent is TextBlock)
            {
                edit.Text = (cellContent as TextBlock).Text;
            }
        }
    }
}
