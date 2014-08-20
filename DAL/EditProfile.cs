using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BO
{
    public class EditProfile
    {
        public string editInfo(string username, string name,  string designation, string email, string phoneno, string address,string dob,string gender)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE tbl_profile SET name='" + name + "',username='" + username + "',designation='" + designation + "',email='" + email + "',phoneno='" + phoneno + "',address='" + address + "',dateofbirth='" + dob + "',gender='" + gender + "'where username='" + username + "'";

     
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return username;
        }

        public void editPassword(string username, string password)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE tbl_authenticate SET password='" + password +  "'where username='" + username + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
