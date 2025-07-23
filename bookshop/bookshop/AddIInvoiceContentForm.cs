using Npgsql;
using System.Data;

namespace bookshop
{
    public partial class AddIInvoiceContentForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        int iinvoice_id;
        public AddIInvoiceContentForm(NpgsqlConnection con, int iinvoice_id)
        {
            InitializeComponent();
            this.con = con;
            this.iinvoice_id = iinvoice_id;
            UpdateAuthors();
        }
        private void UpdateAuthors()
        {

            string sql = "select distinct author from books order by author";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                    author_cmbx.Items.Add(reader.GetString(0));
            }
           
        }
        private void UpdateTitle(string author, string cover_type)
        {
            title_cmbx.DataSource=null;
            title_cmbx.Items.Clear();
            string sql = "select * from books where author=@author and cover_type=@cover order by title";
            NpgsqlCommand command = new NpgsqlCommand(sql, con);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@cover", cover_type);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(command);
            da.Fill(ds);
            dt = ds.Tables[0];
            title_cmbx.DataSource = dt;
            title_cmbx.DisplayMember = "title";
            title_cmbx.ValueMember = "id_book";

        }
        private void add_content_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into incoming_invoice_content (iinvoice_id, book_id, price, quantity) " +
                    "values (@iinvoice_id, @book_id, @price, @quantity)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.Add("@iinvoice_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = iinvoice_id;
                    command.Parameters.Add("@book_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = title_cmbx.SelectedValue;
                    command.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(price_txtb.Text);
                    command.Parameters.Add("@quantity", NpgsqlTypes.NpgsqlDbType.Double).Value = Convert.ToDouble(quantity_txtb.Text);
                    command.ExecuteNonQuery();
                }
                Close();
            }
            catch { }
        }

        private void cancel_add_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void author_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cover_type_cmbx.SelectedIndex!=-1)
            {
                string author= author_cmbx.SelectedItem.ToString();
                string cover_type;
                if (!string.IsNullOrEmpty(cover_type_cmbx.SelectedItem.ToString()))
                {
                    cover_type = cover_type_cmbx.SelectedItem.ToString();
                    UpdateTitle(author, cover_type);
                }
            }
            
        }

        private void cover_type_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (author_cmbx.SelectedIndex!=-1)
            {
                string author = author_cmbx.SelectedItem.ToString();
                string cover_type = cover_type_cmbx.SelectedItem.ToString();
                if (!string.IsNullOrEmpty(author) && !string.IsNullOrEmpty(cover_type))
                {
                    UpdateTitle(author, cover_type);
                }
            }
            
        }
    }
}
