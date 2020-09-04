namespace FurnitureFactory.Forms
{
    partial class EditFurForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEd = new System.Windows.Forms.TextBox();
            this.TextBoxCount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProv = new System.Windows.Forms.ComboBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.NumericUpDown();
            this.TextBoxWeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxEd
            // 
            this.textBoxEd.Location = new System.Drawing.Point(124, 34);
            this.textBoxEd.Name = "textBoxEd";
            this.textBoxEd.Size = new System.Drawing.Size(161, 20);
            this.textBoxEd.TabIndex = 1;
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Location = new System.Drawing.Point(124, 60);
            this.TextBoxCount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(161, 20);
            this.TextBoxCount.TabIndex = 2;
            // 
            // comboBoxProv
            // 
            this.comboBoxProv.FormattingEnabled = true;
            this.comboBoxProv.Location = new System.Drawing.Point(124, 86);
            this.comboBoxProv.Name = "comboBoxProv";
            this.comboBoxProv.Size = new System.Drawing.Size(161, 21);
            this.comboBoxProv.TabIndex = 3;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(124, 113);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(161, 20);
            this.textBoxType.TabIndex = 4;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.DecimalPlaces = 2;
            this.TextBoxPrice.Location = new System.Drawing.Point(124, 139);
            this.TextBoxPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(161, 20);
            this.TextBoxPrice.TabIndex = 5;
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(124, 165);
            this.TextBoxWeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(161, 20);
            this.TextBoxWeight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ед. измерения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поставщик";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Тип";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вес";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(106, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditFurForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.comboBoxProv);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.textBoxEd);
            this.Controls.Add(this.textBoxName);
            this.Name = "EditFurForm";
            this.Text = "Редактировать фурнитуру";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxEd;
        public System.Windows.Forms.NumericUpDown TextBoxCount;
        public System.Windows.Forms.ComboBox comboBoxProv;
        public System.Windows.Forms.TextBox textBoxType;
        public System.Windows.Forms.NumericUpDown TextBoxPrice;
        public System.Windows.Forms.NumericUpDown TextBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}