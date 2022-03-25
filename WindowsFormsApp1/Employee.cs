using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Employee : Form
    {
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        MySqlCommandBuilder builder;
        DataSet dataSet;
        MySqlDataAdapter adapt1 = new MySqlDataAdapter();
        MySqlCommandBuilder builder1;
        DataSet dataSet1;
        string log;
        bool newRowAdd = false;
        HashSet<string> pos = new HashSet<string>();

        MySqlCommand command;
        public Employee(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            MySqlCommand c1 = new MySqlCommand("SELECT `Position` FROM `employee`", db.getCon());
            adapt.SelectCommand = c1;
            adapt.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string n = table.Rows[i][0].ToString();
                pos.Add(n);
            }
            foreach (string i in pos)
                t1.Items.Add(i);
            table = new DataTable();
            adapt = new MySqlDataAdapter();

            MySqlCommand c2 = new MySqlCommand("SELECT `start_day`, `end_day` FROM `work_chedule`", db.getCon());
            adapt.SelectCommand = c2;
            adapt.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string n = table.Rows[i][0].ToString();
                string n1 = table.Rows[i][1].ToString();
                t7.Items.Add(n + " - " + n1);
            }
            t1.AutoCompleteSource = AutoCompleteSource.ListItems;
            t1.AutoCompleteMode = AutoCompleteMode.Suggest;

            t7.AutoCompleteSource = AutoCompleteSource.ListItems;
            t7.AutoCompleteMode = AutoCompleteMode.Suggest;
        }
        private void loadD()
        {
            adapt = new MySqlDataAdapter("SELECT *, 'Delete' AS `Редактирование` FROM `employee`", db.getCon());
            builder = new MySqlCommandBuilder(adapt);

            builder.GetDeleteCommand();
            builder.GetUpdateCommand();
            builder.GetInsertCommand();

            dataSet = new DataSet();

            adapt.Fill(dataSet, "employee");
            table1.DataSource = dataSet.Tables["employee"];

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[8, i] = lc;
            }
        }
        private void loadD1()
        {
            adapt1 = new MySqlDataAdapter("SELECT * FROM `employeetr`", db.getCon());
            builder1 = new MySqlCommandBuilder(adapt1);

            builder1.GetDeleteCommand();

            dataSet1 = new DataSet();

            adapt1.Fill(dataSet1, "employeetr");
            table2.DataSource = dataSet1.Tables["employeetr"];
        }

        private void relD()
        {
            dataSet.Tables.Clear();
            adapt.Fill(dataSet, "employee");
            table1.DataSource = dataSet.Tables["employee"];

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[8, i] = lc;
            }
        }
        private void relD1()
        {
            dataSet1.Tables.Clear();
            adapt1.Fill(dataSet1, "employeetr");
            table2.DataSource = dataSet1.Tables["employeetr"];

        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (err.Visible)
                err.Visible = false;

            if (!string.IsNullOrEmpty(t1.Text) && !string.IsNullOrEmpty(t2.Text) && !string.IsNullOrEmpty(t3.Text) && !string.IsNullOrEmpty(t4.Text) && !string.IsNullOrEmpty(t5.Text) && !string.IsNullOrEmpty(t7.Text))
            {
                command = new MySqlCommand("INSERT INTO `employee` (Position, Name, Surname, Login, Password, Work_id, Status) VALUES (@p, @n, @sn, @l, @pas, @w, @st)", db.getCon());

                MySqlCommand c = new MySqlCommand("SELECT `id` FROM `work_chedule` WHERE `start_day`=@sd AND `end_day`=@ed", db.getCon());
                string[] days = t7.Text.Split(' ');
                Console.WriteLine(days[0]);
                c.Parameters.Add("@sd", MySqlDbType.VarChar).Value = days[0];
                c.Parameters.Add("@ed", MySqlDbType.VarChar).Value = days[2];
                db.openCon();
                MySqlDataReader reader = c.ExecuteReader();
                reader.Read();
                string id = reader[0].ToString();
                reader.Close();

                command.Parameters.AddWithValue("p", t1.Text);
                command.Parameters.AddWithValue("n", t2.Text);
                command.Parameters.AddWithValue("sn", t3.Text);
                command.Parameters.AddWithValue("l", t4.Text);
                command.Parameters.AddWithValue("pas", t5.Text);
                command.Parameters.AddWithValue("w", id);
                command.Parameters.AddWithValue("st", "работник");

                db.openCon();
                command.ExecuteNonQuery();

                err.Visible = true;
                err.Text = "Добавлено";
            }
            else
            {
                err.Visible = true;
                err.Text = "Поля должны быть заполнены!";
            }
            t1.SelectedIndex = -1;
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";
            t5.Text = "";
            t7.SelectedIndex = -1;
            relD();
            relD1();
        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Manager m = new Manager(log);
            m.Show();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Hide();
            Auth a = new Auth();
            a.Show();
        }

        private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                string task = table1.Rows[e.RowIndex].Cells[8].Value.ToString();
                MySqlCommand c = new MySqlCommand("SELECT `Status` FROM `employee` WHERE `id`=@i", db.getCon());
                c.Parameters.Add("@i", MySqlDbType.VarChar).Value = e.RowIndex + 1;
                db.openCon();
                MySqlDataReader reader = c.ExecuteReader();
                reader.Read();
                string i = reader[0].ToString();
                reader.Close();

                if (task == "Delete" && i != "уволен")
                {
                    if (MessageBox.Show("Уволить этого сотрудника?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        dataSet.Tables["employee"].Rows[rowIndex]["Status"] = "уволен";

                        adapt.Update(dataSet, "employee");
                    }
                }
                else if (task == "Update")
                {
                    int r = e.RowIndex;

                    dataSet.Tables["employee"].Rows[r]["Status"] = table1.Rows[r].Cells["Status"].Value;
                    dataSet.Tables["employee"].Rows[r]["Name"] = table1.Rows[r].Cells["Name"].Value;
                    dataSet.Tables["employee"].Rows[r]["Surname"] = table1.Rows[r].Cells["Surname"].Value;
                    dataSet.Tables["employee"].Rows[r]["Login"] = table1.Rows[r].Cells["Login"].Value;
                    dataSet.Tables["employee"].Rows[r]["Password"] = table1.Rows[r].Cells["Password"].Value;
                    dataSet.Tables["employee"].Rows[r]["Work_id"] = table1.Rows[r].Cells["Work_id"].Value;
                    dataSet.Tables["employee"].Rows[r]["Position"] = table1.Rows[r].Cells["Position"].Value;


                    adapt.Update(dataSet, "employee");
                    table1.Rows[e.RowIndex].Cells[8].Value = "Delete";
                }
                else if (task == "Delete" && i == "уволен")
                {
                    MessageBox.Show("Сотрудник уже был уволен");
                }
                relD();
                relD1();
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            loadD();
            loadD1();
        }

        private void table1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (newRowAdd == false)
            {
                int rowInd = table1.SelectedCells[0].RowIndex;
                DataGridViewRow editingRow = table1.Rows[rowInd];

                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[8, rowInd] = lc;
                editingRow.Cells["Редактирование"].Value = "Update";
            }
        }

        private void table2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlCommand c1 = new MySqlCommand("SELECT `query`, `Status`, `id_row` FROM `employeetr` WHERE `id`=@i", db.getCon());
            c1.Parameters.Add("@i", MySqlDbType.VarChar).Value = dataSet1.Tables["employeetr"].Rows[e.RowIndex]["id"];
            db.openCon();
            MySqlDataReader reader1 = c1.ExecuteReader();
            string q = "", s = "", i = "";
            while (reader1.Read())
            {
                q = reader1[0].ToString();
                s = reader1[1].ToString();
                i = reader1[2].ToString();
            }
            reader1.Close();

            MySqlCommand cmd = new MySqlCommand("employee_procedure", db.getCon())
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add("@ide", MySqlDbType.VarChar).Value = dataSet1.Tables["employeetr"].Rows[e.RowIndex]["id"];
            db.openCon();
            cmd.ExecuteNonQuery();

            relD();
            relD1();
        }
    }
}
