using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;

namespace BO
{
    public class Project
    {
        public void addingProject(string tablename,string projecttitle, string description, string uname1, string name1, string uname2, string name2, string uname3, string name3)
        {
            AddProject ap = new AddProject();
            int rows = ap.checkProject(projecttitle);
            if (rows == 0)
            {
                ap.projectAdd(projecttitle, description, uname1, name1, uname2, name2, uname3, name3);
                ap.createProjectTable(tablename);
            }
            else
            {
                MessageBox.Show("Project Already Exists!!!");
            }
        }
    }
}
