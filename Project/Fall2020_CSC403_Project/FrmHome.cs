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
    public partial class FrmHome : Form
    {
        public static FrmLevel gameplayForm = null;
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        public void playBtn_Click(object sender, EventArgs e)
        {
            gameplayForm = new FrmLevel();
            gameplayForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmHome_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    break;
                case Keys.S:
                    FrmLevel gameplayForm = new FrmLevel();
                    gameplayForm.Show();
                    this.Hide();
                    break;
            }
        }
    }
}
