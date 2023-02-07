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
        private StartMenu start;

        public FrmDeath()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tryAgain_btn_Click(object sender, EventArgs e)
        {
            start = new StartMenu();
            this.Hide();
            start.Show();
        }

        private void exit_btn_MouseHover(object sender, EventArgs e)
        {
            exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_hover;
        }

        private void tryAgain_btn_MouseHover(object sender, EventArgs e)
        {
            tryAgain_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.tryAgain_hover;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_btn;
        }

        private void tryAgain_btn_MouseLeave(object sender, EventArgs e)
        {
            tryAgain_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.tryAgain;
        }
    }
}
