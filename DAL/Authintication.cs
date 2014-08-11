using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Authintication
    {
        public Boolean LoginConnection(string userName, string password)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            int rows = 0;
            string uName = userName;
            string pass = password;

            String query = "select * from tbl_authenticate where username='" + uName + "' and password='" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            rows = dt.Rows.Count;

            if (rows > 0)
                return true;
            else
                return false;

        }
    }
}
