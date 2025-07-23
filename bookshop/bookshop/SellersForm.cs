using System.Data;
using Npgsql;


namespace bookshop
{
    public partial class SellersForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public SellersForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        private void Update()
        {
            string sql = "select * from sellers order by id_seller";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].HeaderText = "Номер телефона";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_seller_menu_Click(object sender, EventArgs e)
        {
            AddSellerForm addSeller = new AddSellerForm(con, -1);
            addSeller.ShowDialog();
            Update();
        }

        private void change_seller_menu_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_seller"].Value;
            string name = (string)dataGridView1.CurrentRow.Cells["name"].Value;
            string phone = (string)dataGridView1.CurrentRow.Cells["phone"].Value;
            AddSellerForm addSeller = new AddSellerForm(con, id, name, phone);
            addSeller.ShowDialog();
            Update();
        }

        private void delete_seller_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить поставщика?", "Удаление поставщика", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id_seller"].Value;
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from sellers where id_seller=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            Update();
        }
    }
}
