using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ToDoListFunction
    {
        public void addToDo(string username, string name, string todo, string date, string table)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {

                String query = "INSERT INTO "+table+" VALUES('" + username + "','" + name + "','" + todo + "','" + date + "','" + "false" +  "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Assaigned Work Added!!!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
