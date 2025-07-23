using Npgsql;

namespace bookshop
{
    public partial class AddSalesInvoiceForm : Form
    {
        public NpgsqlConnection con;
        public AddSalesInvoiceForm( NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
        }

        private void add_invoice_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into sales_invoice ( date, total_sum) values (:date, 0)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.Add(":date", NpgsqlTypes.NpgsqlDbType.Date).Value = dateTimePicker1.Value.Date;
                command.ExecuteNonQuery();
                Close();
            }
            catch { }
        }

        private void cancel_add_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
