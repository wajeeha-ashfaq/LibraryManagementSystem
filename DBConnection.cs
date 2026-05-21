using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class DBConnection
    {
        string connectionString =
           "server=localhost;database=LibraryManagementSystem;uid=root;pwd=w@53548@sql;";

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
