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
using System.Media;
using System.Security.Policy;

namespace Fall2020_CSC403_Project
{
    public partial class FrmMenu : Form
    {
        private FrmCharacterSelect select = null;
        public SoundPlayer MenuAndCharacterSelection = new SoundPlayer(@"..\..\data\MenuAndCharacterSelectionAudio.wav");

        public void StartMusic()
        {
            MenuAndCharacterSelection.PlayLooping();
        }

        public void StopMusic()
        {
            MenuAndCharacterSelection.Stop();
        }
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            StopMusic();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            select = new FrmCharacterSelect();
            select.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            StartMusic();
        }
    }
}
