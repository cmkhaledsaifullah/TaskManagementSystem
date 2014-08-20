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
        
        public Add_Project()
        {
            InitializeComponent();
        }

        public Add_Project(string username)
        {
            this.Username = username;
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            listView_search.Controls.Clear();



            SearchingPeople sp = new SearchingPeople();
            int rows = sp.searchResult(textBox_search.Text);
            String[] name=new String[rows+1];
            String[] uname=new String[rows+1];

             name=sp.peopleDisplay(textBox_search.Text,1) ;
             uname = sp.peopleDisplay(textBox_search.Text,2);
            int n = 0;

            for (int i = 0; i <= rows; i++)
            {
                Label lbl = new Label();
                lbl.Text = name[i];
                lbl.Location = new Point(10, n);
                lbl.Size = new System.Drawing.Size(300, 30);
                listView_search.Controls.Add(lbl);

                n = n + 40;
            }

        }

        
    }
}
