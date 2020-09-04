namespace FurnitureFactory.Forms
{
    partial class EditMatForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.NumericUpDown();
            this.comboBoxProv = new System.Windows.Forms.ComboBox();
            this.TextBoxCount = new System.Windows.Forms.NumericUpDown();
            this.textBoxEd = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxLenght = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxChar = new System.Windows.Forms.TextBox();
            this.textBoxGost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ед. измерения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.DecimalPlaces = 2;
            this.TextBoxPrice.Location = new System.Drawing.Point(124, 143);
            this.TextBoxPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(161, 20);
            this.TextBoxPrice.TabIndex = 17;
            // 
            // comboBoxProv
            // 
            this.comboBoxProv.FormattingEnabled = true;
            this.comboBoxProv.Location = new System.Drawing.Point(124, 90);
            this.comboBoxProv.Name = "comboBoxProv";
            this.comboBoxProv.Size = new System.Drawing.Size(161, 21);
            this.comboBoxProv.TabIndex = 16;
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Location = new System.Drawing.Point(124, 64);
            this.TextBoxCount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(161, 20);
            this.TextBoxCount.TabIndex = 15;
            // 
            // textBoxEd
            // 
            this.textBoxEd.Location = new System.Drawing.Point(124, 38);
            this.textBoxEd.Name = "textBoxEd";
            this.textBoxEd.Size = new System.Drawing.Size(161, 20);
            this.textBoxEd.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Длинна";
            // 
            // TextBoxLenght
            // 
            this.TextBoxLenght.Location = new System.Drawing.Point(124, 117);
            this.TextBoxLenght.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.TextBoxLenght.Name = "TextBoxLenght";
            this.TextBoxLenght.Size = new System.Drawing.Size(161, 20);
            this.TextBoxLenght.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Характеристика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Гост";
            // 
            // textBoxChar
            // 
            this.textBoxChar.Location = new System.Drawing.Point(124, 195);
            this.textBoxChar.Name = "textBoxChar";
            this.textBoxChar.Size = new System.Drawing.Size(161, 20);
            this.textBoxChar.TabIndex = 26;
            // 
            // textBoxGost
            // 
            this.textBoxGost.Location = new System.Drawing.Point(124, 169);
            this.textBoxGost.Name = "textBoxGost";
            this.textBoxGost.Size = new System.Drawing.Size(161, 20);
            this.textBoxGost.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(105, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditMatForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 254);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxChar);
            this.Controls.Add(this.textBoxGost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxLenght);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.comboBoxProv);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.textBoxEd);
            this.Controls.Add(this.textBoxName);
            this.Name = "EditMatForm";
            this.Text = "Редактировать материал";
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextBoxLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown TextBoxPrice;
        public System.Windows.Forms.ComboBox comboBoxProv;
        public System.Windows.Forms.NumericUpDown TextBoxCount;
        public System.Windows.Forms.TextBox textBoxEd;
        public System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown TextBoxLenght;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBoxChar;
        public System.Windows.Forms.TextBox textBoxGost;
        private System.Windows.Forms.Button button1;
    }
}