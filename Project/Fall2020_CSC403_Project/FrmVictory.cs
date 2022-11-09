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
        private StartMenu start;

        public FrmVictory()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playAgain_btn_Click(object sender, EventArgs e)
        {
            start = new StartMenu();
            this.Hide();
            start.Show();
        }
    }
}
