using Npgsql;
using System.Drawing;
using System.Windows.Forms;

namespace bookshop
{
    public partial class AddBookForm : Form
    {
        public NpgsqlConnection con;
        int id;
        public AddBookForm(NpgsqlConnection con, int id)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            Update();
        }
        public AddBookForm(NpgsqlConnection con, int id, string title,string author,string cover_type)
        {
            InitializeComponent();
            this.con = con;
            this.id = id;
            title_txtb.Text = title;
            author_txtb.Text = author;
            Update();
            cover_type_cmbx.SelectedIndex = cover_type_cmbx.FindString(cover_type);
            
        }

        private void add_book_btn_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("insert into books(title,author,cover_type) values (:title,:author,:cover_type)", con);
                    command.Parameters.AddWithValue("title", title_txtb.Text);
                    command.Parameters.AddWithValue("author", author_txtb.Text);
                    command.Parameters.AddWithValue("cover_type", cover_type_cmbx.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                    Close();
                }
                catch { }
            }
            else
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("update books set title=:title, author=:author, cover_type=:cover_type where id_book=:id", con);
                    command.Parameters.AddWithValue("title", title_txtb.Text);
                    command.Parameters.AddWithValue("author", author_txtb.Text);
                    command.Parameters.AddWithValue("cover_type", cover_type_cmbx.SelectedItem.ToString());
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
