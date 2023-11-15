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
    public partial class FrmWinScreen : Form
    {

        public static FrmEndScreen instance = null;

        public bool restart;
        public FrmWinScreen()
        {
            InitializeComponent();
        }

        //EXIT GAME
        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            instance = null;
            restart = false;
            Close();
        }

        //TO ADD LATER RETURN TO MENU BUTTON
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            instance = null;
            restart = true;
            Close();
        }
    }
}