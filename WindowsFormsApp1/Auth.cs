using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Auth : Form
    {
        ArrayList lp = new ArrayList();
        bool status = false;
        DB db = new DB();

        public Auth()
        {
            InitializeComponent();
            passT.AutoSize = false;
            passT.Size = new Size(this.passT.Size.Width, this.loginT.Size.Height);

            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void loginB_Click(object sender, EventArgs e)
        {
            string loginU = loginT.Text;
            string passU = passT.Text;
            
            for (int i = 0; i < lp.Count; i++)
            {
                if (lp[i].ToString() == loginU && lp[i + 1].ToString() == passU)
                {
                    status = true;
                    MySqlCommand c11 = new MySqlCommand("SELECT `Status` FROM `employee` WHERE `Password`=" + passU, db.getCon());
                    db.openCon();
                    MySqlDataReader reader1 = c11.ExecuteReader();
                    reader1.Read();
                    string st = reader1[0].ToString();
                    reader1.Close();

                    if (loginU == "admin" && passU == "1" && st == "работник")
                    {
                        Hide();
                        Admin admin = new Admin(loginU);
                        admin.Show();

                    }
                    else if (loginU == "manager" && passU == "2" && st == "работник")
                    {
                        Hide();
                        Manager manager = new Manager(loginU);
                        manager.Show();
                    }
                    else if ((loginU == "seller" && passU == "3") || (loginU == "seller" || passU == "33") && st == "работник")
                    {
                        Hide();
                        Seller seller = new Seller(loginU);
                        seller.Show();
                    }
                }
            }
            if (!status)
                MessageBox.Show("Пользователь не найден");
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand c = new MySqlCommand("SELECT `Login`, `Password` FROM `employee`", db.getCon());
                db.openCon();
                MySqlDataReader reader = c.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        lp.Add(reader[0].ToString());
                        lp.Add(reader[1].ToString());
                    }
                }
                reader.Close();
            }
            catch
            {

            }
        }
    }
}
