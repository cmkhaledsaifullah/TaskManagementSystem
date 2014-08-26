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
    public class ShowProject
    {
        public string[] projectDisplay(string username)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            int counter=0;
            String[] info=new String[10];
            try
            {
                
                //1st Person
                String quary = "select * from tbl_project where people1username='" + username + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info[counter++] = reader["project"].ToString();

                    }
                }

                //2nd person
                quary = "select * from tbl_project where people2username='" + username + "'";
                cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader1 = cmd.ExecuteReader())
                {
                    while (reader1.Read())
                    {
                        info[counter++] = reader1["project"].ToString();
                    }
                }

                //3rd person
                quary = "select * from tbl_project where people3username='" + username + "'";
                cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader2 = cmd.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        info[counter++] = reader2["project"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();

           return info;


            
        }
    }
}
