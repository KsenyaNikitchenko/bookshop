namespace bookshop
{
    partial class IncomingInvoiceForm
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
            add_iinvoice_menu = new ToolStripMenuItem();
            add_invoice_content_menu = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            delete_invoice_menu = new ToolStripMenuItem();
            delete_content_menu = new ToolStripMenuItem();
            dataGridViewIInvoice = new DataGridView();
            dataGridViewInvoiceContent = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoiceContent).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, удалитьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1392, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { add_iinvoice_menu, add_invoice_content_menu });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(106, 29);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // add_iinvoice_menu
            // 
            add_iinvoice_menu.Name = "add_iinvoice_menu";
            add_iinvoice_menu.Size = new Size(302, 34);
            add_iinvoice_menu.Text = "Добавить накладную";
            add_iinvoice_menu.Click += add_iinvoice_menu_Click;
            // 
            // add_invoice_content_menu
            // 
            add_invoice_content_menu.Name = "add_invoice_content_menu";
            add_invoice_content_menu.Size = new Size(302, 34);
            add_invoice_content_menu.Text = "Добавить в накладную";
            add_invoice_content_menu.Click += add_invoice_content_menu_Click;
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
            // dataGridViewIInvoice
            // 
            dataGridViewIInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIInvoice.Location = new Point(12, 47);
            dataGridViewIInvoice.Name = "dataGridViewIInvoice";
            dataGridViewIInvoice.RowHeadersWidth = 62;
            dataGridViewIInvoice.Size = new Size(650, 445);
            dataGridViewIInvoice.TabIndex = 1;
            dataGridViewIInvoice.SelectionChanged += dataGridViewIInvoice_SelectionChanged;
            // 
            // dataGridViewInvoiceContent
            // 
            dataGridViewInvoiceContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoiceContent.Location = new Point(680, 47);
            dataGridViewInvoiceContent.Name = "dataGridViewInvoiceContent";
            dataGridViewInvoiceContent.RowHeadersWidth = 62;
            dataGridViewInvoiceContent.Size = new Size(700, 435);
            dataGridViewInvoiceContent.TabIndex = 2;
            // 
            // IncomingInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 521);
            Controls.Add(dataGridViewInvoiceContent);
            Controls.Add(dataGridViewIInvoice);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "IncomingInvoiceForm";
            Text = "Приходные накладные";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoiceContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem add_iinvoice_menu;
        private ToolStripMenuItem add_invoice_content_menu;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem delete_invoice_menu;
        private ToolStripMenuItem delete_content_menu;
        private DataGridView dataGridViewIInvoice;
        private DataGridView dataGridViewInvoiceContent;
    }
}