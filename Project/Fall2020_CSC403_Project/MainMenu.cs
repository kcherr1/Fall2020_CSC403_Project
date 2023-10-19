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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Method to start the game 
        /// </summary>
        private void startButtonClick(object sender, EventArgs e)
        {   
            // Create FrmLevel and show it
            FrmLevel frm = new FrmLevel();
            frm.Show();
            // Whenever FrmLevel is closed, execute onFormClosed method
            frm.FormClosed += frm.onFormClosed;
            Hide();

        }

        /// <summary>
        /// Method to handle closing game from main menu
        /// </summary>
        private void quitButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
