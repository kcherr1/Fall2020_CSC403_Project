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
using AudioSwitcher.AudioApi.CoreAudio;


namespace Fall2020_CSC403_Project
{
    public partial class FrmPause : Form
    {
        CoreAudioDevice defaultPlayback = new CoreAudioController().DefaultPlaybackDevice;

        public FrmPause()
        {
            InitializeComponent();
            defaultPlayback.Volume = Game.volume;

        }

        private void resume_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void changeMusicVolume(object sender, EventArgs s)
        {
            Game.volume = volumeBar.Value;
            defaultPlayback.Volume = Game.volume;
        }
    }
}
