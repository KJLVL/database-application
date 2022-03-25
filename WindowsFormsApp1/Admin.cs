using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        string log;
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        public Admin(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void openP_Click_1(object sender, EventArgs e)
        {
            Hide();
            AdminOpen adminO = new AdminOpen(log);
            adminO.Show();
        }
        private void prB_Click_3(object sender, EventArgs e)
        {
            Hide();
            Product admin = new Product(log);
            admin.Show();
        }
        private void purP_Click_2(object sender, EventArgs e)
        {
            Hide();
            Purchase admin = new Purchase(log);
            admin.Show();
        }
        private void backB_Click(object sender, EventArgs e)
        {
            Hide();
            Auth a = new Auth();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = "D:\\university\\3\\1sem\\БД\\b\\WindowsFormsApp1\\exp.exe";
                myProcess.Start();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Process myProcess = new Process())
            {
                myProcess.StartInfo.FileName = "D:\\university\\3\\1sem\\БД\\b\\WindowsFormsApp1\\imp.exe";
                myProcess.Start();
            }
        }
    }
}
