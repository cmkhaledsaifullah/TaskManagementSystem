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
    public partial class Home : Form
    {
        String username = "110231";
        public Home()
        {
            InitializeComponent();
        }

        public Home(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Project pj = new Project();
            List<string> info = pj.showingProject(username);
            int n = 0;
            int length = info.Count;
            for (int i = 0; i < length; i++)
            {
                Label lbl = new Label();
                lbl.Text = info[i];
                lbl.Location = new Point(10, n);
                lbl.Size = new System.Drawing.Size(300, 30);
                listView_projects.Controls.Add(lbl);


                n = n + 40;
            }
        }

        private void ToolStripMenuItem_viewprofile_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile(username);
            this.Hide();
            pf.Show();
        }

        private void ToolStripMenuItem_editprofile_Click(object sender, EventArgs e)
        {
            Edit_Profile ep = new Edit_Profile(username);
            this.Hide();
            ep.Show();
        }

        private void ToolStripMenuItem_changepassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Confirmation pc = new Password_Confirmation(username);
            pc.Show();
        }

        private void ToolStripMenuItem_addproject_Click(object sender, EventArgs e)
        {
            Add_Project ap = new Add_Project(username);
            ap.Show();
        }

        private void ToolStripMenuItem_project_Click(object sender, EventArgs e)
        {

        }


    }
}
