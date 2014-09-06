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

        public string[,] showResult(string tablename)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            String[,] info = new String[100,5];
            try
            {
                
                String quary = "select * from "+tablename+"";
                SqlCommand cmd = new SqlCommand(quary, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    for (int i = 0; reader.Read();i++ )
                    {
                        info[i,0] = reader["username"].ToString();
                        info[i,1] = reader["name"].ToString();
                        info[i,2] = reader["assaignedwork"].ToString();
                        info[i,3] = reader["duedate"].ToString();
                        info[i,4] = reader["status"].ToString();
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

        public int noOfList(string tablename)
        {

            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            int rows = 0;

            String query = "select * from " + tablename + "";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            rows = dt.Rows.Count;

            return rows;
        }

        public void updateTodo(string username, string name, string work, string date, string status, string tablename, string assaingn)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();

            try
            {
                String query = "UPDATE "+tablename+" SET username='" + username + "',name='" + name + "',assaignedwork='" + work + "',duedate='" + date + "',status='" + status +  "'where assaignedwork='" + assaingn + "'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                 MessageBox.Show(" Edited!!!!");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
