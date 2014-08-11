using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Home : Form
    {
        String username = "110231";
        public Home()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_viewprofile_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            this.Hide();
            pf.Show();
        }

        private void ToolStripMenuItem_editprofile_Click(object sender, EventArgs e)
        {
            Edit_Profile ep = new Edit_Profile();
            this.Hide();
            ep.Show();
        }

        private void ToolStripMenuItem_changepassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Confirmation pc = new Password_Confirmation(username);
            pc.Show();
        }
    }
}
