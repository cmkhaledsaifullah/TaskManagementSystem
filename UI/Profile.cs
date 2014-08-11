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
    public partial class Profile : Form
    {
        String username="110231";
        public Profile()
        {
            InitializeComponent();
        }

        public Profile(string username)
        {
            this.username = username;
            InitializeComponent();

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DataShow ds= new DataShow();

            String[] result = ds.datashow(username);

            label_name.Text=result[0];
            label_username.Text = result[1];
            label_designation.Text = result[2];
            label_phoneno.Text = result[3];
            label_email.Text = result[4];
            label_address.Text=result[5];
            label_dob.Text = result[6];
            label_gender.Text=result[7];
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Profile ep = new Edit_Profile();
            ep.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Password_Confirmation pc = new Password_Confirmation(username);
            pc.Show();
        }
    }
}
