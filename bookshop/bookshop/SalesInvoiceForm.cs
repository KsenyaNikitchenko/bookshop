using Npgsql;
using System.Data;

namespace bookshop
{
    public partial class SalesInvoiceForm : Form
    {
        public NpgsqlConnection con;
        DataTable SInvoiceTable = new DataTable();
        DataSet SInvoiceSet = new DataSet();
        DataTable SInvoiceContentTable = new DataTable();
        DataSet SInvoiceContentSet = new DataSet();
        public SalesInvoiceForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        private void Update()
        {
            string sql = "select id_sinvoice,date,total_sum from sales_invoice order by id_sinvoice";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            SInvoiceSet.Reset();
            da.Fill(SInvoiceSet);
            SInvoiceTable = SInvoiceSet.Tables[0];
            dataGridViewSInvoice.DataSource = SInvoiceTable;
            dataGridViewSInvoice.Columns[0].HeaderText = "Номер";
            dataGridViewSInvoice.Columns[1].HeaderText = "Дата";
            dataGridViewSInvoice.Columns[2].HeaderText = "Общая сумма";
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void UpdateContent()
        {
            if (dataGridViewSInvoice.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewSInvoice.SelectedRows[0].Cells["id_sinvoice"].Value);
                string sql = "select title, author,cover_type, price, quantity from sales_invoice_content " +
                    "join books on(sales_invoice_content.book_id = books.id_book) "
                + "where sinvoice_id=:id order by sales_invoice_content.id_sicontent";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.AddWithValue(":id", id);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
                SInvoiceContentSet.Reset();
                da.Fill(SInvoiceContentSet);
                SInvoiceContentTable = SInvoiceContentSet.Tables[0];
                dataGridViewSContent.DataSource = SInvoiceContentTable;
                dataGridViewSContent.Columns[0].HeaderText = "Название книги";
                dataGridViewSContent.Columns[1].HeaderText = "Автор";
                dataGridViewSContent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewSContent.Columns[2].HeaderText = "Тип обложки";
                dataGridViewSContent.Columns[2].Width = 120;
                dataGridViewSContent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewSContent.Columns[3].HeaderText = "Цена";
                dataGridViewSContent.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewSContent.Columns[3].Width = 90;
                dataGridViewSContent.Columns[4].HeaderText = "Количество";
                dataGridViewSContent.Columns[4].Width = 125;
                dataGridViewSContent.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void add_invoice_menu_Click(object sender, EventArgs e)
        {
            AddSalesInvoiceForm addsalesInvoice = new AddSalesInvoiceForm(con);
            addsalesInvoice.ShowDialog();
            Update();
        }

        private void add_content_menu_Click(object sender, EventArgs e)
        {
            int sinvoice_id = (int)dataGridViewSInvoice.CurrentRow.Cells["id_sinvoice"].Value;
            AddSInvoiceContentForm addSContent = new AddSInvoiceContentForm(con, sinvoice_id);
            addSContent.ShowDialog();
            UpdateContent();
            Update();
        }

        private void delete_invoice_menu_Click(object sender, EventArgs e)
        {
            int id_iinvoice = (int)dataGridViewSInvoice.CurrentRow.Cells["id_iinvoice"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную накладную?", "Удаление накладной по продажам", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from sales_invoice where id_sinvoice=:id", con);
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
            int id_iicontent = (int)dataGridViewSContent.CurrentRow.Cells["id_sicontent"].Value;
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную книгу из накладной?", "Удаление книги из накладной по продажам",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from sales_invoice_content where id_sicontent=:id", con);
                    command.Parameters.AddWithValue("id", id_iicontent);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            UpdateContent();
            Update();
        }

        private void dataGridViewSInvoice_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSInvoice.SelectedRows.Count > 0)
            {
                UpdateContent();
            }
        }
    }
}
