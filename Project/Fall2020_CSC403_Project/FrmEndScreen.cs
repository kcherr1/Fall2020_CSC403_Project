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
    public partial class FrmEndScreen : Form
    {

        public static FrmEndScreen instance = null;
        public FrmEndScreen()
        {
            InitializeComponent();
        }

        //EXIT GAME
        private void btnLeaveGame_Click(object sender, EventArgs e)
        {
            instance = null;
            Application.Exit();
        }

        //TO ADD LATER RETURN TO MENU BUTTON
    }
}
