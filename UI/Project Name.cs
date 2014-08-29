using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;

namespace UI
{
    public partial class Project_Name : Form
    {
        String username="";
        String projectname = "";
        public Project_Name()
        {
            InitializeComponent();
        }

        public Project_Name(string username, string projectname)
        {
            this.username = username;
            this.projectname = projectname;
            InitializeComponent();
        }

        private void Project_Name_Load(object sender, EventArgs e)
        {
            Project pj = new Project();
            String[] info = new String[8];
            info = pj.showProjectInfo(projectname);
            label_projectname.Text = info[0];
            label_projectdescrip.Text = info[1];
            if (!info[3].Equals(""))
            {
                label_collab1.Text = info[3];
            }
            if (!info[5].Equals(""))
            {
                label_collab2.Text = info[5];
            }
            if (!info[7].Equals(""))
            {
                label_collab3.Text = info[7];
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Edit_Project_Info ep = new Edit_Project_Info();
            ep.Show();
            this.Hide();
        }
    }
}
