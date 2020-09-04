using FurnitureFactory.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace FurnitureFactory.Forms
{
    public partial class NewOrderForm : Form
    {

        User userActive = null;
        FFContext db;
        public NewOrderForm()
        {
            db = new FFContext();
            db.Material.Load();
            InitializeComponent();
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
