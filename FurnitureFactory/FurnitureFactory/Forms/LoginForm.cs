using FurnitureFactory.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurnitureFactory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewOrdederForm newOrdederForm = new NewOrdederForm();
            newOrdederForm.Show();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                CapchaForm capchaForm = new CapchaForm();
                DialogResult dialogResult = capchaForm.ShowDialog();
                if (dialogResult == DialogResult.OK && capchaForm.textBox1.Text == capchaForm.label2.Text)
                {
                    return;
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Вы неправильно ввели капчу");
                }
                if (i == 2)
                {
                    Application.Exit();
                }
            }
        }
    }
}
