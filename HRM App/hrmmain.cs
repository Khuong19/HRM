using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM_App
{
    public partial class hrmmain : Form
    {
        public hrmmain(string isAdmin)
        {
            InitializeComponent();
            if (isAdmin == "True") { 
                mnCategory.Enabled = true;
            }
            else
            {
                mnCategory.Enabled = false;
            }

        }

        private void hrmmain_Load(object sender, EventArgs e)
        {

        }
    }
}
