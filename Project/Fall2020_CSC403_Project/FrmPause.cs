using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fall2020_CSC403_Project
{
    // Windows Forms class that will act as the pause window for the game
    public partial class FrmPause : Form
    {
        public static FrmPause instance = null;

        private FrmPause()
        {
            InitializeComponent();
        }

        public static FrmPause GetInstance()
        {
            if (instance == null)
                instance = new FrmPause();

            return instance;
        }

        // Click EventHandler that is triggered when the Resume Button is clicked
        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Click EventHandler that is triggered when the Start Over Button is clicked
        private void startOverButton_Click(object sender, EventArgs e)
        {
            // Restart the application 
            Application.Restart();

            // Ensures a clean exit (i.e., exit is not caused by an error)
            Environment.Exit(0);
        }

        // Click EventHandler that is triggered when the Quit Button is clicked
        private void quitButton_Click(object sender, EventArgs e)
        {
            // Exit the application 
            Application.Exit();
        }
    }
}
