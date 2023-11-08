using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using AudioSwitcher.AudioApi.CoreAudio;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class FrmMainMenu : Form
    {
        public static FrmMainMenu instance = null;

        private FrmLevel frmLevel;
        private FrmWinScreen frmWin;
        private FrmEndScreen frmEnd;

        CoreAudioDevice defaultPlayback = new CoreAudioController().DefaultPlaybackDevice;

        public FrmMainMenu()
        {
            InitializeComponent();
            defaultPlayback.Volume = Game.volume;
            menuTheme.PlayLooping();
            this.FormClosed += (s, args) => Application.Exit();
            this.Shown += (s, args) => menuTheme.PlayLooping();
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void startGame()
        {
            this.Hide();
            menuTheme.Stop();

            frmLevel = new FrmLevel();
            frmLevel.Closed += (s, args) =>
            {
                if (frmLevel.win == true)
                {
                    frmWin = new FrmWinScreen();
                    frmWin.Show();
                    frmWin.FormClosed += (x, t) =>
                    {
                        if (frmWin.restart)
                        {
                            startGame();
                        }
                        else
                        {
                            this.Show();
                            menuTheme.PlayLooping();
                        };
                    };
                }
                else if (frmLevel.lose == true)
                {
                    frmEnd = new FrmEndScreen();
                    frmEnd.Show();
                    frmEnd.FormClosed += (x, t) =>
                    {
                        if (frmEnd.restart)
                        {
                            startGame();
                        }
                        else
                        {
                            this.Show();
                            menuTheme.PlayLooping();
                        };
                    };
                }
                else
                {
                    this.Show();
                    startMusic();
                }
            };
            frmLevel.Show();

            instance = null;
        }

        public void startMusic()
        {
            menuTheme.PlayLooping();
        }

        public void changeMusicVolume(object sender, EventArgs s)
        {
            Game.volume = volumeBar.Value;
            defaultPlayback.Volume = Game.volume;
        }
    }
}
