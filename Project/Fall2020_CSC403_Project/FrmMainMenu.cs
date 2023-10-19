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

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmLevel frmLevel = new FrmLevel();
            frmLevel.Show();

            //this.Close();
        }

        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
        }
    }
}
