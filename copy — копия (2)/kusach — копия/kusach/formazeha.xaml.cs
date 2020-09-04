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
    /// Логика взаимодействия для formazeha.xaml
    /// </summary>
    public partial class formazeha : Window
    {
        public formazeha()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Цех1");
            list.Add("Цех2");
            list.Add("Цех3");
            list.Add("Цех4");
            foreach (string zex in list)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = zex;
                combo.Items.Add(item);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (System.Windows.Controls.ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            if (selectedItem.Content.ToString().Equals("Цех1"))
            {
                foto.Opacity = 1;
                foto.Source = new BitmapImage(new Uri("source/1.png", UriKind.Relative));

            }
            else if (selectedItem.Content.ToString().Equals("Цех2"))
            {
                foto.Opacity = 1;
                foto.Source = new BitmapImage(new Uri("source/2.png", UriKind.Relative));
            }
            else if (selectedItem.Content.ToString().Equals("Цех3"))
            {
                foto.Opacity = 1;
                foto.Source = new BitmapImage(new Uri("source/3.png", UriKind.Relative));
            }
            else if (selectedItem.Content.ToString().Equals("Цех4"))
            {
                foto.Opacity = 1;
                foto.Source = new BitmapImage(new Uri("source/4.png", UriKind.Relative));
            }

        }
    }
}
