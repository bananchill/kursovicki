using FurnitureFactory.Forms;
using FurnitureFactory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FurnitureFactory.Forms
{
    public partial class NewOrdederForm : Form
    {
        FFContext db;
        public NewOrdederForm()
        {
            db = new FFContext();
            db.User.Load();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPass.Text != "" && textBoxfio.Text != "")
            {
                User newUser = new User { Login = textBoxLogin.Text, Password = textBoxPass.Text, FIO = textBoxfio.Text, Role = "Заказчик" };
                db.User.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Новый заказчик добавлен.");
                this.Close();
            } else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }
    }
}
