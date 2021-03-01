using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLinkVtAction
{
    public class VtConnection
    {
        public SqlConnection Connection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=ProjectB;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection;

        }
    }
}
