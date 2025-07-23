using Npgsql;
namespace bookshop
{
    public partial class Form1 : Form
    {
        public NpgsqlConnection con;
        public Form1()
        {
            InitializeComponent();
            MyLoad();
        }
        
        public void MyLoad()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            con = new NpgsqlConnection("Server=localhost; Port=5432; UserID=postgres; Password=postpass; Database=Bookshop");
            con.Open();
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            BooksForm books = new BooksForm(con);
            books.ShowDialog();
        }

        private void selers_btn_Click(object sender, EventArgs e)
        {
            SellersForm sellers = new SellersForm(con);
            sellers.ShowDialog();
        }

        private void iinvoice_btn_Click(object sender, EventArgs e)
        {
            IncomingInvoiceForm incomingInvoice = new IncomingInvoiceForm(con);
            incomingInvoice.ShowDialog();
        }

        private void sinvoice_btn_Click(object sender, EventArgs e)
        {
            SalesInvoiceForm salesInvoice = new SalesInvoiceForm(con);
            salesInvoice.ShowDialog();
        }

        private void inventory_management_btn_Click(object sender, EventArgs e)
        {
            InventyryManagementForm inventyry=new InventyryManagementForm(con);
            inventyry.ShowDialog();
        }
    }
}
