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

        public string[] showingProject(string username)
        {
            ShowProject sp = new ShowProject();
            String[] info = sp.projectDisplay(username);
            return info;
        }

        public string[] showProjectInfo(string projectName)
        {
            ShowProject sp = new ShowProject();
            String[] info = sp.projectInfo(projectName);
            return info;
        }

        public void editingProject(string[] info, string projectname)
        {
            Edit_Project ep = new Edit_Project();
            ep.updateProject(projectname, info[1], info[2], info[3], info[4], info[5], info[6], info[7], info[0]);
        }

    }
}
