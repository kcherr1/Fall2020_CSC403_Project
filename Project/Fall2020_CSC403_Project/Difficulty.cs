using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            File.WriteAllText(@".\Difficulty.txt", 0.75.ToString());
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\Difficulty.txt", 1.0.ToString());
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\Difficulty.txt", 1.50.ToString());
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\Difficulty.txt", 1.75.ToString());
            Application.Restart();
        }
    }
}
