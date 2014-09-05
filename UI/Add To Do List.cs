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
    public partial class Add_To_Do_List : Form
    {
        String[] info = new String[8];
        String username = "";
        String name = "";
        public Add_To_Do_List()
        {
            InitializeComponent();
        }


        public Add_To_Do_List(string[] info)
        {
            this.info = info;
            InitializeComponent();
        }

        private void Add_To_Do_List_Load(object sender, EventArgs e)
        {

            dateTimePicker_date.Format = DateTimePickerFormat.Custom;
            dateTimePicker_date.CustomFormat = "dd MMMM yyyy";

            if (!info[3].Equals(""))
            {
                label_colab1.Text= info[3];
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

        private void button_add_Click(object sender, EventArgs e)
        {

            if (textBox_name.Text.Equals("") || textBox_assaignedto.Text.Equals(""))
            {
                MessageBox.Show("Please Insert To DO Name or Assaigned Person!!!");
            }

            else
            {
                To_Do_List td = new To_Do_List();
                td.addAssaignedWork(username, name, textBox_name.Text, dateTimePicker_date.Text, info[0]);
            }
        }
    }
}
