using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для UserManagement.xaml
    /// </summary>
    public partial class UserManagement : Page
    {
        DBController dBController;
        
        string role = null, sort = null;
        user userActive;
        public UserManagement(user userActive)
        {
            this.userActive = userActive;
            InitializeComponent();
            dBController = new DBController();
            foreach (string role in dBController.role().ToArray())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = role;
                cmbRole.Items.Add(item);
            }
            List<string> list = new List<string>();
            list.Add("Все");
            list.Add("Имя");
            list.Add("Фамилия");
            foreach(string sort in list)
            {
                ComboBoxItem itemNew = new ComboBoxItem();
                itemNew.Content = sort;
                cmbSort.Items.Add(itemNew);
            }

            dataGridView.ItemsSource = dBController.UserGrid(userActive);
        }

        private void button_logout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void button_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNewUser(userActive));
        }

        private void button_Search_Click(object sender, RoutedEventArgs e)
        {
            string objectQuery = Search.Text;
            if (role.Equals("Все"))
            {
                switch (sort)
                {
                    case "Все":
                        dataGridView.ItemsSource = dBController.UserGrid(userActive);
                        if (objectQuery.Length > 0)
                        {
                            if (dBController.UserGridSearch(objectQuery).Count > 0)
                                dataGridView.ItemsSource = dBController.UserGridSearch(objectQuery);
                            else MessageBox.Show("Пользователя с таким именем, фамилией и Email не найден, повторите ввод!");
                        }
                        break;
                    case "Имя":
                        dataGridView.ItemsSource = dBController.sort("user.FirstName");
                        if (objectQuery.Length > 0)
                        {
                            if (dBController.UserGridSearch(objectQuery).Count > 0)
                                dataGridView.ItemsSource = dBController.UserGridSearch(objectQuery, "user.FirstName");
                            else MessageBox.Show("Пользователя с таким именем, фамилией и Email не найден, повторите ввод!");
                        }
                        break;
                    case "Фамилия":
                        dataGridView.ItemsSource = dBController.sort("user.LastName");
                        if (objectQuery.Length > 0)
                        {
                            if (dBController.UserGridSearch(objectQuery).Count > 0)
                                dataGridView.ItemsSource = dBController.UserGridSearch(objectQuery, "user.LastName");
                            else MessageBox.Show("Пользователя с таким именем, фамилией и Email не найден, повторите ввод!");
                        }
                        break;
                }
            }
            else
            {
                switch (sort)
                {
                    case "Все":
                        dataGridView.ItemsSource = dBController.sortRole(role);
                        if (objectQuery.Length > 0)
                        {
                            if (dBController.UserGridSearch(objectQuery).Count > 0)
                                dataGridView.ItemsSource = dBController.userGridSearch(objectQuery, role);
                            else MessageBox.Show("Пользователя с таким именем, фамилией и Email не найден, повторите ввод!");
                        }
                        break;
                    case "Имя":
                        dataGridView.ItemsSource = dBController.sortRole(role, "user.FirstName");
                        if (objectQuery.Length > 0)
                        {
                            if (dBController.UserGridSearch(objectQuery).Count > 0)
                                dataGridView.ItemsSource = dBController.UserGridSearch(objectQuery, "user.FirstName", role);
                            else MessageBox.Show("Пользователя с таким именем, фамилией и Email не найден, повторите ввод!");
                        }
                        break;
                    case "Фамилия":
                        dataGridView.ItemsSource = dBController.sortRole(role, "user.LastName");
                        if (objectQuery.Length > 0)
                        {
                            if (dBController.UserGridSearch(objectQuery).Count > 0)
                                dataGridView.ItemsSource = dBController.UserGridSearch(objectQuery, "user.LastName", role);
                            else MessageBox.Show("Пользователя с таким именем, фамилией и Email не найден, повторите ввод!");
                        }
                        break;
                }
            }
        }

        private void ComboBox_Selected_Role(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            role = selectedItem.Content.ToString();
        }
        private void ComboBox_Selected_Sort(object sender, RoutedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            sort = selectedItem.Content.ToString();
        }

        private void button_Click_Edit(object sender, RoutedEventArgs e)
        {
            var selectedCell = dataGridView.SelectedCells[2];
            var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);
            if (cellContent is TextBlock)
            {
                string email = (cellContent as TextBlock).Text;
                NavigationService.Navigate(new EditUser(dBController.getUser(email)));
            }
        }
    }
}
