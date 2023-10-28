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
    public partial class FrmCharacter : Form
    {

        private SoundPlayer backgroundMusic;
        public FrmCharacter()
        {
            InitializeComponent();
        }

        private void picFlyingTurtle_Click(object sender, EventArgs e)
        {

         Properties.ChosenCharacter.Image = Properties.Resources.flying_turtle;
         var dialogResult =    MessageBox.Show("Flying Turtle has been chosen.","Chosen Chaharacter",MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
                
            }
        }

        private void picTurtle_Click(object sender, EventArgs e)
        {

            Properties.ChosenCharacter.Image = Properties.Resources.turtle;
            var dialogResult = MessageBox.Show("Turtle has been chosen.", "Chosen Chaharacter", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void picTechna_Click(object sender, EventArgs e)
        {
            
            Properties.ChosenCharacter.Image = Properties.Resources.tecna;
            var dialogResult = MessageBox.Show("Tecna has been chosen.", "Chosen Chaharacter", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void picMrPeanut_Click(object sender, EventArgs e)
        {
            
            Properties.ChosenCharacter.Image = Properties.Resources.mr_peanut;
            var dialogResult = MessageBox.Show("Mr Peanut has been chosen.", "Chosen Chaharacter", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void FrmCharacter_Load(object sender, EventArgs e)
        {
            //For Background Music
            backgroundMusic = new SoundPlayer(Resources.backgroundMusic);
            backgroundMusic.PlayLooping();
        }
    }
}
