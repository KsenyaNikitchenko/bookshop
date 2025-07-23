namespace bookshop
{
    partial class SellersForm
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
            menuStrip1 = new MenuStrip();
            add_seller_menu = new ToolStripMenuItem();
            change_seller_menu = new ToolStripMenuItem();
            delete_seller_menu = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { add_seller_menu, change_seller_menu, delete_seller_menu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(576, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // add_seller_menu
            // 
            add_seller_menu.Name = "add_seller_menu";
            add_seller_menu.Size = new Size(106, 29);
            add_seller_menu.Text = "Добавить";
            add_seller_menu.Click += add_seller_menu_Click;
            // 
            // change_seller_menu
            // 
            change_seller_menu.Name = "change_seller_menu";
            change_seller_menu.Size = new Size(107, 29);
            change_seller_menu.Text = "Изменить";
            change_seller_menu.Click += change_seller_menu_Click;
            // 
            // delete_seller_menu
            // 
            delete_seller_menu.Name = "delete_seller_menu";
            delete_seller_menu.Size = new Size(92, 29);
            delete_seller_menu.Text = "Удалить";
            delete_seller_menu.Click += delete_seller_menu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(551, 392);
            dataGridView1.TabIndex = 1;
            // 
            // SellersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 450);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SellersForm";
            Text = "Поставщики";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem add_seller_menu;
        private ToolStripMenuItem change_seller_menu;
        private ToolStripMenuItem delete_seller_menu;
        private DataGridView dataGridView1;
    }
}