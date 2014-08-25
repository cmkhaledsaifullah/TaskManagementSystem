using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ShowData
    {
        string username = "";
        Connection cs = new Connection();
        SqlConnection con;
        string quary;
        SqlCommand com;
        String[] info = new String[20];



        public ShowData(string username)
        {
            this.username = username;
            con = cs.CreateConnection();
            quary = "select * from tbl_profile where username='" + username + "'";
            com = new SqlCommand(quary, con);
        }

        public string[] showingName()
        {

            int i = 0;
            SqlDataReader reader = com.ExecuteReader();
            reader.Read();
            info[i++] = reader["name"].ToString();
            info[i++] = reader["username"].ToString();
            info[i++] = reader["designation"].ToString();
            info[i++] = reader["email"].ToString();
            info[i++] = reader["phoneno"].ToString();
            info[i++] = reader["address"].ToString();
            info[i++] = reader["dateofbirth"].ToString();
            info[i++] = reader["gender"].ToString();
            reader.Close();
            return info;
        }

     
    }
}
