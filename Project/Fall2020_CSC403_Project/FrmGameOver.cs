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
    public partial class FrmGameOver : Form
    {
        public static FrmGameOver instance = null;
        public FrmLevel game;
        private FrmGameOver()
        {
            InitializeComponent();
        }

        private void FrmGameOver_Click(object sender, EventArgs e)
        {

        }
        public static FrmGameOver GetInstance(FrmLevel gameLevel)
        {
            if (instance == null)
            {
                instance = new FrmGameOver();
            }
            instance.game = gameLevel;
            instance.Show();
            return instance;
        }

        private void loadGame(object sender, EventArgs e)
        {

        }

     

        private void exitButtonClick(object sender, EventArgs e)
        {
            instance.game.Close();
        }
    }
}
