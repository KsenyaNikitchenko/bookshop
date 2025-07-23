using Npgsql;
using System.Data;
namespace bookshop
{
    public partial class AddIncomingInvoiceForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public AddIncomingInvoiceForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        public void Update()
        {
            string sql = "select * from sellers order by name";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            seller_cmbx.DataSource = dt;
            seller_cmbx.DisplayMember = "name";
            seller_cmbx.ValueMember = "id_seller";
        }

        private void add_invoice_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into incoming_invoice (seller_id, date, total_sum) values (:seller_id,:date, 0)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.AddWithValue(":seller_id",seller_cmbx.SelectedValue);
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
