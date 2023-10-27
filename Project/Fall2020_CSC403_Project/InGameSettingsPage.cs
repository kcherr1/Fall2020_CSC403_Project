using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class InGameSettingsPage : Form
    {
        public InGameSettingsPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {   
            Hide();
        }
    }
}
