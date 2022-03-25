using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Seller : Form
    {
        string log;
        public Seller(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void openP_Click(object sender, EventArgs e)
        {
            Hide();
            SellerOpen so = new SellerOpen(log);
            so.Show();
        }
        private void prB_Click(object sender, EventArgs e)
        {
            Hide();
            Sales s = new Sales(log);
            s.Show();
        }
        private void backB_Click(object sender, EventArgs e)
        {
            Hide();
            Auth a = new Auth();
            a.Show();
        }
    }
}
