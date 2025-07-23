using Npgsql;
using System.Data;

namespace bookshop
{
    public partial class IncomingInvoiceForm : Form
    {
        public NpgsqlConnection con;
        DataTable IInvoiceTable = new DataTable();
        DataSet IInvoiceSet = new DataSet();
        DataTable IInvoiceContentTable = new DataTable();
        DataSet IInvoiceContentSet = new DataSet();
        public IncomingInvoiceForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        private void Update()
        {
            string sql = "select id_iinvoice,name,date,total_sum from incoming_invoice join sellers on incoming_invoice.seller_id=sellers.id_seller order by id_iinvoice";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            IInvoiceSet.Reset();
            da.Fill(IInvoiceSet);
            IInvoiceTable = IInvoiceSet.Tables[0];
            dataGridViewIInvoice.DataSource = IInvoiceTable;
            dataGridViewIInvoice.Columns[0].HeaderText = "Номер";
            dataGridViewIInvoice.Columns[1].HeaderText = "Поставщик";
            dataGridViewIInvoice.Columns[2].HeaderText = "Дата";
            dataGridViewIInvoice.Columns[3].HeaderText = "Общая сумма";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void UpdateContent()
        {
            if (dataGridViewIInvoice.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewIInvoice.SelectedRows[0].Cells["id_iinvoice"].Value);
                string sql = "select title, author,cover_type, price, quantity from incoming_invoice_content " +
                    "join books on(incoming_invoice_content.book_id = books.id_book) "
                + "where iinvoice_id=:id order by incoming_invoice_content.id_iicontent";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.AddWithValue(":id", id);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                IInvoiceContentSet.Reset();
                da.Fill(IInvoiceContentSet);
                IInvoiceContentTable = IInvoiceContentSet.Tables[0];
                dataGridViewInvoiceContent.DataSource = IInvoiceContentTable;
                dataGridViewInvoiceContent.Columns[0].HeaderText = "Название книги";
                dataGridViewInvoiceContent.Columns[1].HeaderText = "Автор";
                dataGridViewInvoiceContent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewInvoiceContent.Columns[2].HeaderText = "Тип обложки";
                dataGridViewInvoiceContent.Columns[2].Width = 120;
                dataGridViewInvoiceContent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewInvoiceContent.Columns[3].HeaderText = "Цена";
                dataGridViewInvoiceContent.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewInvoiceContent.Columns[3].Width = 90;
                dataGridViewInvoiceContent.Columns[4].HeaderText = "Количество";
                dataGridViewInvoiceContent.Columns[4].Width = 125;
                dataGridViewInvoiceContent.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void add_iinvoice_menu_Click(object sender, EventArgs e)
        {
            AddIncomingInvoiceForm addInvoice = new AddIncomingInvoiceForm(con);
            addInvoice.ShowDialog();
            Update();
        }

        private void add_invoice_content_menu_Click(object sender, EventArgs e)
        {
            int iinvoice_id = (int)dataGridViewIInvoice.CurrentRow.Cells["id_iinvoice"].Value;
            AddIInvoiceContentForm addIInvoiceContentForm = new AddIInvoiceContentForm(con, iinvoice_id);
            addIInvoiceContentForm.ShowDialog();
            UpdateContent();
            Update();
        }

        private void delete_invoice_menu_Click(object sender, EventArgs e)
        {
            int id_iinvoice = (int)dataGridViewIInvoice.CurrentRow.Cells["id_iinvoice"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную накладную?", "Удаление приходной накладной", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from incoming_invoice where id_iinvoice=:id", con);
                    command.Parameters.AddWithValue("id", id_iinvoice);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
            Update();
        }

        private void delete_content_menu_Click(object sender, EventArgs e)
        {
            int id_iicontent = (int)dataGridViewInvoiceContent.CurrentRow.Cells["id_iicontent"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную книгу из накладной?", "Удаление книги из приходной накладной",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from incoming_invoice_content where id_iicontent=:id", con);
                    command.Parameters.AddWithValue("id", id_iicontent);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
            Update();
        }

        private void dataGridViewIInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewIInvoice.SelectedRows.Count > 0)
            {
                UpdateContent();
            }
        }
    }
}
