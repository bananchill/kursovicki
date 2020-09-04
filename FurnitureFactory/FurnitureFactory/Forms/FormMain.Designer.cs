namespace FurnitureFactory
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.AcceptOrderButton = new System.Windows.Forms.Button();
            this.buttonProcessOrder = new System.Windows.Forms.Button();
            this.buttonEndOrder = new System.Windows.Forms.Button();
            this.buttonAcceptOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSprav = new System.Windows.Forms.Button();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.AcceptOrderButton);
            this.groupBoxOrder.Controls.Add(this.buttonProcessOrder);
            this.groupBoxOrder.Controls.Add(this.buttonEndOrder);
            this.groupBoxOrder.Controls.Add(this.buttonAcceptOrder);
            this.groupBoxOrder.Controls.Add(this.buttonDeleteOrder);
            this.groupBoxOrder.Controls.Add(this.buttonCancelOrder);
            this.groupBoxOrder.Controls.Add(this.buttonAddOrder);
            this.groupBoxOrder.Controls.Add(this.dataGridViewOrders);
            this.groupBoxOrder.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(788, 436);
            this.groupBoxOrder.TabIndex = 0;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Список заказов";
            // 
            // AcceptOrderButton
            // 
            this.AcceptOrderButton.Location = new System.Drawing.Point(6, 375);
            this.AcceptOrderButton.Name = "AcceptOrderButton";
            this.AcceptOrderButton.Size = new System.Drawing.Size(144, 23);
            this.AcceptOrderButton.TabIndex = 7;
            this.AcceptOrderButton.Text = "Подтверждение заказа";
            this.AcceptOrderButton.UseVisualStyleBackColor = true;
            this.AcceptOrderButton.Click += new System.EventHandler(this.AcceptOrderButton_Click);
            // 
            // buttonProcessOrder
            // 
            this.buttonProcessOrder.Location = new System.Drawing.Point(6, 346);
            this.buttonProcessOrder.Name = "buttonProcessOrder";
            this.buttonProcessOrder.Size = new System.Drawing.Size(144, 23);
            this.buttonProcessOrder.TabIndex = 6;
            this.buttonProcessOrder.Text = "Поменять статус заказа";
            this.buttonProcessOrder.UseVisualStyleBackColor = true;
            this.buttonProcessOrder.Click += new System.EventHandler(this.buttonProcessOrder_Click);
            // 
            // buttonEndOrder
            // 
            this.buttonEndOrder.Location = new System.Drawing.Point(626, 375);
            this.buttonEndOrder.Name = "buttonEndOrder";
            this.buttonEndOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonEndOrder.TabIndex = 5;
            this.buttonEndOrder.Text = "Завершить";
            this.buttonEndOrder.UseVisualStyleBackColor = true;
            this.buttonEndOrder.Click += new System.EventHandler(this.buttonEndOrder_Click);
            // 
            // buttonAcceptOrder
            // 
            this.buttonAcceptOrder.Location = new System.Drawing.Point(626, 346);
            this.buttonAcceptOrder.Name = "buttonAcceptOrder";
            this.buttonAcceptOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptOrder.TabIndex = 4;
            this.buttonAcceptOrder.Text = "Принять";
            this.buttonAcceptOrder.UseVisualStyleBackColor = true;
            this.buttonAcceptOrder.Click += new System.EventHandler(this.buttonAcceptOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(707, 404);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOrder.TabIndex = 3;
            this.buttonDeleteOrder.Text = "Удалить";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(707, 375);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelOrder.TabIndex = 2;
            this.buttonCancelOrder.Text = "Отменить";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Location = new System.Drawing.Point(707, 346);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOrder.TabIndex = 1;
            this.buttonAddOrder.Text = "Добавить";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(776, 321);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSprav
            // 
            this.buttonSprav.Location = new System.Drawing.Point(799, 12);
            this.buttonSprav.Name = "buttonSprav";
            this.buttonSprav.Size = new System.Drawing.Size(75, 23);
            this.buttonSprav.TabIndex = 8;
            this.buttonSprav.Text = "Справочник";
            this.buttonSprav.UseVisualStyleBackColor = true;
            this.buttonSprav.Click += new System.EventHandler(this.buttonSprav_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 440);
            this.Controls.Add(this.buttonSprav);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxOrder);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonAcceptOrder;
        private System.Windows.Forms.Button buttonEndOrder;
        private System.Windows.Forms.Button buttonProcessOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AcceptOrderButton;
        private System.Windows.Forms.Button buttonSprav;
    }
}

