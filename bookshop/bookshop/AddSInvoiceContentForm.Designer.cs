namespace bookshop
{
    partial class AddSInvoiceContentForm
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
            cover_type_label = new Label();
            author_label = new Label();
            title_label = new Label();
            price_label = new Label();
            quantity_label = new Label();
            cover_type_cmbx = new ComboBox();
            author_cmbx = new ComboBox();
            title_cmbx = new ComboBox();
            price_txtb = new TextBox();
            quantity_txtb = new TextBox();
            add_content_btn = new Button();
            cancel_add_btn = new Button();
            SuspendLayout();
            // 
            // cover_type_label
            // 
            cover_type_label.AutoSize = true;
            cover_type_label.Location = new Point(40, 36);
            cover_type_label.Name = "cover_type_label";
            cover_type_label.Size = new Size(123, 25);
            cover_type_label.TabIndex = 0;
            cover_type_label.Text = "Тип обложки:";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(64, 92);
            author_label.Name = "author_label";
            author_label.Size = new Size(67, 25);
            author_label.TabIndex = 1;
            author_label.Text = "Автор:";
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(52, 146);
            title_label.Name = "title_label";
            title_label.Size = new Size(94, 25);
            title_label.TabIndex = 2;
            title_label.Text = "Название:";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Location = new Point(64, 193);
            price_label.Name = "price_label";
            price_label.Size = new Size(57, 25);
            price_label.TabIndex = 3;
            price_label.Text = "Цена:";
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Location = new Point(40, 243);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(111, 25);
            quantity_label.TabIndex = 4;
            quantity_label.Text = "Количество:";
            // 
            // cover_type_cmbx
            // 
            cover_type_cmbx.FormattingEnabled = true;
            cover_type_cmbx.Items.AddRange(new object[] { "твёрдая", "мягкая" });
            cover_type_cmbx.Location = new Point(190, 33);
            cover_type_cmbx.Name = "cover_type_cmbx";
            cover_type_cmbx.Size = new Size(208, 33);
            cover_type_cmbx.TabIndex = 5;
            cover_type_cmbx.SelectedIndexChanged += cover_type_cmbx_SelectedIndexChanged;
            // 
            // author_cmbx
            // 
            author_cmbx.FormattingEnabled = true;
            author_cmbx.Location = new Point(190, 89);
            author_cmbx.Name = "author_cmbx";
            author_cmbx.Size = new Size(208, 33);
            author_cmbx.TabIndex = 6;
            author_cmbx.SelectedIndexChanged += authot_cmbx_SelectedIndexChanged;
            // 
            // title_cmbx
            // 
            title_cmbx.FormattingEnabled = true;
            title_cmbx.Location = new Point(172, 143);
            title_cmbx.Name = "title_cmbx";
            title_cmbx.Size = new Size(226, 33);
            title_cmbx.TabIndex = 7;
            // 
            // price_txtb
            // 
            price_txtb.Location = new Point(212, 190);
            price_txtb.Name = "price_txtb";
            price_txtb.Size = new Size(150, 31);
            price_txtb.TabIndex = 8;
            // 
            // quantity_txtb
            // 
            quantity_txtb.Location = new Point(212, 240);
            quantity_txtb.Name = "quantity_txtb";
            quantity_txtb.Size = new Size(150, 31);
            quantity_txtb.TabIndex = 9;
            // 
            // add_content_btn
            // 
            add_content_btn.Location = new Point(40, 327);
            add_content_btn.Name = "add_content_btn";
            add_content_btn.Size = new Size(134, 34);
            add_content_btn.TabIndex = 10;
            add_content_btn.Text = "Подтвердить";
            add_content_btn.UseVisualStyleBackColor = true;
            add_content_btn.Click += add_content_btn_Click;
            // 
            // cancel_add_btn
            // 
            cancel_add_btn.Location = new Point(250, 327);
            cancel_add_btn.Name = "cancel_add_btn";
            cancel_add_btn.Size = new Size(112, 34);
            cancel_add_btn.TabIndex = 11;
            cancel_add_btn.Text = "Отменить";
            cancel_add_btn.UseVisualStyleBackColor = true;
            cancel_add_btn.Click += cancel_add_btn_Click;
            // 
            // AddSInvoiceContentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(cancel_add_btn);
            Controls.Add(add_content_btn);
            Controls.Add(quantity_txtb);
            Controls.Add(price_txtb);
            Controls.Add(title_cmbx);
            Controls.Add(author_cmbx);
            Controls.Add(cover_type_cmbx);
            Controls.Add(quantity_label);
            Controls.Add(price_label);
            Controls.Add(title_label);
            Controls.Add(author_label);
            Controls.Add(cover_type_label);
            Name = "AddSInvoiceContentForm";
            Text = "Добавление в накладную";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cover_type_label;
        private Label author_label;
        private Label title_label;
        private Label price_label;
        private Label quantity_label;
        private ComboBox cover_type_cmbx;
        private ComboBox author_cmbx;
        private ComboBox title_cmbx;
        private TextBox price_txtb;
        private TextBox quantity_txtb;
        private Button add_content_btn;
        private Button cancel_add_btn;
    }
}