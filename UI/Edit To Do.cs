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
    public partial class Edit_To_Do : Form
    {
        public Edit_To_Do()
        {
            InitializeComponent();
        }

        public Edit_To_Do(string[] info,string work,string date,string status,int index)
        {
            InitializeComponent();
        }
    }
}
