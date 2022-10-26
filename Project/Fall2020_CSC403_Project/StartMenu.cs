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
    public partial class StartMenu : Form
    {
        private FrmLevel frmLevel;

        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void new_game_btn_Click(object sender, System.EventArgs e, StartMenu startMenu)
        {
            frmLevel = new FrmLevel();

            startMenu.Visible = false;

            frmLevel.Show();
        }

        private void new_game_btn_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
