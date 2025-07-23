namespace bookshop
{
    partial class InventyryManagementForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lead_time_txtb = new TextBox();
            delivery_delay_txtb = new TextBox();
            order_spacing_txtb = new TextBox();
            calculate_order_size_btn = new Button();
            dataGridView1 = new DataGridView();
            seller_cmbx = new ComboBox();
            seller_label = new Label();
            date_label = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 0;
            label1.Text = "Время выполнения заказа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 1;
            label2.Text = "Время задержки поставки:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(310, 25);
            label3.TabIndex = 2;
            label3.Text = "Интервал времени между заказами:";
            // 
            // lead_time_txtb
            // 
            lead_time_txtb.Location = new Point(330, 12);
            lead_time_txtb.Name = "lead_time_txtb";
            lead_time_txtb.Size = new Size(283, 31);
            lead_time_txtb.TabIndex = 6;
            // 
            // delivery_delay_txtb
            // 
            delivery_delay_txtb.Location = new Point(330, 46);
            delivery_delay_txtb.Name = "delivery_delay_txtb";
            delivery_delay_txtb.Size = new Size(283, 31);
            delivery_delay_txtb.TabIndex = 7;
            // 
            // order_spacing_txtb
            // 
            order_spacing_txtb.Location = new Point(330, 83);
            order_spacing_txtb.Name = "order_spacing_txtb";
            order_spacing_txtb.Size = new Size(283, 31);
            order_spacing_txtb.TabIndex = 8;
            // 
            // calculate_order_size_btn
            // 
            calculate_order_size_btn.Location = new Point(441, 131);
            calculate_order_size_btn.Name = "calculate_order_size_btn";
            calculate_order_size_btn.Size = new Size(341, 34);
            calculate_order_size_btn.TabIndex = 12;
            calculate_order_size_btn.Text = "Рассчитать размер заказа";
            calculate_order_size_btn.UseVisualStyleBackColor = true;
            calculate_order_size_btn.Click += calculate_order_size_btn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1096, 445);
            dataGridView1.TabIndex = 13;
            // 
            // seller_cmbx
            // 
            seller_cmbx.FormattingEnabled = true;
            seller_cmbx.Location = new Point(819, 10);
            seller_cmbx.Name = "seller_cmbx";
            seller_cmbx.Size = new Size(289, 33);
            seller_cmbx.TabIndex = 14;
            // 
            // seller_label
            // 
            seller_label.AutoSize = true;
            seller_label.Location = new Point(705, 18);
            seller_label.Name = "seller_label";
            seller_label.Size = new Size(108, 25);
            seller_label.TabIndex = 15;
            seller_label.Text = "Поставщик:";
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Location = new Point(703, 52);
            date_label.Name = "date_label";
            date_label.Size = new Size(110, 25);
            date_label.TabIndex = 16;
            date_label.Text = "Дата заказа:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(819, 52);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // InventyryManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 652);
            Controls.Add(dateTimePicker1);
            Controls.Add(date_label);
            Controls.Add(seller_label);
            Controls.Add(seller_cmbx);
            Controls.Add(dataGridView1);
            Controls.Add(calculate_order_size_btn);
            Controls.Add(order_spacing_txtb);
            Controls.Add(delivery_delay_txtb);
            Controls.Add(lead_time_txtb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InventyryManagementForm";
            Text = "Управление запасами";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lead_time_txtb;
        private TextBox delivery_delay_txtb;
        private TextBox order_spacing_txtb;
        private Button calculate_order_size_btn;
        private DataGridView dataGridView1;
        private ComboBox seller_cmbx;
        private Label seller_label;
        private Label date_label;
        private DateTimePicker dateTimePicker1;
    }
}