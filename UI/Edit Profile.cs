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
    public partial class Edit_Profile : Form
    {

        //this portion is added by sadman sobhan
        
        String username = "";

        public Edit_Profile()
        {
            InitializeComponent();
        }

        public Edit_Profile(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();

            String[] result = ds.datashow(username);

            textBox_name.Text = result[0];
            textBox_username.Text = result[1];
            textBox_designation.Text = result[2];
            textBox_phonenumber.Text = result[3];
            textBox_email.Text = result[4];
            richTextBox_address.Text = result[5];
            String dateOfBirth=result[6];
            String[] token = dateOfBirth.Split();
            comboBox_date.Text = token[0];
            comboBox_month.Text = token[1];
            comboBox_year.Text = token[2];
            String gender=result[7];

            if (gender.Equals("Male"))
            {
                radioButton_male.Checked = true;
            }

            else
            {
                radioButton_female.Checked = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            DataShow ds = new DataShow();
            String dob = comboBox_date.Text + " " + comboBox_month.Text + " " + comboBox_year.Text;
            String gender = "";

            if (radioButton_male.Checked)
            {
                gender = "Male";
            }

            else
            {
                gender = "Female";
            }

            Edit ed = new Edit();
            username=ed.editData(textBox_username.Text, textBox_name.Text, textBox_designation.Text, textBox_email.Text, textBox_phonenumber.Text, richTextBox_address.Text,dob,gender);

            MessageBox.Show("Your Information is updated!!!");

            Edit_Profile_Load(sender,e);
        }
    }
}
