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
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        DbController dBController = new DbController();
        user i = new user();
        izdelia izdelia;
        zakaz zaka;
        public static tochnokursachEntities db { get; set; }
        private bool isDirty = true;
        public Manager(user userActive)
        {
            InitializeComponent();


            DataNew.ItemsSource = DbController.Newzakaz(userActive);
            DataPodt.ItemsSource = DbController.Podtzakaz(userActive);
            Oplachengrid.ItemsSource = DbController.Oplachen(userActive);
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
            if (propertyDescriptor.DisplayName == "user")
            {
                e.Cancel = true;
            }
            if (propertyDescriptor.DisplayName == "izdelia_idizdelia")
            {
                e.Cancel = true;
            }

        }
       
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы  точно хотите изменить ?", "Проверьте", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.No || result == MessageBoxResult.Cancel)
            { }  
            else
            {
                if (edit.Text == "Отклонен" || edit.Text == "Закупка")
                {
                    string id = null;
                    var selectedCell = DataPodt.SelectedCells[0];
                    var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
                    if (cellContent is TextBlock)
                    {
                        id = (cellContent as TextBlock).Text;

                    }
                    string s = edit.Text;
                    zakaz zakaz = DbController.kaka(int.Parse(id));
                    zakaz.name = s;

                    DbController.save();
                    DataPodt.ItemsSource = DbController.Podtzakaz(i);
                }
                else
                    MessageBox.Show("Можно изменять только на " + "Отклонен или Закупка", "Повторите ввод");
            }
        }

        private void DataPodt_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
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

        private void Editoplacheno_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы  точно хотите изменить ?", "Проверьте", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.No || result == MessageBoxResult.Cancel)
            { }
            else
            {
                if (oplacheno.Text == "Завершен" || edit.Text == "завершен")
                {
                    string s = oplacheno.Text;
                    zakaz zakaz = DbController.toto(int.Parse(s));
                    zakaz.name = s;
                    DbController.save();
                    Oplachengrid.ItemsSource = DbController.Oplachen(i);
                }
                else
                    MessageBox.Show("Можно изменять только на "+ "Завершен", "Повторите ввод");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mater mat = new Mater(i);
            mat.Show();
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
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var selectedCell = DataPodt.SelectedCells[2];
            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            if (cellContent is TextBlock )
            {
                edit.Text = (cellContent as TextBlock).Text;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var selectedCell = Oplachengrid.SelectedCells[1];
            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            if (cellContent is TextBlock)
            {
                oplacheno.Text = (cellContent as TextBlock).Text;
            }
        }
    }
}
