using Fall2020_CSC403_Project.code;
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
    public partial class FrmDeath : Form
    {
        private Player player;
        public FrmDeath()
        {
            InitializeComponent();
            player = Game.player;
        }

        private void Death_Screen_Load(object sender, EventArgs e)
        {
            picPlayer.BackgroundImage = player.imgDed;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Close();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
