using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Manager : Form
    {
        string log;
        public Manager(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void openP_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerOpen adminO = new ManagerOpen(log);
            adminO.Show();
        }
        private void grP_Click(object sender, EventArgs e)
        {
            Hide();
            VacationSchedules vs = new VacationSchedules(log);
            vs.Show();
        }
        private void empP_Click(object sender, EventArgs e)
        {
            Hide();
            Employee emp = new Employee(log);
            emp.Show();
        }
        private void backB_Click(object sender, EventArgs e)
        {
            Hide();
            Auth a = new Auth();
            a.Show();
        }
    }
}