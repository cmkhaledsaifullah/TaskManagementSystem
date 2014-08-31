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
        LinkLabel[] lbl = new LinkLabel[100];
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
                if (label_colab2.Text.Equals(""))
                    linkLabel_remove1.Visible = false;

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

        private void linkLabel_remove2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove " + label_colab2.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;

                label_colab2.Text = label_colab3.Text;
                if (label_colab3.Text.Equals(""))
                    linkLabel_remove2.Visible = false;

                label_colab3.Text = "";
                linkLabel_remove3.Visible = false;
                for (int i = 4; i <= 5; i++)
                {
                    info[i] = info[i + 2];
                }

                info[6] = "";
                info[7] = "";
            }
        }

        private void linkLabel_remove3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to remove " + label_colab3.Text + " ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                panel_addpeople.Visible = true;
                label_colab3.Text = "";
                linkLabel_remove3.Visible = false;
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
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[0];
                info[3] = name[0];
                label_colab1.Text = name[0];
                linkLabel_remove1.Left = label_colab1.Right + 10;
                linkLabel_remove1.Visible = true;
                listView_search.Controls.Remove(lbl[0]);
                
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[0];
                info[5] = name[0];
                label_colab2.Text = name[0];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[0]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[0];
                info[7] = name[0];
                label_colab3.Text = name[0];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[0]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }

        }

        private void lbl2Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[1];
                info[3] = name[1];
                label_colab1.Text = name[1];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[1]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[1];
                info[5] = name[1];
                label_colab2.Text = name[1];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[1]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[1];
                info[7] = name[1];
                label_colab3.Text = name[1];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[1]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[2];
                info[3] = name[2];
                label_colab1.Text = name[2];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[2]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[2];
                info[5] = name[2];
                label_colab2.Text = name[2];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[2]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[2];
                info[7] = name[2];
                label_colab3.Text = name[2];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[2]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[3];
                info[3] = name[3];
                label_colab1.Text = name[3];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[3]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[3];
                info[5] = name[3];
                label_colab2.Text = name[3];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[3]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[3];
                info[7] = name[3];
                label_colab3.Text = name[3];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[3]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[4];
                info[3] = name[4];
                label_colab1.Text = name[4];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[4]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[4];
                info[5] = name[4];
                label_colab2.Text = name[4];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[4]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[4];
                info[7] = name[4];
                label_colab3.Text = name[4];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[4]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[5];
                info[3] = name[5];
                label_colab1.Text = name[5];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[5]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[5];
                info[5] = name[5];
                label_colab2.Text = name[5];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[5]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[5];
                info[7] = name[5];
                label_colab3.Text = name[5];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[5]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[6];
                info[3] = name[6];
                label_colab1.Text = name[6];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[6]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[6];
                info[5] = name[6];
                label_colab2.Text = name[6];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[6]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[6];
                info[7] = name[6];
                label_colab3.Text = name[6];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[6]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[7];
                info[3] = name[7];
                label_colab1.Text = name[7];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[7]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[7];
                info[5] = name[7];
                label_colab2.Text = name[7];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[7]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[1];
                info[7] = name[1];
                label_colab3.Text = name[1];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[1]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[8];
                info[3] = name[8];
                label_colab1.Text = name[8];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[8]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[8];
                info[5] = name[8];
                label_colab2.Text = name[8];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[8]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[8];
                info[7] = name[8];
                label_colab3.Text = name[8];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[8]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[9];
                info[3] = name[9];
                label_colab1.Text = name[9];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[9]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[9];
                info[5] = name[9];
                label_colab2.Text = name[9];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[9]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[9];
                info[7] = name[9];
                label_colab3.Text = name[9];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[9]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[10];
                info[3] = name[10];
                label_colab1.Text = name[10];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[10]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[10];
                info[5] = name[10];
                label_colab2.Text = name[10];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[10]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[10];
                info[7] = name[10];
                label_colab3.Text = name[10];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[10]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[11];
                info[3] = name[11];
                label_colab1.Text = name[11];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[11]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[11];
                info[5] = name[11];
                label_colab2.Text = name[11];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[11]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[11];
                info[7] = name[11];
                label_colab3.Text = name[11];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[11]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[12];
                info[3] = name[12];
                label_colab1.Text = name[12];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[12]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[12];
                info[5] = name[12];
                label_colab2.Text = name[12];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[12]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[12];
                info[7] = name[12];
                label_colab3.Text = name[12];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[12]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[13];
                info[3] = name[13];
                label_colab1.Text = name[13];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[13]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[13];
                info[5] = name[13];
                label_colab2.Text = name[13];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[13]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[13];
                info[7] = name[13];
                label_colab3.Text = name[13];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[13]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

        private void lbl15Click(object sender, EventArgs e)
        {
            if (label_colab1.Text.Equals(""))
            {
                info[2] = uname[14];
                info[3] = name[14];
                label_colab1.Text = name[14];
                linkLabel_remove1.Visible = true;
                linkLabel_remove1.Left = label_colab1.Right + 10;
                listView_search.Controls.Remove(lbl[14]);
            }
            else if (label_colab2.Text.Equals(""))
            {
                info[4] = uname[14];
                info[5] = name[14];
                label_colab2.Text = name[14];
                linkLabel_remove2.Left = label_colab2.Right + 10;
                linkLabel_remove2.Visible = true;
                listView_search.Controls.Remove(lbl[14]);
            }
            else if (label_colab3.Text.Equals(""))
            {
                info[6] = uname[14];
                info[7] = name[14];
                label_colab3.Text = name[14];
                linkLabel_remove3.Left = label_colab3.Right + 10;
                linkLabel_remove3.Visible = true;
                listView_search.Controls.Remove(lbl[14]);
            }
            else
            {
                MessageBox.Show("Assaigned People exceed the limit.To insert new person please removeone!!!");
            }
        }

 
    }
}
