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
    public partial class PlayerPicks : Form
    {
        public PlayerPicks()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sherlock Holmes has been chosen.");
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Winnie the Pooh has been chosen.");
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minotaur has been chosen.");
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Amazo has been chosen.");
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mad Hatter has been chosen.");
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Corn has been chosen.");
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_6;
        }
    }
}

