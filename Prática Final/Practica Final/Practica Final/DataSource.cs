using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practica_Final
{
    class DataSource
    {
        public static SqlConnection Connect()
        {
            SqlConnection Conn = new SqlConnection("Data Source=DERLIN-PC\\SQLEXPRESS;Initial Catalog=registro;Integrated Security=True");
            Conn.Open();

            return Conn;

        }
    }
}
