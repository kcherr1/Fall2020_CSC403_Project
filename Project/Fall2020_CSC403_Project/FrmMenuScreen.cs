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
    public partial class FrmMenuScreen : Form
    {
        public FrmMenuScreen()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form gameWindow = new FrmLevel();
            gameWindow.Show();
        }

        private void LoadHelpMenu(object sender, EventArgs e)
        {
            Form helpWindow = new FrmHelpScreen();
            helpWindow.Show();
        }
    }
}
