using Npgsql;
using System.Data;

namespace bookshop
{
    public partial class InventyryManagementForm : Form
    {
        public NpgsqlConnection con;
        DataTable sellerDT = new DataTable();
        DataSet sellerDS = new DataSet();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public InventyryManagementForm(NpgsqlConnection con)
        {
            InitializeComponent();
            this.con = con;
            Update();
        }
        private void Update()
        {
            string sql = "select * from sellers order by name";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con);
            sellerDS.Reset();
            da.Fill(sellerDS);
            sellerDT = sellerDS.Tables[0];
            seller_cmbx.DataSource = sellerDT;
            seller_cmbx.DisplayMember = "name";
            seller_cmbx.ValueMember = "id_seller";
        }

        private void calculate_order_size_btn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lead_time_txtb.Text, out int lead_time) &&
                int.TryParse(delivery_delay_txtb.Text, out int delivery_delay_time) &&
                int.TryParse(order_spacing_txtb.Text, out int order_spacing_time) &&
                seller_cmbx.SelectedIndex != -1)
            {
                DateTime order_day = dateTimePicker1.Value.Date;
                DateTime days_before = order_day.AddDays(-order_spacing_time);
                int working_days = CalculateWorkingDays(days_before, order_day);

                string sql = "select income_content.book_id, outcome, (income-outcome) as inventory " +
                    "from (select book_id, sum(quantity) as income, avg(price) as meanprice from (select book_id, price, " +
                    "quantity from incoming_invoice_content where iinvoice_id=(select id_iinvoice from incoming_invoice where " +
                    "seller_id=@seller_id)) group by book_id) income_content join (select book_id, round(avg(quantity)) as outcome " +
                    "from sales_invoice_content group by book_id) outcome_content on (income_content.book_id=outcome_content.book_id)";
                NpgsqlCommand command = new NpgsqlCommand(sql, con);
                command.Parameters.Add("@seller_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = seller_cmbx.SelectedValue;
                command.ExecuteNonQuery();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    DataColumn daily_consumption = new DataColumn("daily_consumption", typeof(double));//дневное потребление
                    dataTable.Columns.Add(daily_consumption);
                    DataColumn guaranted_stok = new DataColumn("guaranted_stok", typeof(double));//гарантийный запас
                    dataTable.Columns.Add(guaranted_stok);
                    DataColumn expected_consumption_over_order = new DataColumn("expected_consumption_over_order", typeof(double));//ожидаемое потребление
                    dataTable.Columns.Add(expected_consumption_over_order);
                    DataColumn maximum_desirable_level = new DataColumn("maximum_desirable_level", typeof(double));//максю желаемый уровень
                    dataTable.Columns.Add(maximum_desirable_level);
                    DataColumn order_size = new DataColumn("order_size", typeof(double));//размер заказа
                    dataTable.Columns.Add(order_size);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        double outcome = double.Parse(row["outcome"].ToString());
                        double d_comsumption = outcome / working_days;
                        row["daily_consumption"] = d_comsumption;
                        double g_stok= d_comsumption * delivery_delay_time;
                        row["guaranted_stok"] = g_stok;
                        double e_consumptoin = d_comsumption * lead_time;
                        row["expected_consumption_over_order"] = e_consumptoin;
                        double m_level = g_stok + order_spacing_time * e_consumptoin;
                        row["maximum_desirable_level"] = Math.Round(m_level, MidpointRounding.AwayFromZero);
                        double size = m_level - outcome + e_consumptoin;
                        if (size > 0)
                            row["order_size"] = Math.Round(size, MidpointRounding.AwayFromZero);
                        else
                            row["order_size"] = 0;
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[0].HeaderText = "Артикул книги";
                    dataGridView1.Columns[0].Width = 120;
                    dataGridView1.Columns[1].HeaderText = "Расходы";
                    dataGridView1.Columns[1].Width = 120;
                    dataGridView1.Columns[2].HeaderText = "Остаток на складе";
                    dataGridView1.Columns[2].Width = 120;
                    dataGridView1.Columns[3].HeaderText = "Ежедневный расход";
                    dataGridView1.Columns[3].Width = 130;
                    dataGridView1.Columns[4].HeaderText = "Гарантийный запас";
                    dataGridView1.Columns[4].Width = 130;
                    dataGridView1.Columns[5].HeaderText = "Ожидаемое потребление";
                    dataGridView1.Columns[5].Width = 130;
                    dataGridView1.Columns[6].HeaderText = "Максимальный желательный уровень запасов";
                    dataGridView1.Columns[6].Width = 160;
                    dataGridView1.Columns[7].HeaderText = "Размер заказа";
                    dataGridView1.Columns[7].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
                    dataGridView1.Columns[7].Width = 120;
                }
            }
            else
            {
                MessageBox.Show("Вы ввели некорректные данные!");
            }
        }
        public static int CalculateWorkingDays(DateTime startDate, DateTime endDate)
        {
            int totalDays = (int)Math.Ceiling((endDate - startDate).TotalDays);
            int workingDays = 0;

            for (int i = 0; i <= totalDays; i++)
            {
                DateTime currentDate = startDate.AddDays(i);
                if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            return workingDays;
        }
    }
}
