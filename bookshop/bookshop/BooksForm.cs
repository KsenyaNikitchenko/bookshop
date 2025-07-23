using System.Data;
using Npgsql;

namespace bookshop
{
    public partial class BooksForm : Form
    {
        public NpgsqlConnection con;
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public BooksForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con=con;
            Update();
        }
        private void Update()
        {
            string sql = "select * from books order by id_book";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Номер";
            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Автор";
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].HeaderText = "Тип обложки";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_book_menu_Click(object sender, EventArgs e)
        {
            AddBookForm addBook = new AddBookForm(con, -1);
            addBook.ShowDialog();
            Update();
        }

        private void change_book_menu_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["id_book"].Value;
            string title=(string)dataGridView1.CurrentRow.Cells["title"].Value;
            string author=(string)dataGridView1.CurrentRow.Cells["author"].Value;
            string cover_type=(string)dataGridView1.CurrentRow.Cells["cover_type"].Value;
            AddBookForm addBook = new AddBookForm(con, id,title,author,cover_type);
            addBook.ShowDialog();
            Update();
        }

        private void delete_book_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить книгу?", "Удаление книги", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["id_book"].Value;
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand("delete from books where id_book=:id", con);
                    command.Parameters.AddWithValue("id", id);
                    command.ExecuteNonQuery();
                }
                catch { }
            }
            Update();
        }
    }
}
