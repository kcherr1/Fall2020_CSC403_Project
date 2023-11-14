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
    public partial class FrmFAQ : Form
    {
        public FrmFAQ(Form previous)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.setup();
        }
        private void setup()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            //Adding back button and main menu button
            Button backButton = new Button();
            Button homeButton = new Button();

            backButton.Location = new Point(width / 18, height / 12);
            backButton.AutoSize = true;
            //backButton.Image = Properties.Resources.
            homeButton.Location = new Point(16 * width / 18, height / 12);
            homeButton.AutoSize = true;
            
            // Heading Label for FAQ's
            Label headingLabel = new Label();
            headingLabel.Text = "Frequently Asked Questions";
            headingLabel.Font = new Font("Century Gothic", 24, FontStyle.Bold);
            headingLabel.BackColor = Color.Transparent;
            headingLabel.Location = new Point((this.ClientSize.Width - headingLabel.Width) / 2, height / 10);
            headingLabel.AutoSize = true;

            this.Controls.Add(headingLabel);
        }

    }
}
