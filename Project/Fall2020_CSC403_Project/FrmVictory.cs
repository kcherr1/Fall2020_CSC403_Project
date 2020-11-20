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
    public partial class FrmVictory : Form
    {
        public static FrmVictory instance = null;
        public FrmLevel game;
        private FrmVictory()
        {
            InitializeComponent();
        }

        public static FrmVictory GetInstance(FrmLevel gameLevel)
        {
            if (instance == null)
            {
                instance = new FrmVictory();
            }
            instance.game = gameLevel;
            instance.Show();
            return instance;
        }

        private void endGameClick(object sender, EventArgs e)
        {
            instance.game.Close();
        }
    }
}
