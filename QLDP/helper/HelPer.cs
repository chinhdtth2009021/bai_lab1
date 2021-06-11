using System.Data;
using MySql.Data.MySqlClient;

namespace QLDP.helper
{
    public class HelPer
    {
        private static string _server = "localhost";
        private static string _database = "t2009m1";
        private static string _uid = "root";
        private static string _password = "";
        public static MySqlConnection _Connection;

        public static MySqlConnection GetConnection()
        {
            if (_Connection == null || _Connection.State == ConnectionState.Closed)
            {
                string connectionString;
                connectionString = "SERVER=" + _server + ";" + "DATABASE=" +
                                   _database + ";" + "UID=" + _uid + ";" + "PASSWORD=" + _password + ";" + "convert zero datetime=True";
                _Connection = new MySqlConnection(connectionString);
            }

            return _Connection;
        }
    }
}