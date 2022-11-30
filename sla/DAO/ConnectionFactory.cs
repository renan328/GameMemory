using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sla.DAO
{
    class ConnectionFactory
    {
        public static MySqlConnection Create()
        {
            string connectionString = "Server=localhost;Database=JogoMemoria;Uid=root;Pwd=root;";
            return new MySqlConnection(connectionString);
        }
    }
}
