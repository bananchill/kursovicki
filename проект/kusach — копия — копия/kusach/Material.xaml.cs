using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Material.xaml
    /// </summary>
    public partial class Material : Window
    { ObservableCollection<material> ListEmployee;
        ObservableCollection<furnitura> furn;
        DbController dBController = new DbController();
       
        user userActive = new user();
        izdelia izdelia;
        zakaz zaka;
        public static tochnokursachEntities db { get; set; }
        private bool isDirty = true;
        int l = 0;
        public Material(user userActive, int l)
        {
            InitializeComponent();
            Datamater.ItemsSource = DbController.Zakupkamater();
            Datafurn.ItemsSource = DbController.Zakupkafurn();

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
            if (propertyDescriptor.DisplayName == "postavshik_idpostavshik")
            {
                e.Cancel = true;
            }
        }

        private void Editmater(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Вы  точно хотите изменить ?", "Проверьте", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.No || result == MessageBoxResult.Cancel)
            { }
            else
            {
                if (articulbox.Text == "" || Boxname.Text == "" || countbox.Text == "" || typemater.Text == "")
                {
                    MessageBox.Show("Поля Артикула , названия , количества и типа материала должны быть заполнены");
                }
                else
                {
                    string s = articulbox.Text;
                    string k = Boxname.Text;
                    string l = izmerbox.Text;
                    string u = dlinabox.Text;
                    string y = countbox.Text;
                    string g = typemater.Text;
                    material material = DbController.kiki(s, k, l, u, y, g);
                    material.articul = s;
                    material.name = k;
                    material.izmered = l;
                    material.dlina = u;
                    material.count = y;
                    material.typemater = g;
                    DbController.save();
                    MessageBox.Show("Изменения внесены");
                }
            }

        }


        private void Vibor_Click(object sender, RoutedEventArgs e)
        {

            var selectedCell = Datamater.SelectedCells[1];
            var selectedCell2 = Datamater.SelectedCells[2];
            var selectedCell3 = Datamater.SelectedCells[3];
            var selectedCell4 = Datamater.SelectedCells[4];
            var selectedCell5 = Datamater.SelectedCells[5];
            var selectedCell6 = Datamater.SelectedCells[5];

            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            var cellContent2 = selectedCell2.Column.GetCellContent(selectedCell2.Item);
            var cellContent3 = selectedCell3.Column.GetCellContent(selectedCell3.Item);
            var cellContent4 = selectedCell4.Column.GetCellContent(selectedCell4.Item);
            var cellContent5 = selectedCell5.Column.GetCellContent(selectedCell5.Item);
            var cellContent6 = selectedCell6.Column.GetCellContent(selectedCell6.Item);

            if (cellContent is TextBlock && cellContent2 is TextBlock && cellContent3 is TextBlock && cellContent4 is TextBlock && cellContent5 is TextBlock && cellContent6 is TextBlock)
            {
                articulbox.Text = (cellContent as TextBlock).Text;
                Boxname.Text = (cellContent2 as TextBlock).Text;
                izmerbox.Text = (cellContent3 as TextBlock).Text;
                dlinabox.Text = (cellContent4 as TextBlock).Text;
                countbox.Text = (cellContent5 as TextBlock).Text;
                typemater.Text = (cellContent6 as TextBlock).Text;
            }


        }

        private void Deletemater(object sender, RoutedEventArgs e)
        {
            material emp = Datamater.SelectedItem as material;
            try
            {
                if (emp.count.Length == 0)
                {
                    if (emp != null)
                    {
                        MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить", "", MessageBoxButton.YesNoCancel);
                        if (result == MessageBoxResult.OK)
                        {

                            db.material.Remove(emp);
                            Datamater.SelectedIndex =
                                Datamater.SelectedIndex == 0 ? 1 : Datamater.SelectedIndex - 1;
                            ListEmployee.Remove(emp);
                            DbController.save();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Choose row");
                    }

                    isDirty = !true;
                }
                else
                    MessageBox.Show("Вы не можете удавлить этот продукт");
            }
            catch (Exception l)
            { MessageBox.Show("Выберите поле, которое хотите далить"); }
        }

        private void Editfurn(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы  точно хотите изменить ?", "Проверьте", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.No || result == MessageBoxResult.Cancel)
            { }
            else
            {
                if (articulbox.Text == "" || Boxname.Text == "" || countbox.Text == "" || typemater.Text == "")
                {
                    MessageBox.Show("Все поля должны быть заполнены");
                }
                else
                {
                    string s = furn1.Text;
                    string k = furn2.Text;
                    string l = furn3.Text;
                    string u = furn4.Text;
                    string y = furn5.Text;
                    string g = furn6.Text;
                    furnitura furnitura = DbController.klkl(s, k, l, u, y, g);
                    furnitura.articul = s;
                    furnitura.name = k;
                    furnitura.izmered = l;
                    furnitura.izmered = u;
                    furnitura.type = y;
                    furnitura.cost = g;
                    DbController.save();
                    MessageBox.Show("Изменения внесены");
                }
            }
        }

        private void Deletefurn(object sender, RoutedEventArgs e)
        {
            furnitura emp = Datafurn.SelectedItem as furnitura;
            try
            {
                if (emp != null)
                    {
                        MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить", "", MessageBoxButton.YesNoCancel);
                        if (result == MessageBoxResult.OK)
                        {
                            db.furnitura.Remove(emp);
                        Datafurn.SelectedIndex =
                                Datafurn.SelectedIndex == 0 ? 1 : Datamater.SelectedIndex - 1;
                            furn.Remove(emp);
                            DbController.save();

                        }
                    else
                    {
                        MessageBox.Show("Choose row");
                    }

                    isDirty = !true;
                }
                else
                    MessageBox.Show("Вы не можете удавлить этот продукт");
            }
            catch (Exception l)
            {
                MessageBox.Show("Выберите поле, которое хотите далить");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
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
            if (propertyDescriptor.DisplayName == "postavshik_idpostavshik")
            {
                e.Cancel = true;
            }
        }

        private void Vibor_furn_Click(object sender, RoutedEventArgs e)
        {
            var selectedCell = Datafurn.SelectedCells[1];
            var selectedCell2 = Datafurn.SelectedCells[2];
            var selectedCell3 = Datafurn.SelectedCells[3];
            var selectedCell4 = Datafurn.SelectedCells[4];
            var selectedCell5 = Datafurn.SelectedCells[5];
            var selectedCell6 = Datafurn.SelectedCells[5];

            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            var cellContent2 = selectedCell2.Column.GetCellContent(selectedCell2.Item);
            var cellContent3 = selectedCell3.Column.GetCellContent(selectedCell3.Item);
            var cellContent4 = selectedCell4.Column.GetCellContent(selectedCell4.Item);
            var cellContent5 = selectedCell5.Column.GetCellContent(selectedCell5.Item);
            var cellContent6 = selectedCell6.Column.GetCellContent(selectedCell6.Item);

            if (cellContent is TextBlock && cellContent2 is TextBlock && cellContent3 is TextBlock && cellContent4 is TextBlock && cellContent5 is TextBlock && cellContent6 is TextBlock)
            {
                furn1.Text = (cellContent as TextBlock).Text;
                furn2.Text = (cellContent2 as TextBlock).Text;
                furn3.Text = (cellContent3 as TextBlock).Text;
                furn4.Text = (cellContent4 as TextBlock).Text;
                furn5.Text = (cellContent5 as TextBlock).Text;
                furn6.Text = (cellContent6 as TextBlock).Text;
            }

        }
    }
}
