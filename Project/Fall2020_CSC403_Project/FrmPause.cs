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


        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
