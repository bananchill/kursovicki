using FurnitureFactory.Forms;
using FurnitureFactory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FurnitureFactory
{
    public partial class FormMain : Form
    {
        User userActive = null;
        FFContext db;
        string login;
        string password;
        public FormMain()
        {
            db = new FFContext();
            db.Material.Load();
            InitializeComponent();

            

        }

        private void ManagerGridView()
        {
            var order = db.Order.Where(c => c.status == "Новый" || c.Manager.IdUser == userActive.IdUser).Select(c => new
            {
                IdOrder = c.IdOrder,
                Date = c.Date,
                Name = c.Name,
                Product = c.Product.Name,
                Manager = c.Manager.FIO,
                User = c.User.FIO,
                Price = c.Price,
                EndDate = c.EndDate,
                Status = c.status            
            });
            dataGridViewOrders.DataSource = order.ToList();
        }
        private void OrdererGridView()
        {
            var order = db.Order.Where(c => c.User.IdUser == userActive.IdUser).Select(c => new
            {
                IdOrder = c.IdOrder,
                Date = c.Date,
                Name = c.Name,
                Product = c.Product.Name,
                Manager = c.Manager.FIO,
                User = c.User.FIO,
                Price = c.Price,
                EndDate = c.EndDate,
                Status = c.status
            });
            dataGridViewOrders.DataSource = order.ToList();
        }
        private void MasterGridView()
        {
            var order = db.Order.Where(c => c.status == "Производство" || c.status == "Контроль").Select(c => new
            {
                IdOrder = c.IdOrder,
                Date = c.Date,
                Name = c.Name,
                Product = c.Product.Name,
                Manager = c.Manager.FIO,
                User = c.User.FIO,
                Price = c.Price,
                EndDate = c.EndDate,
                Status = c.status
            });
            dataGridViewOrders.DataSource = order.ToList();
        }
        private void BossGridView()
        {
            var order = db.Order.Select(c => new
            {
                IdOrder = c.IdOrder,
                Date = c.Date,
                Name = c.Name,
                Product = c.Product.Name,
                Manager = c.Manager.FIO,
                User = c.User.FIO,
                Price = c.Price,
                EndDate = c.EndDate,
                Status = c.status
            });
            dataGridViewOrders.DataSource = order.ToList();
        }
        private void AlmostBossGridView()
        {
            var order = db.Order.Where(c => c.status == "Закупка" || c.status == "Составление спецификации").Select(c => new
            {
                IdOrder = c.IdOrder,
                Date = c.Date,
                Name = c.Name,
                Product = c.Product.Name,
                Manager = c.Manager.FIO,
                User = c.User.FIO,
                Price = c.Price,
                EndDate = c.EndDate,
                Status = c.status
            });
            dataGridViewOrders.DataSource = order.ToList();
        }

        private void UpdateGrid()
        {
            //заказчик
            if (userActive.Role == "Заказчик")
            {
                buttonAcceptOrder.Enabled = false;
                buttonEndOrder.Enabled = false;
                buttonProcessOrder.Enabled = false;
                AcceptOrderButton.Enabled = false;

                buttonSprav.Enabled = false;
                OrdererGridView();
            }

            //Мастер

            else if (userActive.Role == "Мастер")
            {
                buttonAcceptOrder.Enabled = false;
                buttonEndOrder.Enabled = false;
                buttonAddOrder.Enabled = false;
                buttonCancelOrder.Enabled = false;
                buttonDeleteOrder.Enabled = false;
                AcceptOrderButton.Enabled = false;

                MasterGridView();

            }

            //директор


            else if (userActive.Role == "Директор")
            {
                buttonAddOrder.Enabled = false;
                buttonAcceptOrder.Enabled = false;
                buttonEndOrder.Enabled = false;
                buttonCancelOrder.Enabled = false;
                buttonDeleteOrder.Enabled = false;
                AcceptOrderButton.Enabled = false;
                buttonProcessOrder.Enabled = false;
                BossGridView();
            }

            //зам


            else if (userActive.Role == "Заместитель директора")
            {
                buttonAddOrder.Enabled = false;
                buttonAcceptOrder.Enabled = false;
                buttonEndOrder.Enabled = false;
                buttonCancelOrder.Enabled = false;
                buttonDeleteOrder.Enabled = false;
                AlmostBossGridView();
            }

            //менеджер


            else if (userActive.Role == "Менеджер")
            {
                buttonDeleteOrder.Enabled = false;
                AcceptOrderButton.Enabled = false;
                ManagerGridView();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            


            int count = 0;
            while (count < 3 && userActive == null)
            {
                LoginForm authorization = new LoginForm();
                DialogResult result = authorization.ShowDialog();
                if (result != DialogResult.OK) Application.Exit();
                login = authorization.textBoxLogin.Text;
                password = authorization.textBoxPassword.Text;

                userActive = DBController.LoggedUser(login, password);

                if (userActive == null)
                    MessageBox.Show("Не верный пароль/логин", "Повторите ввод!");

                count++;
            }
            if (userActive == null)
            {
                MessageBox.Show("Не верный логин/пароль!", "Повторите вход!");
                Application.Exit();
            }
            // название формы по имени и роли
            this.Text = "Добро пожаловать, " + userActive.Role + " " + userActive.FIO;

            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEndOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            int idOrder = 0;
            bool converted = Int32.TryParse(dataGridViewOrders[0, index].Value.ToString(), out idOrder);
            Order order = db.Order.Find(idOrder);

            if (order.status != "Готов")
            {
                MessageBox.Show("Вы не можете завершить этот заказ");
                return;
            }
            order.status = "Завершен";
            db.SaveChanges();
            MessageBox.Show("Заказ успешно завершен");
            UpdateGrid();
        }

        private void buttonAcceptOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            int idOrder = 0;
            bool converted = Int32.TryParse(dataGridViewOrders[0, index].Value.ToString(), out idOrder);
            Order order = db.Order.Find(idOrder);

            if (order.status != "Новый")
            {
                MessageBox.Show("Вы не можете взять этот заказ");
                return;
            }

            order.status = "Составление спецификации";

            List<User> mainuser = db.User.ToList();
            foreach (var u in mainuser)
            {
                if (u.IdUser == userActive.IdUser)
                    order.Manager = u;

            }
            db.SaveChanges();
            MessageBox.Show("Заказ успешно принят");
            UpdateGrid();
        }

        private void buttonCancelOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            int idOrder = 0;
            bool converted = Int32.TryParse(dataGridViewOrders[0, index].Value.ToString(), out idOrder);
            Order order = db.Order.Find(idOrder);

            if (userActive.Role == "Менеджер")
            {
                if (order.status != "Новый" && order.status != "Подтверждение")
                {
                    MessageBox.Show("Вы не можете отменить этот заказ");
                    return;
                }
            } else if (userActive.Role == "Заказчик")
            {
                if (order.status != "Новый" && order.status != "Составление спецификации" && order.status != "Подтверждение")
                {
                    MessageBox.Show("Вы не можете отменить этот заказ");
                    return;
                }
            }
            order.status = "Отменен";
            db.SaveChanges();
            MessageBox.Show("Заказ успешно отменен");
            UpdateGrid();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm();

            if (userActive.Role == "Менеджер")
            {
                var user = db.User.Where(c => c.Role == "заказчик");

                List<User> users = user.ToList();
                newOrderForm.comboBoxOrderer.DataSource = users;
                newOrderForm.comboBoxOrderer.DisplayMember = "FIO";

                DialogResult dialogResult = newOrderForm.ShowDialog();
                if (dialogResult == DialogResult.Cancel) return;
            } else
            {
                newOrderForm.comboBoxOrderer.Enabled = false;

                DialogResult dialogResult = newOrderForm.ShowDialog();
                if (dialogResult == DialogResult.Cancel) return;
            }

            if (newOrderForm.textBoxName.Text != "" && newOrderForm.textBoxSize.Text != "")
            {


                Order order = new Order();

                if (userActive.Role == "Менеджер")
                {
                    List<User> mainuser = db.User.ToList();
                    foreach (var u in mainuser)
                    {
                        if (u.IdUser == userActive.IdUser)
                            order.Manager = u;

                    }

                    //order.Manager = DBController.FindUser(userActive.IdUser);
                    order.Name = newOrderForm.textBoxName.Text;

                    Product product = new Product();

                    product.Name = newOrderForm.textBoxName.Text;
                    product.Size = newOrderForm.textBoxSize.Text;

                    order.Product = product;
                    order.Date = newOrderForm.dateTimePickerOrder.Value.Date;
                    order.status = "Составление спецификации";

                    order.User = (User)newOrderForm.comboBoxOrderer.SelectedItem;
                } else
                {
                    order.Name = newOrderForm.textBoxName.Text;

                    Product product = new Product();

                    product.Name = newOrderForm.textBoxName.Text;
                    product.Size = newOrderForm.textBoxSize.Text;

                    order.Product = product;
                    order.Date = newOrderForm.dateTimePickerOrder.Value.Date;
                    order.status = "Новый";

                    List<User> mainuser = db.User.ToList();
                    foreach (var u in mainuser)
                    {
                        if (u.IdUser == userActive.IdUser)
                            order.User = u;

                    }
                }

                db.Order.Add(order);
                db.SaveChanges();

                MessageBox.Show("готово");
            } else
            {
                MessageBox.Show("заполните все поля");
            }
            UpdateGrid();
        }

        private void buttonProcessOrder_Click(object sender, EventArgs e)
        {
            ChangeStatusForm changeStatusForm = new ChangeStatusForm();
            if (userActive.Role == "Директор")
            {
                changeStatusForm.comboBox1.Items.Add("Новый");
                changeStatusForm.comboBox1.Items.Add("Отменен");
                changeStatusForm.comboBox1.Items.Add("Составление спецификации");
                changeStatusForm.comboBox1.Items.Add("Подтверждение");
                changeStatusForm.comboBox1.Items.Add("Закупка");
                changeStatusForm.comboBox1.Items.Add("Производство");
                changeStatusForm.comboBox1.Items.Add("Контроль");
                changeStatusForm.comboBox1.Items.Add("Готов");
                changeStatusForm.comboBox1.Items.Add("Завершен");
                changeStatusForm.comboBox1.SelectedIndex = 0;
            }
            else if (userActive.Role == "Заместитель директора")
            {
                changeStatusForm.comboBox1.Items.Add("Производство");
                changeStatusForm.comboBox1.SelectedIndex = 0;
            }
            else if (userActive.Role == "Мастер")
            {
                changeStatusForm.comboBox1.Items.Add("Контроль");
                changeStatusForm.comboBox1.Items.Add("Готов");
                changeStatusForm.comboBox1.SelectedIndex = 0;
            }
            else if (userActive.Role == "Менеджер")
            {
                changeStatusForm.comboBox1.Items.Add("Закупка");
                changeStatusForm.comboBox1.SelectedIndex = 0;
            }

            DialogResult dialogResult = changeStatusForm.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;

            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            int idOrder = 0;
            bool converted = Int32.TryParse(dataGridViewOrders[0, index].Value.ToString(), out idOrder);
            Order order = db.Order.Find(idOrder);

            if (order.status != "Закупка" && userActive.Role == "Заместитель директора")
            {
                MessageBox.Show("Вы не можете поменять статус этого заказа");
                return;
            } 
            else if (order.status != "Производство" && userActive.Role == "Мастер")
                {
                    MessageBox.Show("Вы не можете поменять статус этого заказа");
                    return;
                }
            else if (order.status != "Подтверждение" && userActive.Role == "Менеджер")
            {
                MessageBox.Show("Вы не можете поменять статус этого заказа");
                return;
            }

            order.status = changeStatusForm.comboBox1.SelectedItem.ToString();
            db.SaveChanges();
            MessageBox.Show("Статус заказа успешно изменен");
            UpdateGrid();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            int idOrder = 0;
            bool converted = Int32.TryParse(dataGridViewOrders[0, index].Value.ToString(), out idOrder);
            Order order = db.Order.Find(idOrder);

            if (order.status != "Новый")
            {
                MessageBox.Show("Вы не можете удалить этот заказ");
                return;
            }
            db.Order.Remove(order);
            db.SaveChanges();
            MessageBox.Show("Заказ успешно удален");
            UpdateGrid();
        }

        private void AcceptOrderButton_Click(object sender, EventArgs e)
        {
            AcceptOrderForm changeOrderForm = new AcceptOrderForm();

            DialogResult dialogResult = changeOrderForm.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;

            if (dataGridViewOrders.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewOrders.SelectedRows[0].Index;
            int idOrder = 0;
            bool converted = Int32.TryParse(dataGridViewOrders[0, index].Value.ToString(), out idOrder);
            Order order = db.Order.Find(idOrder);

            if (order.status != "Составление спецификации")
            {
                MessageBox.Show("Вы не можете поддтвердить этот заказ");
                return;
            }

            order.Price = (int)changeOrderForm.PriceTextBox.Value;
            order.EndDate = changeOrderForm.dateTimePickerEnd.Value.Date;
            order.status = "Подтверждение";
            db.SaveChanges();
            MessageBox.Show("Заказ успешно подтвержден");
            UpdateGrid();
        }

        private void buttonSprav_Click(object sender, EventArgs e)
        {
            FurnitureForm furnitureForm = new FurnitureForm(userActive);
            DialogResult dialogResult = furnitureForm.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            db.SaveChanges();
        }
    }
}
