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
    public partial class Password_Confirmation : Form
    {
        String username = "";
        
        public Password_Confirmation()
        {
            InitializeComponent();
        }

        public Password_Confirmation(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button_authenticate_Click(object sender, EventArgs e)
        {
            if (textBox_pass.Text.Equals(""))
            {
                label_errmsg.Text = "Please give your password!!!";
                label_errmsg.ForeColor = System.Drawing.Color.Red;
            }

            else
            {
                AuthenticationProcedure ap = new AuthenticationProcedure();

                if (ap.authenticationCheck(username, textBox_pass.Text))
                {
                    this.Hide();
                    Change_Password cp = new Change_Password(username);
                    cp.Show();
                }

                else
                {
                    label_errmsg.Text = "Password didnot match!!! ";
                    label_errmsg.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
