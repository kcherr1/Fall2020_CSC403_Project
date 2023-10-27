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
    public partial class FrmMainMenu : Form
    {
        public static FrmMainMenu instance = null;

        private FrmLevel frmLevel;

        public FrmMainMenu()
        {
            InitializeComponent();
            menuTheme.PlayLooping();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuTheme.Stop();

            frmLevel = new FrmLevel();
            frmLevel.Closed += (s, args) => this.Show();
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
