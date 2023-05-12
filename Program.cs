using System;
using MySqlConnector;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionstring;
            MySqlConnection kapcsolat;
            connectionstring = @"server = localhost; user=root;database=proba";
            kapcsolat = new MySqlConnection(connectionstring);
            kapcsolat.Open();
            string sql = "SELECT * FROM szemely";
            MySqlCommand mSqlCmd = new MySqlCommand(sql,kapcsolat);
            MySqlDataReader adatok = mSqlCmd.ExecuteReader();
            while (adatok.Read())
            {
                Console.WriteLine(adatok[1]);
            }
            kapcsolat.Close();
        }
    }
}
