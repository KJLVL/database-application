using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Product : Form
    {
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt;
        MySqlCommandBuilder builder;
        DataSet dataSet;
        string log;
        bool newRowAdd = false;
        public Product(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            table = new DataTable();
            adapt = new MySqlDataAdapter();

            MySqlCommand c1 = new MySqlCommand("SELECT `Title` FROM `category`", db.getCon());
            adapt.SelectCommand = c1;
            adapt.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string n = table.Rows[i][0].ToString();
                t1.Items.Add(n);
            }
            
            t1.AutoCompleteSource = AutoCompleteSource.ListItems;
            t1.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        private void loadD()
        {
            adapt = new MySqlDataAdapter("SELECT *, 'Delete' AS `Редактирование` FROM `product`", db.getCon());
            builder = new MySqlCommandBuilder(adapt);

            builder.GetDeleteCommand();
            builder.GetUpdateCommand();
            builder.GetInsertCommand();

            dataSet = new DataSet();

            adapt.Fill(dataSet, "product");
            table1.DataSource = dataSet.Tables["product"];

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[6, i] = lc;
            }
        }
        private void relD()
        {
            dataSet.Tables.Clear();

            adapt.Fill(dataSet, "product");
            table1.DataSource = dataSet.Tables["product"];

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[6, i] = lc;
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (error.Visible)
                error.Visible = false;
            if (!string.IsNullOrEmpty(t1.Text) && !string.IsNullOrEmpty(t2.Text) && !string.IsNullOrEmpty(t3.Text) && !string.IsNullOrEmpty(t4.Text))
            {
                try
                {
                    Convert.ToInt16(t3.Text).GetType();
                    Convert.ToInt16(t4.Text).GetType();
                
                    MySqlCommand command = new MySqlCommand("INSERT INTO `product` (Category_id, Name, Number, Price, Status) VALUES (@ci, @name, @num, @pr, @st)", db.getCon());

                    MySqlCommand c = new MySqlCommand("SELECT `id` FROM `category` WHERE `Title`=@t", db.getCon());
                    c.Parameters.Add("@t", MySqlDbType.VarChar).Value = t1.Text;
                    db.openCon();
                    MySqlDataReader reader = c.ExecuteReader();
                    reader.Read();
                    string idC = reader[0].ToString();
                    reader.Close();

                    command.Parameters.AddWithValue("ci", idC);
                    command.Parameters.AddWithValue("name", t2.Text);
                    command.Parameters.AddWithValue("num", t3.Text);
                    command.Parameters.AddWithValue("pr", t4.Text);
                    command.Parameters.AddWithValue("st", "в наличии");

                    db.openCon();
                    command.ExecuteNonQuery();

                    error.Visible = true;
                    error.Text = "Добавлено";
                }
                catch {
                    error.Visible = true;
                    error.Text = "Введены не правильные данные";
                    t2.Text = "";
                    t3.Text = "";
                    t4.Text = "";
                }
            }
            else
            {
                error.Visible = true;
                error.Text = "Поля должны быть заполнены!";
            }

            relD();
            t1.SelectedIndex = -1;
            t2.Text = "";
            t3.Text = "";
        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Admin adminO = new Admin(log);
            adminO.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            Auth a = new Auth();
            a.Show();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            loadD();
        }

        private void table1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string task = table1.Rows[e.RowIndex].Cells[6].Value.ToString();
                MySqlCommand c = new MySqlCommand("SELECT `Status` FROM `product` WHERE `id`=@i", db.getCon());
                c.Parameters.Add("@i", MySqlDbType.VarChar).Value = e.RowIndex + 1;
                db.openCon();
                MySqlDataReader reader = c.ExecuteReader();
                reader.Read();
                string i = reader[0].ToString();
                reader.Close();

                if (task == "Delete" && i != "отстутсвует")
                {
                    if (MessageBox.Show("Удалить этот товар?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        dataSet.Tables["product"].Rows[rowIndex]["Status"] = "отстутсвует";

                        adapt.Update(dataSet, "product");
                    }
                }
                else if (task == "Update")
                {
                    int r = e.RowIndex;

                    dataSet.Tables["product"].Rows[r]["Status"] = table1.Rows[r].Cells["Status"].Value;
                    dataSet.Tables["product"].Rows[r]["Price"] = table1.Rows[r].Cells["Price"].Value;
                    dataSet.Tables["product"].Rows[r]["Number"] = table1.Rows[r].Cells["Number"].Value;
                    dataSet.Tables["product"].Rows[r]["Name"] = table1.Rows[r].Cells["Name"].Value;
                    dataSet.Tables["product"].Rows[r]["Category_id"] = table1.Rows[r].Cells["Category_id"].Value;


                    adapt.Update(dataSet, "product");
                    table1.Rows[e.RowIndex].Cells[6].Value = "Delete";
                }
                else if (task == "Delete" && i == "отстутсвует")
                {
                    MessageBox.Show("Товар уже был удален");
                }
                relD();
            }
        }

        private void table1_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (newRowAdd == false)
            {
                int rowInd = table1.SelectedCells[0].RowIndex;
                DataGridViewRow editingRow = table1.Rows[rowInd];

                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[6, rowInd] = lc;
                editingRow.Cells["Редактирование"].Value = "Update";
            }
        }
    }
}
