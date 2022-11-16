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
    public partial class FrmCredits : Form
    {
        private StartMenu start;

        public FrmCredits()
        {
            InitializeComponent();
        }

        private void FrmCredits_Load(object sender, EventArgs e)
        {}

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Back_hover;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
          pictureBox6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Back_btn;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            start = new StartMenu();
            start.Show();
        }
    }
}
