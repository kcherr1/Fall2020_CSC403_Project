using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmPBDeath : Form
    {
        public SoundPlayer DeathAudio = new SoundPlayer(@"..\..\data\DeathByHoleAudio.wav");

        public FrmPBDeath()
        {
            InitializeComponent();
        }
        public void StartMusic()
        {
            DeathAudio.Play();
        }
        public void StopMusic()
        {
            DeathAudio.Stop();
        }
        private void menuBtn_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            StopMusic();
            menu.Show();
            this.Close();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmPBDeath_Load(object sender, EventArgs e)
        {
            StartMusic();
        }
    }
}
