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
        private FrmCredits credit;

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

        private void Credits_Click(object sender, EventArgs e)
        {
            credit = new FrmCredits();
            this.Hide();
            credit.Show();
        }

        private void FrmVictory_MouseHover(object sender, EventArgs e)
        {
            playAgain_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.playAgain_hover;
        }

        private void credit_btn_MouseHover(object sender, EventArgs e)
        {
            credit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.credit_hover;
        }

        private void exit_btn_MouseHover(object sender, EventArgs e)
        {
            exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_hover;
        }

        private void playAgain_btn_MouseLeave(object sender, EventArgs e)
        {
            playAgain_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.playAgain;
        }

        private void credit_btn_MouseLeave(object sender, EventArgs e)
        {
            credit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.credit_btn;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Exit_btn;
        }
    }
}
