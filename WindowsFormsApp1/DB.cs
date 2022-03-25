using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class DB
    {
        MySqlConnection con = new MySqlConnection("server=127.0.0.1;database=petshop;port=3306;username=root;password=1234;");

        public void openCon()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void closeCon()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public MySqlConnection getCon()
        {
            return con;
        }
        
    }
}
