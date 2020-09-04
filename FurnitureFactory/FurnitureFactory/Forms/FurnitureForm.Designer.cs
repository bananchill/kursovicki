namespace FurnitureFactory.Forms
{
    partial class FurnitureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewFur = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EditFur = new System.Windows.Forms.Button();
            this.DeleteFur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EditProv = new System.Windows.Forms.Button();
            this.DeleteProv = new System.Windows.Forms.Button();
            this.dataGridViewProv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EditMat = new System.Windows.Forms.Button();
            this.dataGridViewMat = new System.Windows.Forms.DataGridView();
            this.DeleteMat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFur)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFur
            // 
            this.dataGridViewFur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFur.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFur.Name = "dataGridViewFur";
            this.dataGridViewFur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFur.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewFur.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditFur);
            this.groupBox1.Controls.Add(this.DeleteFur);
            this.groupBox1.Controls.Add(this.dataGridViewFur);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фурнитура";
            // 
            // EditFur
            // 
            this.EditFur.Location = new System.Drawing.Point(153, 204);
            this.EditFur.Name = "EditFur";
            this.EditFur.Size = new System.Drawing.Size(93, 23);
            this.EditFur.TabIndex = 4;
            this.EditFur.Text = "Редактировать";
            this.EditFur.UseVisualStyleBackColor = true;
            this.EditFur.Click += new System.EventHandler(this.EditFur_Click);
            // 
            // DeleteFur
            // 
            this.DeleteFur.Location = new System.Drawing.Point(153, 175);
            this.DeleteFur.Name = "DeleteFur";
            this.DeleteFur.Size = new System.Drawing.Size(93, 23);
            this.DeleteFur.TabIndex = 3;
            this.DeleteFur.Text = "Удалить";
            this.DeleteFur.UseVisualStyleBackColor = true;
            this.DeleteFur.Click += new System.EventHandler(this.DeleteFur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EditProv);
            this.groupBox2.Controls.Add(this.DeleteProv);
            this.groupBox2.Controls.Add(this.dataGridViewProv);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 244);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поставщик";
            // 
            // EditProv
            // 
            this.EditProv.Location = new System.Drawing.Point(153, 204);
            this.EditProv.Name = "EditProv";
            this.EditProv.Size = new System.Drawing.Size(93, 23);
            this.EditProv.TabIndex = 6;
            this.EditProv.Text = "Редактировать";
            this.EditProv.UseVisualStyleBackColor = true;
            this.EditProv.Click += new System.EventHandler(this.EditProv_Click);
            // 
            // DeleteProv
            // 
            this.DeleteProv.Location = new System.Drawing.Point(153, 175);
            this.DeleteProv.Name = "DeleteProv";
            this.DeleteProv.Size = new System.Drawing.Size(93, 23);
            this.DeleteProv.TabIndex = 5;
            this.DeleteProv.Text = "Удалить";
            this.DeleteProv.UseVisualStyleBackColor = true;
            this.DeleteProv.Click += new System.EventHandler(this.DeleteProv_Click);
            // 
            // dataGridViewProv
            // 
            this.dataGridViewProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProv.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewProv.Name = "dataGridViewProv";
            this.dataGridViewProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProv.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProv.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EditMat);
            this.groupBox3.Controls.Add(this.dataGridViewMat);
            this.groupBox3.Controls.Add(this.DeleteMat);
            this.groupBox3.Location = new System.Drawing.Point(12, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 244);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Материалы";
            // 
            // EditMat
            // 
            this.EditMat.Location = new System.Drawing.Point(153, 204);
            this.EditMat.Name = "EditMat";
            this.EditMat.Size = new System.Drawing.Size(93, 23);
            this.EditMat.TabIndex = 8;
            this.EditMat.Text = "Редактировать";
            this.EditMat.UseVisualStyleBackColor = true;
            this.EditMat.Click += new System.EventHandler(this.EditMat_Click);
            // 
            // dataGridViewMat
            // 
            this.dataGridViewMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMat.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMat.Name = "dataGridViewMat";
            this.dataGridViewMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMat.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewMat.TabIndex = 0;
            // 
            // DeleteMat
            // 
            this.DeleteMat.Location = new System.Drawing.Point(153, 175);
            this.DeleteMat.Name = "DeleteMat";
            this.DeleteMat.Size = new System.Drawing.Size(93, 23);
            this.DeleteMat.TabIndex = 7;
            this.DeleteMat.Text = "Удалить";
            this.DeleteMat.UseVisualStyleBackColor = true;
            this.DeleteMat.Click += new System.EventHandler(this.DeleteMat_Click);
            // 
            // FurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FurnitureForm";
            this.Text = "Просмотр фурнитуры";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFur)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewProv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewMat;
        private System.Windows.Forms.Button EditFur;
        private System.Windows.Forms.Button DeleteFur;
        private System.Windows.Forms.Button EditProv;
        private System.Windows.Forms.Button DeleteProv;
        private System.Windows.Forms.Button EditMat;
        private System.Windows.Forms.Button DeleteMat;
    }
}