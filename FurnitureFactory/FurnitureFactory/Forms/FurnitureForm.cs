using FurnitureFactory.Forms;
using FurnitureFactory.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace FurnitureFactory.Forms
{
    public partial class FurnitureForm : Form
    {
        FFContext db;
        User userActive = null;
        public FurnitureForm(User userActive)
        {
            db = new FFContext();
            db.Material.Load();
            db.Furniture.Load();
            db.Provider.Load();
            InitializeComponent();
            if (userActive.Role == "Менеджер" || userActive.Role == "Мастер")
            {
                DeleteFur.Enabled = false;
                DeleteMat.Enabled = false;
                DeleteProv.Enabled = false;
                EditFur.Enabled = false;
                EditMat.Enabled = false;
                EditProv.Enabled = false;
            }
            LoadData();
        }
        public void LoadData()
        {
            var material = db.Material.Select(c => new
            {
                id = c.IdMaterial,
                name = c.Name,
                unit = c.Unit,
                length = c.Length,
                count = c.Count,
                provider = c.Provider.Name,
                price = c.Price,
                gost = c.GOST,
                cha = c.characteristic
            });
            dataGridViewMat.DataSource = material.ToList();

            var provider = db.Provider.Select(c => new
            {
                id = c.IdUser,
                name = c.Name,
                address = c.Address,
                date = c.Date
            });
            dataGridViewProv.DataSource = provider.ToList();

            var furniture = db.Furniture.Select(c => new
            {
                id = c.IdFurniture,
                name = c.Name,
                unit = c.Unit,
                count = c.Count,
                provider = c.Provider.Name,
                type = c.Type,
                price = c.Price,
                weight = c.Weight
            });
            dataGridViewFur.DataSource = furniture.ToList();
        }

        private void DeleteFur_Click(object sender, EventArgs e)
        {
            if (dataGridViewFur.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewFur.SelectedRows[0].Index;
            int idFur = 0;
            bool converted = Int32.TryParse(dataGridViewFur[0, index].Value.ToString(), out idFur);
            Furniture fur = db.Furniture.Find(idFur);

            var result = MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            db.Furniture.Remove(fur);
            db.SaveChanges();
            MessageBox.Show("Фурнитура успешно удалена");
            LoadData();
        }

        private void EditFur_Click(object sender, EventArgs e)
        {
            EditFurForm editFurForm = new EditFurForm();

            List<Provider> providers = db.Provider.ToList();
            editFurForm.comboBoxProv.DataSource = providers;
            editFurForm.comboBoxProv.DisplayMember = "Name";

            if (dataGridViewFur.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewFur.SelectedRows[0].Index;
            int idFur = 0;
            bool converted = Int32.TryParse(dataGridViewFur[0, index].Value.ToString(), out idFur);
            Furniture fur = db.Furniture.Find(idFur);

            editFurForm.textBoxName.Text = fur.Name;
            editFurForm.textBoxEd.Text = fur.Unit;
            editFurForm.TextBoxCount.Value = fur.Count;
            editFurForm.textBoxType.Text = fur.Type;
            editFurForm.TextBoxPrice.Value = new decimal((float)fur.Price);
            editFurForm.TextBoxWeight.Value = fur.Weight;

            DialogResult dialogResult = editFurForm.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;

            fur.Name = editFurForm.textBoxName.Text;
            fur.Unit = editFurForm.textBoxEd.Text;
            fur.Count = (int)editFurForm.TextBoxCount.Value;
            fur.Type = editFurForm.textBoxType.Text;
            fur.Price = (float)editFurForm.TextBoxPrice.Value;
            fur.Weight = (int)editFurForm.TextBoxWeight.Value;
            fur.Provider = (Provider)editFurForm.comboBoxProv.SelectedItem;

            db.SaveChanges();
            MessageBox.Show("Фурнитура успешно изменена");
            LoadData();

        }

        private void DeleteProv_Click(object sender, EventArgs e)
        {
            if (dataGridViewProv.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewProv.SelectedRows[0].Index;
            int idProv = 0;
            bool converted = Int32.TryParse(dataGridViewProv[0, index].Value.ToString(), out idProv);
            Provider prov = db.Provider.Find(idProv);

            var result = MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            db.Provider.Remove(prov);
            db.SaveChanges();
            MessageBox.Show("Поставщик успешно удален");
            LoadData();
        }

        private void EditProv_Click(object sender, EventArgs e)
        {
            EditProvForm editProvForm = new EditProvForm();

            if (dataGridViewProv.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewProv.SelectedRows[0].Index;
            int idProv = 0;
            bool converted = Int32.TryParse(dataGridViewProv[0, index].Value.ToString(), out idProv);
            Provider fur = db.Provider.Find(idProv);

            editProvForm.textBoxName.Text = fur.Name;
            editProvForm.textBoxEd.Text = fur.Address;
            editProvForm.dateTimePicker1.Value = fur.Date;

            DialogResult dialogResult = editProvForm.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;

            fur.Name = editProvForm.textBoxName.Text;
            fur.Address = editProvForm.textBoxEd.Text;
            fur.Date = editProvForm.dateTimePicker1.Value.Date;

            db.SaveChanges();
            MessageBox.Show("Поставщик успешно изменен");
            LoadData();
        }

        private void DeleteMat_Click(object sender, EventArgs e)
        {
            if (dataGridViewMat.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewMat.SelectedRows[0].Index;
            int idMat = 0;
            bool converted = Int32.TryParse(dataGridViewMat[0, index].Value.ToString(), out idMat);
            Material mat = db.Material.Find(idMat);

            var result = MessageBox.Show("Вы уверены, что хотите удалить?", "Внимание",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            db.Material.Remove(mat);
            db.SaveChanges();
            MessageBox.Show("Поставщик успешно удален");
            LoadData();
        }

        private void EditMat_Click(object sender, EventArgs e)
        {
            EditMatForm editMatForm = new EditMatForm();

            List<Provider> providers = db.Provider.ToList();
            editMatForm.comboBoxProv.DataSource = providers;
            editMatForm.comboBoxProv.DisplayMember = "Name";

            if (dataGridViewMat.SelectedRows.Count <= 0)
            {
                return;
            }
            int index = dataGridViewMat.SelectedRows[0].Index;
            int idFur = 0;
            bool converted = Int32.TryParse(dataGridViewMat[0, index].Value.ToString(), out idFur);
            Material fur = db.Material.Find(idFur);

            editMatForm.textBoxName.Text = fur.Name;
            editMatForm.textBoxEd.Text = fur.Unit;
            editMatForm.TextBoxCount.Value = fur.Count;
            editMatForm.TextBoxLenght.Value = fur.Length;
            editMatForm.TextBoxPrice.Value = new decimal((int)fur.Price);
            editMatForm.textBoxGost.Text = fur.GOST;
            editMatForm.textBoxChar.Text = fur.characteristic;

            DialogResult dialogResult = editMatForm.ShowDialog();
            if (dialogResult == DialogResult.Cancel) return;

            fur.Name = editMatForm.textBoxName.Text;
            fur.Unit = editMatForm.textBoxEd.Text;
            fur.Count = (int)editMatForm.TextBoxCount.Value;
            fur.Length = (int)editMatForm.TextBoxLenght.Value;
            fur.Price = (int)editMatForm.TextBoxPrice.Value;
            fur.GOST = editMatForm.textBoxGost.Text;
            fur.characteristic = editMatForm.textBoxChar.Text;
            fur.Provider = (Provider)editMatForm.comboBoxProv.SelectedItem;

            db.SaveChanges();
            MessageBox.Show("Материал успешно изменен");
            LoadData();
        }
    }
}
