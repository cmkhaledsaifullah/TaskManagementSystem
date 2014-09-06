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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void button_authenticate_Click(object sender, EventArgs e)
        {
            
            AuthenticationProcedure ap=new AuthenticationProcedure();
            if (textBox_username.Text.Equals("") || textBox_password.Text.Equals(""))
            {
                label_errmsg.Text="Please give your valid username or password!!!";
                label_errmsg.ForeColor=System.Drawing.Color.Red;
            }

            else if(ap.authenticationCheck(textBox_username.Text,textBox_password.Text))
            {
                Home hm=new Home(textBox_username.Text);
                this.Hide();
                hm.Show();
            }

            else
            {
                label_errmsg.Text="Please give your valid username or password!!!";
                label_errmsg.ForeColor=System.Drawing.Color.Red;
            }

        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration rg = new Registration();
            this.Hide();
            rg.Show();
        }
    }
}
