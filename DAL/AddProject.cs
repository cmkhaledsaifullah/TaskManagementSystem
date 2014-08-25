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
    public class AddProject
    {
        public void projectAdd(string projecttitle,string description,string uname1,string name1,string uname2,string name2, string uname3,string name3)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {

                String query = "INSERT INTO tbl_project VALUES('" + projecttitle + "','" +description + "','" + uname1 + "','" +name1 + "','" + uname2 + "','" +name2 + "','" + uname3 + "','" + name3 + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Added!!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.Close();
        }

        public int checkProject(string projecttitle)
        {
            int rows = 0;

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "select * from tbl_project where project='" + projecttitle + "'";
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
            con.Close();
            return rows;
        }

        public void createProjectTable(string tablename)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String quary = "CREATE TABLE " + tablename +
                            "("
                            + "username varchar(255),"
                            + "name varchar(255),"
                            + "assaignedwork varchar(255),"
                            + "duedate varchar(255))";

                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Table Created");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }
    }
}
