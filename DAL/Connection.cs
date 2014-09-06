using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        public SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection();
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Literature\KU\3rd Year\2nd Term\Software Engineering\Lab Work\db_task.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            return con;
        }
    }
}
