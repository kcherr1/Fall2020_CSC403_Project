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
    public partial class Form1 : Form
    {

        private int scrollPosition = 0;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void Timer2scroll_Tick(object sender, EventArgs e)
        {
            if (scrollPosition < maskedTextBox1.Text.Length)
            {
                maskedTextBox1.Text = maskedTextBox1.Text.Substring(1) + maskedTextBox1.Text[0];
                scrollPosition++;
            }
            else
            {
                // Stop the Timer when the scrolling reaches the end
                Timer2scroll.Stop();
            }
        }

    }
}


  



