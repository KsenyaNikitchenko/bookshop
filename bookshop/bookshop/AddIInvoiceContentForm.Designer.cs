namespace bookshop
{
    partial class AddIInvoiceContentForm
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
            add_content_btn = new Button();
            cancel_add_btn = new Button();
            title_label = new Label();
            price_label = new Label();
            quantity_label = new Label();
            price_txtb = new TextBox();
            quantity_txtb = new TextBox();
            title_cmbx = new ComboBox();
            author_label = new Label();
            cover_label = new Label();
            author_cmbx = new ComboBox();
            cover_type_cmbx = new ComboBox();
            SuspendLayout();
            // 
            // add_content_btn
            // 
            add_content_btn.Location = new Point(53, 382);
            add_content_btn.Name = "add_content_btn";
            add_content_btn.Size = new Size(136, 34);
            add_content_btn.TabIndex = 0;
            add_content_btn.Text = "Подтвердить";
            add_content_btn.UseVisualStyleBackColor = true;
            add_content_btn.Click += add_content_btn_Click;
            // 
            // cancel_add_btn
            // 
            cancel_add_btn.Location = new Point(313, 382);
            cancel_add_btn.Name = "cancel_add_btn";
            cancel_add_btn.Size = new Size(112, 34);
            cancel_add_btn.TabIndex = 1;
            cancel_add_btn.Text = "Отменить";
            cancel_add_btn.UseVisualStyleBackColor = true;
            cancel_add_btn.Click += cancel_add_btn_Click;
            // 
            // title_label
            // 
            title_label.AutoSize = true;
            title_label.Location = new Point(44, 188);
            title_label.Name = "title_label";
            title_label.Size = new Size(145, 25);
            title_label.TabIndex = 2;
            title_label.Text = "Название книги:";
            // 
            // price_label
            // 
            price_label.AutoSize = true;
            price_label.Location = new Point(76, 238);
            price_label.Name = "price_label";
            price_label.Size = new Size(57, 25);
            price_label.TabIndex = 3;
            price_label.Text = "Цена:";
            // 
            // quantity_label
            // 
            quantity_label.AutoSize = true;
            quantity_label.Location = new Point(53, 307);
            quantity_label.Name = "quantity_label";
            quantity_label.Size = new Size(111, 25);
            quantity_label.TabIndex = 4;
            quantity_label.Text = "Количество:";
            // 
            // price_txtb
            // 
            price_txtb.Location = new Point(206, 232);
            price_txtb.Name = "price_txtb";
            price_txtb.Size = new Size(219, 31);
            price_txtb.TabIndex = 5;
            // 
            // quantity_txtb
            // 
            quantity_txtb.Location = new Point(206, 307);
            quantity_txtb.Name = "quantity_txtb";
            quantity_txtb.Size = new Size(219, 31);
            quantity_txtb.TabIndex = 6;
            // 
            // title_cmbx
            // 
            title_cmbx.FormattingEnabled = true;
            title_cmbx.Location = new Point(206, 180);
            title_cmbx.Name = "title_cmbx";
            title_cmbx.Size = new Size(295, 33);
            title_cmbx.TabIndex = 7;
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(53, 121);
            author_label.Name = "author_label";
            author_label.Size = new Size(118, 25);
            author_label.TabIndex = 8;
            author_label.Text = "Автор книги:";
            // 
            // cover_label
            // 
            cover_label.AutoSize = true;
            cover_label.Location = new Point(66, 56);
            cover_label.Name = "cover_label";
            cover_label.Size = new Size(123, 25);
            cover_label.TabIndex = 9;
            cover_label.Text = "Тип обложки:";
            // 
            // author_cmbx
            // 
            author_cmbx.FormattingEnabled = true;
            author_cmbx.Location = new Point(206, 118);
            author_cmbx.Name = "author_cmbx";
            author_cmbx.Size = new Size(209, 33);
            author_cmbx.TabIndex = 10;
            author_cmbx.SelectedIndexChanged += author_cmbx_SelectedIndexChanged;
            // 
            // cover_type_cmbx
            // 
            cover_type_cmbx.FormattingEnabled = true;
            cover_type_cmbx.Items.AddRange(new object[] { "твёрдая", "мягкая" });
            cover_type_cmbx.Location = new Point(206, 56);
            cover_type_cmbx.Name = "cover_type_cmbx";
            cover_type_cmbx.Size = new Size(182, 33);
            cover_type_cmbx.TabIndex = 11;
            cover_type_cmbx.SelectedIndexChanged += cover_type_cmbx_SelectedIndexChanged;
            // 
            // AddIInvoiceContentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 517);
            Controls.Add(cover_type_cmbx);
            Controls.Add(author_cmbx);
            Controls.Add(cover_label);
            Controls.Add(author_label);
            Controls.Add(title_cmbx);
            Controls.Add(quantity_txtb);
            Controls.Add(price_txtb);
            Controls.Add(quantity_label);
            Controls.Add(price_label);
            Controls.Add(title_label);
            Controls.Add(cancel_add_btn);
            Controls.Add(add_content_btn);
            Name = "AddIInvoiceContentForm";
            Text = "Добавление в накладную";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_content_btn;
        private Button cancel_add_btn;
        private Label title_label;
        private Label price_label;
        private Label quantity_label;
        private TextBox price_txtb;
        private TextBox quantity_txtb;
        private ComboBox title_cmbx;
        private Label author_label;
        private Label cover_label;
        private ComboBox author_cmbx;
        private ComboBox cover_type_cmbx;
    }
}