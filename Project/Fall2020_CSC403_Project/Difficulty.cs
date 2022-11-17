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
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = (Decimal)0.75;
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = (Decimal)1;
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = (Decimal)1.75;
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Difficulty = (Decimal)2;
            Application.Restart();
        }
    }
}
