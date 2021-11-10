using Fall2020_CSC403_Project.code;
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
    public partial class VerifyExit : Form
    {
        public VerifyExit()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //System.Windows.Forms.Application.Exit();
            //System.Environment.Exit(0);
           

           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //i.e. If your label ID is lblOutput and variable is an integer name v, code will be following
            //lblOutput.Text = v.ToString();
            //label1_Click.Text = .ToString();
        }
    }
}
