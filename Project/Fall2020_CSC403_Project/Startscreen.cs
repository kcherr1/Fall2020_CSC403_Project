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
    public partial class Startscreen : Form
    {
        FrmLevel ingamescreen = new FrmLevel();
        public Startscreen()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            ingamescreen.Show();
        }

        private void exitGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}
