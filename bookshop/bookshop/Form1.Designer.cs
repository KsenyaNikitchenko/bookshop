namespace bookshop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            book_btn = new Button();
            selers_btn = new Button();
            iinvoice_btn = new Button();
            sinvoice_btn = new Button();
            inventory_management_btn = new Button();
            SuspendLayout();
            // 
            // book_btn
            // 
            book_btn.Location = new Point(81, 58);
            book_btn.Name = "book_btn";
            book_btn.Size = new Size(232, 34);
            book_btn.TabIndex = 0;
            book_btn.Text = "Товары";
            book_btn.UseVisualStyleBackColor = true;
            book_btn.Click += book_btn_Click;
            // 
            // selers_btn
            // 
            selers_btn.Location = new Point(81, 111);
            selers_btn.Name = "selers_btn";
            selers_btn.Size = new Size(232, 34);
            selers_btn.TabIndex = 1;
            selers_btn.Text = "Поставщики";
            selers_btn.UseVisualStyleBackColor = true;
            selers_btn.Click += selers_btn_Click;
            // 
            // iinvoice_btn
            // 
            iinvoice_btn.Location = new Point(81, 164);
            iinvoice_btn.Name = "iinvoice_btn";
            iinvoice_btn.Size = new Size(232, 34);
            iinvoice_btn.TabIndex = 2;
            iinvoice_btn.Text = "Приходные накладные";
            iinvoice_btn.UseVisualStyleBackColor = true;
            iinvoice_btn.Click += iinvoice_btn_Click;
            // 
            // sinvoice_btn
            // 
            sinvoice_btn.Location = new Point(81, 218);
            sinvoice_btn.Name = "sinvoice_btn";
            sinvoice_btn.Size = new Size(232, 34);
            sinvoice_btn.TabIndex = 3;
            sinvoice_btn.Text = "Накладные по продажам";
            sinvoice_btn.UseVisualStyleBackColor = true;
            sinvoice_btn.Click += sinvoice_btn_Click;
            // 
            // inventory_management_btn
            // 
            inventory_management_btn.Location = new Point(81, 276);
            inventory_management_btn.Name = "inventory_management_btn";
            inventory_management_btn.Size = new Size(232, 34);
            inventory_management_btn.TabIndex = 4;
            inventory_management_btn.Text = "Управление запасами";
            inventory_management_btn.UseVisualStyleBackColor = true;
            inventory_management_btn.Click += inventory_management_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 385);
            Controls.Add(inventory_management_btn);
            Controls.Add(sinvoice_btn);
            Controls.Add(iinvoice_btn);
            Controls.Add(selers_btn);
            Controls.Add(book_btn);
            Name = "Form1";
            Text = "Книжный магазин";
            ResumeLayout(false);
        }

        #endregion

        private Button book_btn;
        private Button selers_btn;
        private Button iinvoice_btn;
        private Button sinvoice_btn;
        private Button inventory_management_btn;
    }
}
