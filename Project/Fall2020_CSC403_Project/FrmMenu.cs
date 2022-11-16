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
using WMPLib;
using System.IO;
using System.Reflection;

namespace Fall2020_CSC403_Project
{
    public partial class FrmMenu : Form
    {
        private FrmCharacterSelect select = null;
        private FrmHelp helpScreen = null;
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
            StopMusic();
            Application.Exit();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            select = new FrmCharacterSelect();
            select.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            cutscene.URL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"cutscene.mp4");
            
            cutscene.settings.autoStart = true;
            cutscene.BringToFront();
            skipBtn.BringToFront();
        }

        private void cutscene_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                cutscene.Hide();
                skipBtn.Hide();
                StartMusic();
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpScreen = new FrmHelp();
            helpScreen.Show();
        }

        private void skipBtn_Click(object sender, EventArgs e)
        {
            cutscene.Hide();

            cutscene.Ctlcontrols.stop();
            StartMusic();
            skipBtn.Hide();
        }
    }
}
