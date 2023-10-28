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
    public partial class FrmWin : Form
    {
        public SoundPlayer WinAudio = new SoundPlayer(@"..\..\data\WinGameAudio.wav");

        public FrmWin()
        {
            InitializeComponent();
        }
        public void StartMusic()
        {
            WinAudio.Play();
        }
        public void StopMusic()
        {
            WinAudio.Stop();
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

        private void FrmWin_Load(object sender, EventArgs e)
        {
            StartMusic();
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            StopMusic();
            menu.Show();
            this.Close();
            
        }
    }
}
