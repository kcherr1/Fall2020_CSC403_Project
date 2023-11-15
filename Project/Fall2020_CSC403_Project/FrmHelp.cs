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
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }



    


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHome FrmHome = new FrmHome(); // Create an instance of the instruction form
            FrmHome.ShowDialog(); // Show the instruction form as a modal dialog

            // Environment.Exit(0);
        }
    }
}
