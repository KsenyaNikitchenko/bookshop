namespace bookshop
{
    partial class SalesInvoiceForm
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
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            add_invoice_menu = new ToolStripMenuItem();
            add_content_menu = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            delete_invoice_menu = new ToolStripMenuItem();
            delete_content_menu = new ToolStripMenuItem();
            dataGridViewSInvoice = new DataGridView();
            dataGridViewSContent = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSContent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1269, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { add_invoice_menu, add_content_menu });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(106, 29);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // add_invoice_menu
            // 
            add_invoice_menu.Name = "add_invoice_menu";
            add_invoice_menu.Size = new Size(302, 34);
            add_invoice_menu.Text = "Добавить накладную";
            add_invoice_menu.Click += add_invoice_menu_Click;
            // 
            // add_content_menu
            // 
            add_content_menu.Name = "add_content_menu";
            add_content_menu.Size = new Size(302, 34);
            add_content_menu.Text = "Добавить в накладную";
            add_content_menu.Click += add_content_menu_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { delete_invoice_menu, delete_content_menu });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(92, 29);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // delete_invoice_menu
            // 
            delete_invoice_menu.Name = "delete_invoice_menu";
            delete_invoice_menu.Size = new Size(293, 34);
            delete_invoice_menu.Text = "Удалить накладную";
            delete_invoice_menu.Click += delete_invoice_menu_Click;
            // 
            // delete_content_menu
            // 
            delete_content_menu.Name = "delete_content_menu";
            delete_content_menu.Size = new Size(293, 34);
            delete_content_menu.Text = "Удалить из накладной";
            delete_content_menu.Click += delete_content_menu_Click;
            // 
            // dataGridViewSInvoice
            // 
            dataGridViewSInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSInvoice.Location = new Point(12, 36);
            dataGridViewSInvoice.Name = "dataGridViewSInvoice";
            dataGridViewSInvoice.RowHeadersWidth = 62;
            dataGridViewSInvoice.Size = new Size(499, 516);
            dataGridViewSInvoice.TabIndex = 1;
            dataGridViewSInvoice.SelectionChanged += dataGridViewSInvoice_SelectionChanged;
            // 
            // dataGridViewSContent
            // 
            dataGridViewSContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSContent.Location = new Point(547, 36);
            dataGridViewSContent.Name = "dataGridViewSContent";
            dataGridViewSContent.RowHeadersWidth = 62;
            dataGridViewSContent.Size = new Size(700, 516);
            dataGridViewSContent.TabIndex = 2;
            // 
            // SalesInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 564);
            Controls.Add(dataGridViewSContent);
            Controls.Add(dataGridViewSInvoice);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SalesInvoiceForm";
            Text = "Накладные по продажам";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem add_invoice_menu;
        private ToolStripMenuItem add_content_menu;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem delete_invoice_menu;
        private ToolStripMenuItem delete_content_menu;
        private DataGridView dataGridViewSInvoice;
        private DataGridView dataGridViewSContent;
    }
}