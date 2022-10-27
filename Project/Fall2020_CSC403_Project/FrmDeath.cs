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
    public partial class FrmDeath : Form
    {
        public FrmDeath()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();  // exit and start new instance
            Environment.Exit(0);    // terminates without event handlers intervening
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();   // exit application
            Environment.Exit(0);  // terminates without event handlers intervening
        }
    }
}
