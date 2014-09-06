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
    public partial class Edit_To_Do : Form
    {
        String[] info;
        String username;
        String name;
        String work;
        String date;
        String status;
        
        public Edit_To_Do()
        {
            InitializeComponent();
        }

        public Edit_To_Do(string[] info,string username,string name,string work,string date,string status)
        {
            this.info = info;
            this.username = username;
            this.name = name;
            this.work = work;
            this.date = date;
            this.status = status;
            InitializeComponent();
        }

        private void Edit_To_Do_Load(object sender, EventArgs e)
        {
            textBox_name.Text = work;
            textBox_assaignedto.Text = name;
            dateTimePicker_date.Value = System.DateTime.ParseExact(date,"dd MMMM yyyy",System.Globalization.CultureInfo.CreateSpecificCulture("en-us").DateTimeFormat);
            if (status.Equals("true"))
            {
                checkBox_complete.Checked = true;
            }

            if (!info[3].Equals(""))
            {
                label_colab1.Text = info[3];
                linkLabel_add_colab1.Visible = true;
                linkLabel_add_colab1.Left = label_colab1.Right + 10;

            }
            if (!info[5].Equals(""))
            {
                label_colab2.Text = info[5];
                linkLabel_add_colab2.Visible = true;
                linkLabel_add_colab2.Left = label_colab2.Right + 10;
            }
            if (!info[7].Equals(""))
            {
                label_colab3.Text = info[7];
                linkLabel_add_colab3.Visible = true;
                linkLabel_add_colab3.Left = label_colab3.Right + 10;
            }
        }

        private void linkLabel_add_colab1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_assaignedto.Text = label_colab1.Text;
            name = info[3];
            username = info[2];
        }

        private void linkLabel_add_colab2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_assaignedto.Text = label_colab2.Text;
            name = info[5];
            username = info[4];
        }

        private void linkLabel_add_colab3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_assaignedto.Text = label_colab3.Text;
            name = info[7];
            username = info[6];
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            To_Do_List td = new To_Do_List();
            if (checkBox_complete.Checked)
            {
                status = "true";
            }
            else
            {
                status = "false";
            }
            //MessageBox.Show(username+" "+name+" "+status);
            td.editToDo(username, name, textBox_name.Text, dateTimePicker_date.Value.ToString(), status, info[0],work);
        }
    }
}
