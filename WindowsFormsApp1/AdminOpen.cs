using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminOpen : Form
    {
        string log;
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        public AdminOpen(string login)
        {
            log = login;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }        
        private void employeeB_Click(object sender, EventArgs e)
        {
            tableP.Columns.Clear();
            table.Clear();
            table.Columns.Clear();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `employee`", db.getCon());
            adapt.SelectCommand = command;
            adapt.Fill(table);
            tableP.DataSource = table;
            for (int i = 0; i < tableP.Columns.Count; i++)
                tableP.Columns[i].ReadOnly = true;
        }
        private void selesP_Click(object sender, EventArgs e)
        {
            tableP.Columns.Clear();
            table.Clear();
            table.Columns.Clear();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `sales`", db.getCon());
            adapt.SelectCommand = command;
            adapt.Fill(table);
            tableP.DataSource = table;
            for (int i = 0; i < tableP.Columns.Count; i++)
                tableP.Columns[i].ReadOnly = true;
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
            Admin adminO = new Admin(log);
            adminO.Show();
        }
    }
}