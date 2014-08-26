using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Project_Name : Form
    {
        String username="";
        String projectname = "";
        public Project_Name()
        {
            InitializeComponent();
        }

        public Project_Name(string username, string projectname)
        {
            this.username = username;
            this.projectname = projectname;
            InitializeComponent();
        }

        private void Project_Name_Load(object sender, EventArgs e)
        {
        }
    }
}
