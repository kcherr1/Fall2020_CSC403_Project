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
        public static int difficultyVar = 0;

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            FrmGame f = (FrmGame)this.Parent;
            f.level = (FrmLevel)CreateChild(new FrmLevel());
            f.level.RequestShow();
            Close();
        }
    }
}
