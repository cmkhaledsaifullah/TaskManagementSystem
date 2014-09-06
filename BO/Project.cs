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

            if (projectname != info[0])
            {
                String[] new_token = projectname.Split();
                String new_table = "";
                String old_table = "";
                String[] old_token = info[0].Split();
                for (int k = 0; k < new_token.Length; k++)
                {
                    new_table += new_token[k];
                }

                for (int k = 0; k < old_token.Length; k++)
                {
                    old_table += old_token[k];
                }
                ep.updateTable(old_table, new_table);
            }
        }


    }
}
