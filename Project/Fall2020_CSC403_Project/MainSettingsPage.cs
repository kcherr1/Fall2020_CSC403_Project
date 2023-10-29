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
    public partial class MainSettingsPage : Form
    {
        public MainSettingsPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void btnControls_Click(object sender, EventArgs e)
        {
            ControlsPage controlsPage = new ControlsPage();
            controlsPage.Show();
            this.Hide();
        }

        private bool isVolumeMuted = false;

        private void ToggleVolume()
        {
            var controller = new CoreAudioController();
            var defaultPlaybackDevice = controller.DefaultPlaybackDevice;


            if (isVolumeMuted)
            {
                defaultPlaybackDevice.Mute(false);
            }
            else
            {
                defaultPlaybackDevice.Mute(true);
            }
            isVolumeMuted = !isVolumeMuted;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            ToggleVolume();
        }
    }
}
