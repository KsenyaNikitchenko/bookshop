using Npgsql;

namespace bookshop
{
    public partial class AddSellerForm : Form
    {
        public NpgsqlConnection con;
        int id;
        public AddSellerForm(NpgsqlConnection con, int id)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            Update();
        }
        public AddSellerForm(NpgsqlConnection con, int id, string name, string phone)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            name_txtb.Text = name;
            phone_txtb.Text = phone;
            Update();
        }

        private void add_seller_btn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into sellers(name,phone) values (:name,:phone)", con);
                    command.Parameters.AddWithValue("name", name_txtb.Text);
                    command.Parameters.AddWithValue("phone", phone_txtb.Text);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("update sellers set name=:name, phone=:phone where id_seller=:id", con);
                    command.Parameters.AddWithValue("name", name_txtb.Text);
                    command.Parameters.AddWithValue("phone", phone_txtb.Text);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
        }

        private void cancel_add_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
