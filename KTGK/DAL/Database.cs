using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-JLT1UUT\SQLEXPRESS;Initial Catalog=KTGK;Integrated Security=True");
        }

    }
    public class Database
    {

    }
}
