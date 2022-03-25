using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SellerOpen : Form
    {
        string log;
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        public SellerOpen(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void workB_Click(object sender, EventArgs e)
        {
            tableP.Columns.Clear();
            table.Clear();
            table.Columns.Clear();

            MySqlCommand c = new MySqlCommand("SELECT `Work_id` FROM `employee` WHERE `Login`=@l", db.getCon());
            c.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            db.openCon();
            MySqlDataReader reader = c.ExecuteReader();
            reader.Read();
            string wId = reader[0].ToString();
            reader.Close();

            MySqlCommand c1 = new MySqlCommand("SELECT * FROM `work_chedule` WHERE `id`=" + wId, db.getCon());
            adapt.SelectCommand = c1;
            adapt.Fill(table);
            tableP.DataSource = table;
            for (int i = 0; i < tableP.Columns.Count; i++)
                tableP.Columns[i].ReadOnly = true;
        }
        private void vacationB_Click(object sender, EventArgs e)
        {
            tableP.Columns.Clear();
            table.Clear();
            table.Columns.Clear();

            MySqlCommand c = new MySqlCommand("SELECT `id` FROM `employee` WHERE `Login`=@l", db.getCon());
            c.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            db.openCon();
            MySqlDataReader reader = c.ExecuteReader();
            reader.Read();
            string id = reader[0].ToString();
            reader.Close();

            MySqlCommand c1 = new MySqlCommand("SELECT * FROM `vacation_schedule` WHERE `Employee_id`=" + id, db.getCon());
            adapt.SelectCommand = c1;
            adapt.Fill(table);
            tableP.DataSource = table;
            for (int i = 0; i < tableP.Columns.Count; i++)
                tableP.Columns[i].ReadOnly = true;
        }
        private void backB_Click(object sender, EventArgs e)
        {
            Hide();
            Seller s = new Seller(log);
            s.Show();
        }
    }
}
