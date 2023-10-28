using Fall2020_CSC403_Project.Properties;
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

    public partial class FrmStart : Form
    {
        private FrmLevel frmLevel;
        private FrmCharacter frmCharacter;
        public Bitmap result { get; set; }

        private SoundPlayer backgroundMusic;
        public FrmStart()
        {
            InitializeComponent();
        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {

            frmLevel = new FrmLevel();
            frmLevel.WindowState = FormWindowState.Maximized;
            frmLevel.Show();
            this.Hide();
        }
        private void lblNewGame_Hover(object sender, EventArgs e)
        {
            this.lblNewGame.ForeColor = Color.White;
        }

        private void lblNewGame_Leave(object sender, EventArgs e)
        {
            this.lblNewGame.ForeColor = Color.Aqua;
        }

        private void lbl_Character_Click(object sender, EventArgs e)
        {
            frmCharacter = new FrmCharacter();
            frmCharacter.StartPosition = FormStartPosition.CenterScreen;
            frmCharacter.Show();
        }

        private void lbl_Character_Hover(object sender, EventArgs e)
        {
            this.lbl_Character.ForeColor = Color.White;
        }

        private void lbl_Character_Leave(object sender, EventArgs e)
        {
            this.lbl_Character.ForeColor = Color.Aqua;
        }

        private void lblExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExitGame_Hover(object sender, EventArgs e)
        {
            this.lblExitGame.ForeColor = Color.White;
        }

        private void lblExitGame_Leave(object sender, EventArgs e)
        {
            this.lblExitGame.ForeColor = Color.Aqua;
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            
            picResult.Visible = false;
            // for maximixe Window
            this.WindowState = FormWindowState.Maximized;
            //For Background Music
            backgroundMusic = new SoundPlayer(Resources.backgroundMusic);
            backgroundMusic.PlayLooping();
            if (result != null)
            {
                picResult.Visible = true;
                picResult.BackgroundImage = result;
            }
        }

        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (backgroundMusic != null)
            {

                backgroundMusic.Stop();
            }
        }
    }
}
