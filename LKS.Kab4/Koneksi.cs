using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.Kab4
{
    internal class Koneksi
    {
        public SqlConnection Getconn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=SAMS-PC\SQLSAMS; Initial Catalog=LKS.Kab2; Integrated Security=True";
            return conn;
        }
    }
}
