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
    public partial class Add_Project : Form
    {
        String Username = "";
        int rows = 0;
        int counter = 0;
        LinkLabel[] lbl = new LinkLabel[100];
        LinkLabel[] lbl_assign=new LinkLabel[3];
        
        public Add_Project()
        {
            InitializeComponent();
        }

        public Add_Project(string username)
        {
            this.Username = username;
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                lbl[i] = new LinkLabel();
                if (i < 3)
                {
                    lbl_assign[i] = new LinkLabel();
                }
               
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

            lbl_assign[0].Click += new System.EventHandler(lbl_assign0Click);
            lbl_assign[1].Click += new System.EventHandler(lbl_assign1Click);
            lbl_assign[2].Click += new System.EventHandler(lbl_assign2Click);

        }



        


        private void button_search_Click(object sender, EventArgs e)
        {
            listView_search.Controls.Clear();



            SearchingPeople sp = new SearchingPeople();
            rows = sp.searchResult(textBox_search.Text);
            String[] name=new String[rows+1];
            String[] uname=new String[rows+1];

             name=sp.peopleDisplay(textBox_search.Text,1) ;
             uname = sp.peopleDisplay(textBox_search.Text,2);
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



        private void lbl15Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[14];
                listView_assaignedpeople.Controls.Add(lbl[14]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl14Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[13];
                listView_assaignedpeople.Controls.Add(lbl[13]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl13Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[12];
                listView_assaignedpeople.Controls.Add(lbl[12]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl12Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[11];
                listView_assaignedpeople.Controls.Add(lbl[11]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl11Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[10];
                listView_assaignedpeople.Controls.Add(lbl[10]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl10Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[9];
                listView_assaignedpeople.Controls.Add(lbl[9]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl9Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[8];
                listView_assaignedpeople.Controls.Add(lbl[8]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl8Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[7];
                listView_assaignedpeople.Controls.Add(lbl[7]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl7Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[6];
                listView_assaignedpeople.Controls.Add(lbl[6]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl6Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[5];
                listView_assaignedpeople.Controls.Add(lbl[5]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl5Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[4];
                listView_assaignedpeople.Controls.Add(lbl[4]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl4Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[3];
                listView_assaignedpeople.Controls.Add(lbl[3]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl3Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[2];
                listView_assaignedpeople.Controls.Add(lbl[2]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl2Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[1];
                listView_assaignedpeople.Controls.Add(lbl[1]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }

        private void lbl1Click(object sender, EventArgs e)
        {
            if (listView_assaignedpeople.Controls.Count<3)
            {
                lbl_assign[counter++] = lbl[0];
                listView_assaignedpeople.Controls.Add(lbl[0]);
            }

            else
            {
                MessageBox.Show("No. of people maximum for a project is 3!!!");
            }
        }


        private void lbl_assign2Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl_assign1Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lbl_assign0Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        
    }
}
