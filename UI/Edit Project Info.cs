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
    public partial class Edit_Project_Info : Form
    {
        String[] info = new String[8];
        String[] name = new String[20];
        String[] uname = new String[20];
        LinkLabel[] lbl = new LinkLabel[20];
        int rows = 0;
        String username = "";
        
        public Edit_Project_Info()
        {
            InitializeComponent();
        }

        public Edit_Project_Info(string[] info,string username)
        {
            this.info = info;
            this.username = username;
            InitializeComponent();

            for (int i = 0; i < 100; i++)
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

        

        private void Edit_Project_Info_Load(object sender, EventArgs e)
        {
            panel_addpeople.Visible = false;

            textBox_name.Text = info[0];
            richTextBox_description.Text = info[1];
            if (!info[3].Equals(""))
            {
                label_colab1.Text = info[3];
                linkLabel_remove1.Left = label_colab1.Right+10;
            }
            if (!info[5].Equals(""))
            {
                label_colab2.Text = info[5];
                linkLabel_remove2.Left = label_colab2.Right + 10;
            }
            if (!info[7].Equals(""))
            {
                label_colab3.Text = info[7];
                linkLabel_remove3.Left = label_colab3.Right + 10;
            }
        }

        private void linkLabel_remove1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove "+label_colab1.Text+" ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;
                
                label_colab1.Text = label_colab2.Text;
                label_colab2.Text = label_colab3.Text;
                label_colab3.Text = "";
                linkLabel_remove3.Visible = false;
                for (int i = 2; i <= 5; i++)
                {
                    info[i] = info[i + 2];
                }

                info[6] = "";
                info[7] = "";
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listView_search.Controls.Clear();



            SearchingPeople sp = new SearchingPeople();
            rows = sp.searchResult(textBox_search.Text);
            name = new String[rows + 1];
            uname = new String[rows + 1];

            name = sp.peopleDisplay(textBox_search.Text, 1);
            uname = sp.peopleDisplay(textBox_search.Text, 2);
            int n = 0;

            for (int i = 0; i <= rows; i++)
            {

                //lbl[i] = new LinkLabel();
                lbl[i].Text = name[i];
                lbl[i].Location = new Point(10, n);
                lbl[i].Size = new System.Drawing.Size(300, 30);
                listView_search.Controls.Add(lbl[i]);


                n = n + 40;
            }
        }


        private void lbl1Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl2Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl15Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
