using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Fall2020_CSC403_Project
{
    public partial class PlayerPicks : Form
    {
        WindowsMediaPlayer Avat = new WindowsMediaPlayer();
        public PlayerPicks()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            Avat.URL = "YusShe.mp3";
            Avat.controls.play();

            MessageBox.Show("Sherlock Holmes has been chosen.");
            Properties.Settings.Default.PlayerChoice += 1;
            //string PlayerChoice = Convert.ToString(Properties.Settings.Default.PlayerChoice);
            //MessageBox.Show("Player Choice is" + PlayerChoice);
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_1;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Avat.URL = "YusWin.mp3";
            Avat.controls.play();
          
            /** if (e)
            { 
            Avat.controls.stop();
        }**/

            MessageBox.Show("Winnie the Pooh has been chosen.");
            Properties.Settings.Default.PlayerChoice += 2;
            //string PlayerChoice = Convert.ToString(Properties.Settings.Default.PlayerChoice);
            //MessageBox.Show("Player Choice is" + PlayerChoice);
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_2;
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Avat.URL = "YusMin.mp3";
            Avat.controls.play();
            MessageBox.Show("Minotaur has been chosen.");
            Properties.Settings.Default.PlayerChoice += 3;
            //string PlayerChoice = Convert.ToString(Properties.Settings.Default.PlayerChoice);
            //MessageBox.Show("Player Choice is" + PlayerChoice);
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_3;
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Avat.URL = "YusAma.mp3";
            Avat.controls.play();
            MessageBox.Show("Amazo has been chosen.");
            Properties.Settings.Default.PlayerChoice += 4;
            //string PlayerChoice = Convert.ToString(Properties.Settings.Default.PlayerChoice);
            //MessageBox.Show("Player Choice is" + PlayerChoice);
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_4;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Avat.URL = "YusMad.mp3";
            Avat.controls.play();
            MessageBox.Show("Mad Hatter has been chosen.");
            Properties.Settings.Default.PlayerChoice += 5;
            //string PlayerChoice = Convert.ToString(Properties.Settings.Default.PlayerChoice);
            //MessageBox.Show("Player Choice is" + PlayerChoice);
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_5;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Avat.URL = "YusCor.mp3";
            Avat.controls.play();

            MessageBox.Show("Corn has been chosen.");
            Properties.Settings.Default.PlayerChoice += 6;
            //string PlayerChoice = Convert.ToString(Properties.Settings.Default.PlayerChoice);
            //MessageBox.Show("Player Choice is" + PlayerChoice);
            Properties.Resources.PickedPlayer = Properties.Resources.Player_Choice_6;
            this.Close();
        }

        private void PlayerPicks_Load(object sender, EventArgs e)
        {

        }
    }
}

