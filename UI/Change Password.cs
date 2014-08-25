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
    public partial class Change_Password : Form
    {
        String Username = "";
        
        public Change_Password()
        {
            InitializeComponent();
        }

        public Change_Password(string username)
        {
            this.Username = username;
            InitializeComponent();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (textBox_pass.Text.Equals(textBox_conpass.Text))
            {
                Edit ed = new Edit();
                ed.changePassword(Username, textBox_pass.Text);
                MessageBox.Show("Your Password has been updated!!!");
                this.Hide();
                Profile pf = new Profile(Username);
                pf.Show();
            }

            else
            {
                MessageBox.Show("Password Didnt Match !!!");
            }
            
        }
    }
}
