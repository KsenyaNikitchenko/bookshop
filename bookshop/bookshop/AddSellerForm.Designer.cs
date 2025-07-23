namespace bookshop
{
    partial class AddSellerForm
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
            add_seller_btn = new Button();
            cancel_add_btn = new Button();
            name_label = new Label();
            phone_label = new Label();
            name_txtb = new TextBox();
            phone_txtb = new TextBox();
            SuspendLayout();
            // 
            // add_seller_btn
            // 
            add_seller_btn.Location = new Point(50, 184);
            add_seller_btn.Name = "add_seller_btn";
            add_seller_btn.Size = new Size(141, 34);
            add_seller_btn.TabIndex = 0;
            add_seller_btn.Text = "Подтвердить";
            add_seller_btn.UseVisualStyleBackColor = true;
            add_seller_btn.Click += add_seller_btn_Click;
            // 
            // cancel_add_btn
            // 
            cancel_add_btn.Location = new Point(282, 184);
            cancel_add_btn.Name = "cancel_add_btn";
            cancel_add_btn.Size = new Size(112, 34);
            cancel_add_btn.TabIndex = 1;
            cancel_add_btn.Text = "Отменить";
            cancel_add_btn.UseVisualStyleBackColor = true;
            cancel_add_btn.Click += cancel_add_btn_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(37, 52);
            name_label.Name = "name_label";
            name_label.Size = new Size(94, 25);
            name_label.TabIndex = 2;
            name_label.Text = "Название:";
            // 
            // phone_label
            // 
            phone_label.AutoSize = true;
            phone_label.Location = new Point(37, 94);
            phone_label.Name = "phone_label";
            phone_label.Size = new Size(154, 25);
            phone_label.TabIndex = 3;
            phone_label.Text = "Номер телефона:";
            // 
            // name_txtb
            // 
            name_txtb.Location = new Point(205, 46);
            name_txtb.Name = "name_txtb";
            name_txtb.Size = new Size(222, 31);
            name_txtb.TabIndex = 4;
            // 
            // phone_txtb
            // 
            phone_txtb.Location = new Point(205, 88);
            phone_txtb.Name = "phone_txtb";
            phone_txtb.Size = new Size(222, 31);
            phone_txtb.TabIndex = 5;
            // 
            // AddSellerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 255);
            Controls.Add(phone_txtb);
            Controls.Add(name_txtb);
            Controls.Add(phone_label);
            Controls.Add(name_label);
            Controls.Add(cancel_add_btn);
            Controls.Add(add_seller_btn);
            Name = "AddSellerForm";
            Text = "Добавление/изменение поставщика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_seller_btn;
        private Button cancel_add_btn;
        private Label name_label;
        private Label phone_label;
        private TextBox name_txtb;
        private TextBox phone_txtb;
    }
}