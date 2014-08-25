using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class SearchPeople
    {
        string[] name = new string[100000];
        string[] uname = new string[1000000];


        public SearchPeople(string[] name, string[] uname)
        {
            this.name = name;
            this.uname = uname;
        }


        public int nameCheck(string name)
        {
            int rows = 0;

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                string query = "Select * from tbl_profile where name like '%" + name + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                rows = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rows;
        }
        
        public string[] showingData(string username,int flag)
        {
            
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            string query = "Select * from tbl_profile where name like '%" + username + "%'";
            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader reader = com.ExecuteReader();
            for (int i = 1; reader.Read(); i++)
            {
                name[i] = reader[1].ToString();
                uname[i] = reader[0].ToString();
            }
            reader.Close();
            con.Close();
            if (flag == 1)
            {
                return name;
            }

            else
            {
                return uname;
            }

        }
    }
}
