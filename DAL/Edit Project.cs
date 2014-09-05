using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Edit_Project
    {
        public void updateProject(string name, string description, string user1, string name1, string user2, string name2, string user3, string name3, string projectname)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE tbl_project SET project='" + name + "',projectdescription='" + description + "',people1username='" + user1 + "',people1name='" + name1 + "',people2username='" + user2 + "',people2name='" + name2 + "',people3username='" + user3 + "',people3name='" + name3 + "'where project='" + projectname + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

               // MessageBox.Show(name+" "+description+" "+user1+" "+name1+" "+user2+" "+name2+" "+user3+" "+name3+" Edited!!!!");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateTable(string oldname, string newname)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            //try
            //{
            String query = "sp_rename '" + oldname + 
                    "','" + newname + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show(oldname + " "+" Edited");
                con.Close();
            //}

            //catch (Exception ex)
            //{
                //MessageBox.Show(ex.Message);
            //}
        }
    }
}
