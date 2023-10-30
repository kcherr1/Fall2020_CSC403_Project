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

namespace Fall2020_CSC403_Project
{
    public partial class FrmMainMenu : Form
    {
        public static FrmMainMenu instance = null;

        private FrmLevel frmLevel;
        private FrmWinScreen frmWin;
        private FrmEndScreen frmEnd;

        public FrmMainMenu()
        {
            InitializeComponent();
            menuTheme.PlayLooping();
            this.FormClosed += (s, args) => Application.Exit();
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
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
                    frmWin.FormClosed += (x, t) => this.Show();
                }
                else if (frmLevel.lose == true)
                {
                    frmEnd = new FrmEndScreen();
                    frmEnd.Show();
                    frmEnd.FormClosed += (x, t) => this.Show();
                }
                else
                {
                    this.Show();
                    menuTheme.PlayLooping();
                }
            };
            frmLevel.Show();

            instance = null;
        }

        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
