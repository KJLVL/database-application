using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sales : Form
    {
        string log;
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        MySqlDataAdapter adapt1 = new MySqlDataAdapter();
        MySqlCommandBuilder builder1;
        DataSet dataSet1;
        string idTrans = "";
        string idS = "";
        string emplId = "";
        int number;
        ArrayList prodId = new ArrayList();
        ArrayList prodNum = new ArrayList();
        public Sales(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            MySqlCommand c33 = new MySqlCommand("SELECT * FROM `sales`", db.getCon());
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
            adapt1 = new MySqlDataAdapter("SELECT * FROM `salestr`", db.getCon());
            builder1 = new MySqlCommandBuilder(adapt1);

            builder1.GetDeleteCommand();

            dataSet1 = new DataSet();

            adapt1.Fill(dataSet1, "salestr");
            table2.DataSource = dataSet1.Tables["salestr"];
        }
        private void relD1()
        {
            dataSet1.Tables.Clear();
            adapt1.Fill(dataSet1, "salestr");
            table2.DataSource = dataSet1.Tables["salestr"];
        }
        private void add_Click(object sender, EventArgs e)
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

            MySqlCommand c22 = new MySqlCommand("INSERT INTO `sales` (Transaction_id, Date) VALUES (@tId, @d)", db.getCon());
            DateTime dateTime = DateTime.Today;
            dateTime.ToString("yyyy/MM/dd");
            c22.Parameters.AddWithValue("tId", idTrans);
            c22.Parameters.AddWithValue("d", dateTime);
            db.openCon();
            c22.ExecuteNonQuery();

            renew();
        }
        private void addB_Click(object sender, EventArgs e)
        {
            if (err.Visible)
                err.Visible = false;
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    Convert.ToInt32(textBox1.Text).GetType();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `product_list` (Products_id, Sales_id, Number) VALUES (@prI, @puI, @num)", db.getCon());
            
                    MySqlCommand c = new MySqlCommand("SELECT `id`, `Number` FROM `product` WHERE `Name`=@n", db.getCon());
                    c.Parameters.Add("@n", MySqlDbType.VarChar).Value = comboBox1.Text;
                    db.openCon();
                    MySqlDataReader reader = c.ExecuteReader();
                    reader.Read();
                    string id = reader[0].ToString();
                    string num = reader[1].ToString();
                    prodId.Add(id);
                    reader.Close();
                    if (Convert.ToInt32(num) > Convert.ToInt32(textBox1.Text))
                    {
                        MySqlCommand c1 = new MySqlCommand("SELECT `id` FROM `sales` WHERE `Transaction_id`=@ti", db.getCon());
                        c1.Parameters.Add("@ti", MySqlDbType.VarChar).Value = idTrans;
                        db.openCon();
                        MySqlDataReader readerr = c1.ExecuteReader();
                        readerr.Read();
                        idS = readerr[0].ToString();
                        readerr.Close();
                        db.openCon();

                        MySqlDataReader reader1 = c1.ExecuteReader();
                        reader1.Read();
                        string id1 = reader1[0].ToString();
                        reader1.Close();

                        command.Parameters.AddWithValue("prI", id);
                        command.Parameters.AddWithValue("puI", id1);
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
                        MySqlCommand c2 = new MySqlCommand("UPDATE `sales` SET `Price`=" + number + " WHERE `Transaction_id`=" + idTrans, db.getCon());
                        db.openCon();
                        c2.ExecuteNonQuery();
                        table = new DataTable();
                        adapt = new MySqlDataAdapter();
                    }
                    else
                    {
                        err.Visible = true;
                        err.Text = "Не хватает товара. Товара на складе" + num;
                    }
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

            MySqlCommand c3 = new MySqlCommand("SELECT MAX(`id`) FROM `salestr`", db.getCon());
            db.openCon();
            MySqlDataReader reader2 = c3.ExecuteReader();
            reader2.Read();
            string id2 = reader2[0].ToString();
            reader2.Close();
            c3.ExecuteNonQuery();

            MySqlCommand c4 = new MySqlCommand("SELECT `query`, `Status`, `id` FROM `salestr` WHERE `id`=@i", db.getCon());
            c4.Parameters.Add("@i", MySqlDbType.VarChar).Value = id2;
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
                MySqlCommand c44 = new MySqlCommand("DELETE FROM `salestr` WHERE `id`=@i", db.getCon());
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

            MySqlCommand c5 = new MySqlCommand("UPDATE `sales` SET `Status`=@s WHERE `id`=" + idTrans, db.getCon());
            c5.Parameters.Add("@s", MySqlDbType.VarChar).Value = "выполнено";
            c5.ExecuteNonQuery();

            renew();
            relD1();

            MySqlCommand c33 = new MySqlCommand("SELECT MAX(`id`) FROM `salestr`", db.getCon());
            db.openCon();
            MySqlDataReader reader2 = c33.ExecuteReader();
            reader2.Read();
            string id2 = reader2[0].ToString();
            reader2.Close();
            c33.ExecuteNonQuery();

            MySqlCommand c44 = new MySqlCommand("SELECT `query`, `Status`, `id` FROM `salestr` WHERE `id`=@i", db.getCon());
            c44.Parameters.Add("@i", MySqlDbType.VarChar).Value = id2;
            db.openCon();
            MySqlDataReader reader222 = c44.ExecuteReader();

            reader222.Read();
            string q = reader222[0].ToString();
            string stat = reader222[1].ToString();
            string idrow = reader222[2].ToString();
            reader222.Close();
            c4.ExecuteNonQuery();

            if (q == "update" && stat == "")
            {
                MySqlCommand c444 = new MySqlCommand("DELETE FROM `salestr` WHERE `id`=@i", db.getCon());
                c444.Parameters.Add("@i", MySqlDbType.VarChar).Value = idrow;
                c444.ExecuteNonQuery();
            }

            renew();
            relD1();

            foreach (string i in prodId)
            {
                MySqlCommand c22 = new MySqlCommand("SELECT `Number` FROM `product` WHERE `id`=" + i, db.getCon());
                MySqlDataReader reader22 = c22.ExecuteReader();
                reader22.Read();
                string number = reader22[0].ToString();
                reader22.Close();
                int n = Convert.ToInt32(number) - Convert.ToInt32(prodNum[0]);
                MySqlCommand c3 = new MySqlCommand("UPDATE `product` SET `Number`=" + n + " WHERE `id`=" + i, db.getCon());
                c3.ExecuteNonQuery();
            }
            MySqlCommand c6 = new MySqlCommand("UPDATE `salestr` SET `Status`=@s, Price=@p WHERE `id`=" + idTrans, db.getCon());
            c6.Parameters.Add("@s", MySqlDbType.VarChar).Value = "выполнено";
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

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `sales`", db.getCon());
            adapt.SelectCommand = command1;
            adapt.Fill(table);
            table1.DataSource = table;
        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Seller s = new Seller(log);
            s.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            Auth auth = new Auth();
            auth.Show();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            loadD1();
        }

        private void table2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlCommand c1 = new MySqlCommand("SELECT `query`, `Status`, `id_row` FROM `salestr` WHERE `id`=@i", db.getCon());
            c1.Parameters.Add("@i", MySqlDbType.VarChar).Value = dataSet1.Tables["salestr"].Rows[e.RowIndex]["id"];
            db.openCon();

            int k = table2.Rows.Count - 2;

            renew();
            relD1();

            while (k >= e.RowIndex)
            {
                MySqlCommand cmd = new MySqlCommand("sales_procedure", db.getCon())
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@ide", MySqlDbType.VarChar).Value = dataSet1.Tables["salestr"].Rows[k]["id"];
                db.openCon();
                cmd.ExecuteNonQuery();

                k--;
            }

            renew();
            relD1();
        }
    }
}
