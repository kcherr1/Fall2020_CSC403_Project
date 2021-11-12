using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
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
    
    public partial class FrmMainMenu : ChildForm
    {
        private int difficultyVar;
        private FrmLevel frmLevel;

        public FrmMainMenu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(FrmMainMenu_Load);

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            difficultyVar = Game.difficulty;
            if (difficultyVar == 0)
            {
                pictureBoxDifficulties.Image = Properties.Resources.creamy;
            }
            else if (difficultyVar == 1)
            {
                pictureBoxDifficulties.Image = Properties.Resources.crunchy;
            }
            else if (difficultyVar == 2)
            {
                pictureBoxDifficulties.Image = Properties.Resources.nutty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChangeDifficulty_Click(object sender, EventArgs e)
        {
            if(difficultyVar == 0)
            {
                difficultyVar = 1;
                pictureBoxDifficulties.Image = Properties.Resources.crunchy;
            }
            else if(difficultyVar == 1)
            {
                difficultyVar = 2;
                pictureBoxDifficulties.Image = Properties.Resources.nutty;
            }
            else if(difficultyVar == 2)
            {
                difficultyVar = 0;
                pictureBoxDifficulties.Image = Properties.Resources.creamy;
            }
            Game.difficulty = difficultyVar;
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            //FrmGame f = (FrmGame)this.Parent;
            //f.level = (FrmLevel)CreateChild(new FrmLevel());
            //f.level.RequestShow();
            //Close();
            FrmLevel.lose = false;
            frmLevel = (FrmLevel)CreateChild(new FrmLevel());
            frmLevel.MdiParent = this.MdiParent;
            frmLevel.RequestShow();
            Close();
        }
    }
}
