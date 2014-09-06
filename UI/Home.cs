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
        String username = "";
        LinkLabel[] lbl=new LinkLabel[100];
        public Home()
        {
            InitializeComponent();
        }

        public Home(string username)
        {
            this.username = username;
            InitializeComponent();
            for (int i = 0; i < 100;i++ )
            {
                lbl[i] = new LinkLabel();
            }

            lbl[0].Click += new System.EventHandler(lbl1Click);
            lbl[1].Click += new System.EventHandler(lbl2Click);
            lbl[2].Click += new System.EventHandler(lbl3Click);
            lbl[3].Click += new System.EventHandler(lbl4Click);
            lbl[4].Click += new System.EventHandler(lbl5Click);
            lbl[5].Click += new System.EventHandler(lbl6Click);
            lbl[6].Click += new System.EventHandler(lbl7Click);
            lbl[7].Click += new System.EventHandler(lbl8Click);
            lbl[8].Click += new System.EventHandler(lbl9Click);
            lbl[9].Click += new System.EventHandler(lbl10Click);
            lbl[10].Click += new System.EventHandler(lbl11Click);
            lbl[11].Click += new System.EventHandler(lbl12Click);
            lbl[12].Click += new System.EventHandler(lbl13Click);
            lbl[13].Click += new System.EventHandler(lbl14Click);
            lbl[14].Click += new System.EventHandler(lbl15Click);
        }



        private void Home_Load(object sender, EventArgs e)
        {
            Project pj = new Project();
            String[] info = pj.showingProject(username);
            int n = 0;
            int length = info.Length;

            if (info != null && info.Length > 0)
            {

                for (int i = 0; i < length; i++)
                {
                    lbl[i].Text = info[i];
                    lbl[i].Location = new Point(10, n);
                    lbl[i].Size = new System.Drawing.Size(300, 30);
                    listView_projects.Controls.Add(lbl[i]);


                    n = n + 40;
                }
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


        private void lbl1Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[0].Text);
            pn.Text = lbl[0].Text;
            pn.Show();
        }

        private void lbl2Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[1].Text);
            pn.Text = lbl[1].Text;
            pn.Show();
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[2].Text);
            pn.Text = lbl[2].Text;
            pn.Show();
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[3].Text);
            pn.Text = lbl[3].Text;
            pn.Show();
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[4].Text);
            pn.Text = lbl[4].Text;
            pn.Show();
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[5].Text);
            pn.Text = lbl[5].Text;
            pn.Show();
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[6].Text);
            pn.Text = lbl[6].Text;
            pn.Show();
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[7].Text);
            pn.Text = lbl[7].Text;
            pn.Show();
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[8].Text);
            pn.Text = lbl[8].Text;
            pn.Show();
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[9].Text);
            pn.Text = lbl[9].Text;
            pn.Show();
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[10].Text);
            pn.Text = lbl[10].Text;
            pn.Show();
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[11].Text);
            pn.Text = lbl[11].Text;
            pn.Show();
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[12].Text);
            pn.Text = lbl[12].Text;
            pn.Show();
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[13].Text);
            pn.Text = lbl[13].Text;
            pn.Show();
        }

        private void lbl15Click(object sender, EventArgs e)
        {
            Project_Name pn = new Project_Name(username, lbl[14].Text);
            pn.Text = lbl[14].Text;
            pn.Show();
        }

    }
}
