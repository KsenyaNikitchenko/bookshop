namespace bookshop
{
    partial class AddBookForm
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
            add_book_btn = new Button();
            cancel_add_btn = new Button();
            title_label = new Label();
            author_label = new Label();
            cover_type_label = new Label();
            title_txtb = new TextBox();
            author_txtb = new TextBox();
            cover_type_cmbx = new ComboBox();
            SuspendLayout();
            // 
            // add_book_btn
            // 
            add_book_btn.Location = new Point(70, 244);
            add_book_btn.Name = "add_book_btn";
            add_book_btn.Size = new Size(132, 34);
            add_book_btn.TabIndex = 0;
            add_book_btn.Text = "Подтвердить";
            add_book_btn.UseVisualStyleBackColor = true;
            add_book_btn.Click += add_book_btn_Click;
            // 
            // cancel_add_btn
            // 
            cancel_add_btn.Location = new Point(294, 244);
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
            title_label.Location = new Point(21, 47);
            title_label.Name = "title_label";
            title_label.Size = new Size(145, 25);
            title_label.TabIndex = 2;
            title_label.Text = "Название книги:";
            // 
            // author_label
            // 
            author_label.AutoSize = true;
            author_label.Location = new Point(55, 102);
            author_label.Name = "author_label";
            author_label.Size = new Size(67, 25);
            author_label.TabIndex = 3;
            author_label.Text = "Автор:";
            // 
            // cover_type_label
            // 
            cover_type_label.AutoSize = true;
            cover_type_label.Location = new Point(34, 156);
            cover_type_label.Name = "cover_type_label";
            cover_type_label.Size = new Size(123, 25);
            cover_type_label.TabIndex = 4;
            cover_type_label.Text = "Тип обложки:";
            // 
            // title_txtb
            // 
            title_txtb.Location = new Point(184, 44);
            title_txtb.Name = "title_txtb";
            title_txtb.Size = new Size(274, 31);
            title_txtb.TabIndex = 5;
            // 
            // author_txtb
            // 
            author_txtb.Location = new Point(184, 96);
            author_txtb.Name = "author_txtb";
            author_txtb.Size = new Size(274, 31);
            author_txtb.TabIndex = 6;
            // 
            // cover_type_cmbx
            // 
            cover_type_cmbx.FormattingEnabled = true;
            cover_type_cmbx.Items.AddRange(new object[] { "твёрдая", "мягкая" });
            cover_type_cmbx.Location = new Point(204, 148);
            cover_type_cmbx.Name = "cover_type_cmbx";
            cover_type_cmbx.Size = new Size(202, 33);
            cover_type_cmbx.TabIndex = 7;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 316);
            Controls.Add(cover_type_cmbx);
            Controls.Add(author_txtb);
            Controls.Add(title_txtb);
            Controls.Add(cover_type_label);
            Controls.Add(author_label);
            Controls.Add(title_label);
            Controls.Add(cancel_add_btn);
            Controls.Add(add_book_btn);
            Name = "AddBookForm";
            Text = "Добавление/изменение книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_book_btn;
        private Button cancel_add_btn;
        private Label title_label;
        private Label author_label;
        private Label cover_type_label;
        private TextBox title_txtb;
        private TextBox author_txtb;
        private ComboBox cover_type_cmbx;
    }
}