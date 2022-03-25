using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VacationSchedules : Form
    {
        DB db = new DB();
        DataTable table = new DataTable();
        MySqlDataAdapter adapt = new MySqlDataAdapter();
        MySqlCommandBuilder builder;
        DataSet dataSet;
        string idEmp = "";
        string log;
        bool newRowAdd = false;
        static int count = 0;

        public VacationSchedules(string loginU)
        {
            log = loginU;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            table = new DataTable();
            adapt = new MySqlDataAdapter();

            MySqlCommand c1 = new MySqlCommand("SELECT `Surname` FROM `employee`", db.getCon());
            adapt.SelectCommand = c1;
            adapt.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string n = table.Rows[i][0].ToString();
                t1.Items.Add(n);
            }

            t1.AutoCompleteSource = AutoCompleteSource.ListItems;
            t1.AutoCompleteMode = AutoCompleteMode.Suggest;

            t2.Format = DateTimePickerFormat.Custom;
            t2.CustomFormat = "yyyy/MM/dd";
            t3.Format = DateTimePickerFormat.Custom;
            t3.CustomFormat = "yyyy/MM/dd";
        }
        private void loadD()
        {
            adapt = new MySqlDataAdapter("SELECT *, 'Delete' AS `Редактирование` FROM `vacation_schedule`", db.getCon());
            builder = new MySqlCommandBuilder(adapt);

            builder.GetDeleteCommand();
            builder.GetUpdateCommand();

            dataSet = new DataSet();

            adapt.Fill(dataSet, "vacation_schedule");
            table1.DataSource = dataSet.Tables["vacation_schedule"];

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[4, i] = lc;
            }
        }

        private void relD()
        {
            dataSet.Tables.Clear();

            adapt.Fill(dataSet, "vacation_schedule");
            table1.DataSource = dataSet.Tables["vacation_schedule"];

            for (int i = 0; i < table1.Rows.Count; i++)
            {
                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[5, i] = lc;
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (errorAdd.Visible)
                errorAdd.Visible = false;
            if (!string.IsNullOrEmpty(t1.Text) && !string.IsNullOrEmpty(t2.Text) && !string.IsNullOrEmpty(t3.Text))
            {
                MySqlCommand c = new MySqlCommand("SELECT `id` FROM `employee` WHERE `Surname`=@sn", db.getCon());
                c.Parameters.AddWithValue("sn", t1.Text);
                db.openCon();
                MySqlDataReader reader = c.ExecuteReader();
                reader.Read();
                idEmp = reader[0].ToString();
                reader.Close();

                MySqlCommand command = new MySqlCommand("INSERT INTO `vacation_schedule` (Employee_id, start_vacation, end_vacation, Status) VALUES (@e, @s, @v, @st)", db.getCon());
                
                command.Parameters.AddWithValue("e", idEmp);
                command.Parameters.AddWithValue("s", t2.Text);
                command.Parameters.AddWithValue("v", t3.Text);
                command.Parameters.AddWithValue("st", "актуален");
                db.openCon();
                command.ExecuteNonQuery();

                errorAdd.Visible = true;
                errorAdd.Text = "Добавлено";
            }
            else
            {
                errorAdd.Visible = true;
                errorAdd.Text = "Поля должны быть заполнены!";
            }

            relD();
            t1.Text = "";
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Hide();
            Manager mO = new Manager(log);
            mO.Show();
        }
        private void exit_Click_1(object sender, EventArgs e)
        {
            Hide();
            Auth a = new Auth();
            a.Show();
        }
        
        private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string task = table1.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (task == "Delete")
                {
                    if (MessageBox.Show("Удалить этот график?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        dataSet.Tables["vacation_schedule"].Rows[rowIndex]["Status"] = "не актуален";

                        adapt.Update(dataSet, "vacation_schedule");
                    }
                }
                else if (task == "Update")
                {
                    int r = e.RowIndex;

                    dataSet.Tables["vacation_schedule"].Rows[r]["Employee_id"] = table1.Rows[r].Cells["Employee_id"].Value;
                    dataSet.Tables["vacation_schedule"].Rows[r]["start_vacation"] = table1.Rows[r].Cells["start_vacation"].Value;
                    dataSet.Tables["vacation_schedule"].Rows[r]["end_vacation"] = table1.Rows[r].Cells["end_vacation"].Value;
                    dataSet.Tables["vacation_schedule"].Rows[r]["Status"] = table1.Rows[r].Cells["Status"].Value;

                    adapt.Update(dataSet, "vacation_schedule");
                    table1.Rows[e.RowIndex].Cells[5].Value = "Delete";
                }

                relD();
            }
        }

        private void table1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (newRowAdd == false)
            {
                int rowInd = table1.SelectedCells[0].RowIndex;
                DataGridViewRow editingRow = table1.Rows[rowInd];

                DataGridViewLinkCell lc = new DataGridViewLinkCell();
                table1[5, rowInd] = lc;
                editingRow.Cells["Редактирование"].Value = "Update";
            }
        }

        private void table1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (table1.Columns[e.ColumnIndex].Name == "start_vacation" || table1.Columns[e.ColumnIndex].Name == "end_vacation")
            {
                ShortFormDateFormat(e);
            }
        }

        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value != null)
            {
                try
                {
                    DateTime theDate = DateTime.Parse(formatting.Value.ToString());
                    String dateString = theDate.ToString("yyyy/MM/dd");
                    formatting.Value = dateString;
                    formatting.FormattingApplied = true;
                }
                catch (FormatException)
                {
                    formatting.FormattingApplied = false;
                }
            }
        }

        private void VacationSchedules_Load(object sender, EventArgs e)
        {
            loadD();
        }

    }
}
