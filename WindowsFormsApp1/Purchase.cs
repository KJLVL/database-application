using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Purchase : Form
    {
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        MySqlDataAdapter adapt1 = new MySqlDataAdapter();
        MySqlCommandBuilder builder1;
        DataSet dataSet1;
        string log;
        string idTrans = "";
        string idP = "";
        string emplId = "";
        int number;
        ArrayList prodId = new ArrayList();
        ArrayList prodNum = new ArrayList();
        public Purchase(string login)
        {
            log = login;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            MySqlCommand c33 = new MySqlCommand("SELECT * FROM `purchase`", db.getCon());
            adapt.SelectCommand = c33;
            adapt.Fill(table);
            table1.DataSource = table;
            table = new DataTable();
            adapt = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `product_list`", db.getCon());
            adapt.SelectCommand = command;
            adapt.Fill(table);
            tPurL.DataSource = table;
            table = new DataTable();
            adapt = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT `Name` FROM `product`", db.getCon());
            adapt.SelectCommand = command1;
            adapt.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                String n = table.Rows[i][0].ToString();
                comboBox1.Items.Add(n);
            }
        }

        private void loadD1()
        {
            adapt1 = new MySqlDataAdapter("SELECT * FROM `purchasetr`", db.getCon());
            builder1 = new MySqlCommandBuilder(adapt1);

            builder1.GetDeleteCommand();

            dataSet1 = new DataSet();

            adapt1.Fill(dataSet1, "purchasetr");
            table2.DataSource = dataSet1.Tables["purchasetr"];
        }
        private void relD1()
        {
            dataSet1.Tables.Clear();
            adapt1.Fill(dataSet1, "purchasetr");
            table2.DataSource = dataSet1.Tables["purchasetr"];
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            number = 0;
            MySqlCommand c1 = new MySqlCommand("SELECT `id` FROM `employee` WHERE `Login`=@l", db.getCon());
            c1.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            db.openCon();
            MySqlDataReader reader = c1.ExecuteReader();
            reader.Read();
            emplId = reader[0].ToString();
            reader.Close();
            MySqlCommand c2 = new MySqlCommand("INSERT INTO `transaction` (Employee_id) VALUES (@eId)", db.getCon());
            c2.Parameters.AddWithValue("eId", emplId);
            db.openCon();
            c2.ExecuteNonQuery();
            renew();

            MySqlCommand c11 = new MySqlCommand("SELECT MAX(`id`) FROM `transaction` WHERE `Employee_id`=" + emplId, db.getCon());
            db.openCon();

            MySqlDataReader reader1 = c11.ExecuteReader();
            reader1.Read();
            idTrans = reader1[0].ToString();
            reader1.Close();

            MySqlCommand c22 = new MySqlCommand("INSERT INTO `purchase` (Transaction_id, Date) VALUES (@tId, @d)", db.getCon());
            DateTime dateTime = DateTime.Today;
            dateTime.ToString("yyyy/MM/dd");
            c22.Parameters.AddWithValue("tId", idTrans);
            c22.Parameters.AddWithValue("d", dateTime);
            db.openCon();
            c22.ExecuteNonQuery();


            renew();
        }
        private void addP_Click_1(object sender, EventArgs e)
        {
            if (err.Visible)
                err.Visible = false;
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    Convert.ToInt16(textBox1.Text).GetType();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `product_list` (Products_id, Purchase_id, Number) VALUES (@prI, @puI, @num)", db.getCon());
                    
                    MySqlCommand c = new MySqlCommand("SELECT `id` FROM `product` WHERE `Name`=@n", db.getCon());
                    c.Parameters.Add("@n", MySqlDbType.VarChar).Value = comboBox1.Text;
                    db.openCon();
                    MySqlDataReader reader = c.ExecuteReader();
                    reader.Read();
                    string id = reader[0].ToString();
                    prodId.Add(id);
                    reader.Close();

                    MySqlCommand c1 = new MySqlCommand("SELECT `id` FROM `purchase` WHERE `Transaction_id`=@ti", db.getCon());
                    c1.Parameters.Add("@ti", MySqlDbType.VarChar).Value = idTrans;
                    db.openCon();
                    MySqlDataReader reader1 = c1.ExecuteReader();
                    reader1.Read();
                    idP = reader1[0].ToString();
                    reader1.Close();

                    command.Parameters.AddWithValue("prI", id);
                    command.Parameters.AddWithValue("puI", idP);
                    command.Parameters.AddWithValue("num", textBox1.Text);

                    prodNum.Add(textBox1.Text);
                    db.openCon();
                    command.ExecuteNonQuery();

                    MySqlCommand c22 = new MySqlCommand("SELECT `Price` FROM `product` WHERE `id`=" + id, db.getCon());
                    MySqlDataReader reader22 = c22.ExecuteReader();
                    reader22.Read();
                    string price = reader22[0].ToString();
                    reader22.Close();
                    number += Convert.ToInt32(price) * Convert.ToInt32(textBox1.Text);

                    MySqlCommand c2 = new MySqlCommand("UPDATE `purchase` SET `Price`=" + number + " WHERE `Transaction_id`=" + idTrans, db.getCon());
                    db.openCon();
                    c2.ExecuteNonQuery();
                    table = new DataTable();
                    adapt = new MySqlDataAdapter();
                }
                catch
                {
                    err.Visible = true;
                    err.Text = "Введены не правильные данные";
                    comboBox1.SelectedIndex = -1;
                    textBox1.Text = "";
                }
            }
            else
            {
                err.Visible = true;
                err.Text = "Поля должны быть заполнены!";
            }
            comboBox1.SelectedIndex = -1;
            textBox1.Text = "";

            renew();
            relD1();

            MySqlCommand c3 = new MySqlCommand("SELECT MAX(`id`) FROM `purchasetr`", db.getCon());
            db.openCon();
            MySqlDataReader reader2 = c3.ExecuteReader();
            reader2.Read();
            string id1 = reader2[0].ToString();
            reader2.Close();
            c3.ExecuteNonQuery();

            MySqlCommand c4 = new MySqlCommand("SELECT `query`, `Status`, `id` FROM `purchasetr` WHERE `id`=@i", db.getCon());
            c4.Parameters.Add("@i", MySqlDbType.VarChar).Value = id1;
            db.openCon();
            MySqlDataReader reader222 = c4.ExecuteReader();

            reader222.Read();
            string q = reader222[0].ToString();
            string stat = reader222[1].ToString();
            string idrow = reader222[2].ToString();
            reader222.Close();
            c4.ExecuteNonQuery();

            if (q == "update" && stat == "")
            {
                MySqlCommand c44 = new MySqlCommand("DELETE FROM `purchasetr` WHERE `id`=@i", db.getCon());
                c44.Parameters.Add("@i", MySqlDbType.VarChar).Value = idrow;
                c44.ExecuteNonQuery();
            }

            renew();
            relD1();
        }
        private void buyB_Click(object sender, EventArgs e)
        {
            MySqlCommand c1 = new MySqlCommand("UPDATE `transaction` SET `Status`=" + true + " WHERE `id`=" + idTrans, db.getCon());
            db.openCon();
            c1.ExecuteNonQuery();
            MySqlCommand c2 = new MySqlCommand("DELETE FROM `product_list`", db.getCon());
            MySqlCommand c4 = new MySqlCommand("ALTER table `product_list` AUTO_INCREMENT = 0", db.getCon());
            c2.ExecuteNonQuery();
            c4.ExecuteNonQuery();
            MySqlCommand c5 = new MySqlCommand("UPDATE `purchase` SET `Status`=@s WHERE `id`=" + idTrans, db.getCon());
            c5.Parameters.Add("@s", MySqlDbType.VarChar).Value = "выполнено";
            c5.ExecuteNonQuery();

            renew();
            relD1();

            MySqlCommand c33 = new MySqlCommand("SELECT MAX(`id`) FROM `purchasetr`", db.getCon());
            db.openCon();
            MySqlDataReader reader2 = c33.ExecuteReader();
            reader2.Read();
            string id1 = reader2[0].ToString();
            reader2.Close();
            c33.ExecuteNonQuery();

            MySqlCommand c7 = new MySqlCommand("SELECT `query`, `Status`, `id` FROM `purchasetr` WHERE `id`=@i", db.getCon());
            c7.Parameters.Add("@i", MySqlDbType.VarChar).Value = id1;
            db.openCon();
            MySqlDataReader reader222 = c7.ExecuteReader();

            reader222.Read();
            string q = reader222[0].ToString();
            string stat = reader222[1].ToString();
            string idrow = reader222[2].ToString();
            reader222.Close();
            c7.ExecuteNonQuery();

            if (q == "update" && stat == "")
            {
                MySqlCommand c44 = new MySqlCommand("DELETE FROM `purchasetr` WHERE `id`=@i", db.getCon());
                c44.Parameters.Add("@i", MySqlDbType.VarChar).Value = idrow;
                c44.ExecuteNonQuery();
            }

            renew();
            relD1();

            foreach (string i in prodId) {
                MySqlCommand c22 = new MySqlCommand("SELECT `Number` FROM `product` WHERE `id`=" + i, db.getCon());
                MySqlDataReader reader22 = c22.ExecuteReader();
                reader22.Read();
                string number = reader22[0].ToString();
                reader22.Close();
                int n = Convert.ToInt32(number) + Convert.ToInt32(prodNum[0]);
                MySqlCommand c3 = new MySqlCommand("UPDATE `product` SET `Number`=" + n + " WHERE `id`=" + i, db.getCon());
                c3.ExecuteNonQuery();
            }
            MySqlCommand c6 = new MySqlCommand("UPDATE `purchasetr` SET `Status`=@s, Price=@p WHERE `id`=" + idTrans, db.getCon());
            c6.Parameters.Add("@s", MySqlDbType.VarChar).Value = "отменено";
            c6.Parameters.Add("@p", MySqlDbType.VarChar).Value = number;
            c6.ExecuteNonQuery();

            prodId.Clear();
            prodNum.Clear();
            panel2.Visible = false;       

            relD1();
            renew();
        }

        private void renew()
        {
            table = new DataTable();
            adapt = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `product_list`", db.getCon());
            adapt.SelectCommand = command;
            adapt.Fill(table);
            tPurL.DataSource = table;

            table = new DataTable();
            adapt = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `purchase`", db.getCon());
            adapt.SelectCommand = command1;
            adapt.Fill(table);
            table1.DataSource = table;

        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin admin = new Admin(log);
            admin.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            loadD1();
        }

        private void table2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int k = table2.Rows.Count - 2;

            renew();
            relD1();

            while (k >= e.RowIndex)
            {
                MySqlCommand cmd = new MySqlCommand("purchase_procedure", db.getCon())
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@ide", MySqlDbType.VarChar).Value = dataSet1.Tables["purchasetr"].Rows[k]["id"];
                db.openCon();
                cmd.ExecuteNonQuery();

                k--;
            }
           

            renew();
            relD1();
        }
    }
}
