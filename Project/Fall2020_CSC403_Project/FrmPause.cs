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

namespace Fall2020_CSC403_Project
{
    public partial class FrmPause : Form
    {
        private FrmLevel theMusic = FrmLevel.GetInstance(0);
        private FrmHelp helpScreen = null;

        public FrmPause()
        {
            InitializeComponent();
        }

        private void FrmPause_Load(object sender, EventArgs e)
        {
            FrmLevel.pausedTime = true;
            theMusic.StopMusic();

        }
        private void Resume_Click(object sender, EventArgs e)
        {
            // when the window is closed the time resumes
            this.Close();
            FrmLevel.pausedTime = false;
            theMusic.StartMusic();
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            FrmLevel.instance.Close();
            FrmLevel.instance = null;
            menu.Show();
            this.Close();
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            helpScreen = new FrmHelp();
            helpScreen.Show();
        }
    }
}
