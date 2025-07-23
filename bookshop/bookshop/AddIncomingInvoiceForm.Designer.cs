namespace bookshop
{
    partial class AddIncomingInvoiceForm
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
            add_invoice_btn = new Button();
            cancel_add_btn = new Button();
            seller_label = new Label();
            date_label = new Label();
            dateTimePicker1 = new DateTimePicker();
            seller_cmbx = new ComboBox();
            SuspendLayout();
            // 
            // add_invoice_btn
            // 
            add_invoice_btn.Location = new Point(25, 148);
            add_invoice_btn.Name = "add_invoice_btn";
            add_invoice_btn.Size = new Size(156, 34);
            add_invoice_btn.TabIndex = 0;
            add_invoice_btn.Text = "Подтвердить";
            add_invoice_btn.UseVisualStyleBackColor = true;
            add_invoice_btn.Click += add_invoice_btn_Click;
            // 
            // cancel_add_btn
            // 
            cancel_add_btn.Location = new Point(251, 148);
            cancel_add_btn.Name = "cancel_add_btn";
            cancel_add_btn.Size = new Size(141, 34);
            cancel_add_btn.TabIndex = 1;
            cancel_add_btn.Text = "Отменить";
            cancel_add_btn.UseVisualStyleBackColor = true;
            cancel_add_btn.Click += cancel_add_btn_Click;
            // 
            // seller_label
            // 
            seller_label.AutoSize = true;
            seller_label.Location = new Point(52, 45);
            seller_label.Name = "seller_label";
            seller_label.Size = new Size(108, 25);
            seller_label.TabIndex = 2;
            seller_label.Text = "Поставщик:";
            // 
            // date_label
            // 
            date_label.AutoSize = true;
            date_label.Location = new Point(74, 86);
            date_label.Name = "date_label";
            date_label.Size = new Size(53, 25);
            date_label.TabIndex = 3;
            date_label.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 81);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // seller_cmbx
            // 
            seller_cmbx.FormattingEnabled = true;
            seller_cmbx.Location = new Point(189, 42);
            seller_cmbx.Name = "seller_cmbx";
            seller_cmbx.Size = new Size(233, 33);
            seller_cmbx.TabIndex = 5;
            // 
            // AddIncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 227);
            Controls.Add(seller_cmbx);
            Controls.Add(dateTimePicker1);
            Controls.Add(date_label);
            Controls.Add(seller_label);
            Controls.Add(cancel_add_btn);
            Controls.Add(add_invoice_btn);
            Name = "AddIncomingInvoiceForm";
            Text = "Добавление накладной";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_invoice_btn;
        private Button cancel_add_btn;
        private Label seller_label;
        private Label date_label;
        private DateTimePicker dateTimePicker1;
        private ComboBox seller_cmbx;
    }
}