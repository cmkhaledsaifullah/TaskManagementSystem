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
    public partial class Edit_Project_Info : Form
    {
        String[] info = new String[8];
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
        }
    }
}
