using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ProjectInfo
    {
        public string[] getInfo(string projectname)
        {
            Connection cs = new Connection();
            SqlConnection con = cs.CreateConnection();
            String[] info=new String[8];
            String quary;
            SqlCommand com;

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
