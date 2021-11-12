using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
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
    public partial class FrmGameOver : ChildForm
    {
        private FrmMainMenu frmMainMenu;
        public FrmGameOver()
        {
            InitializeComponent();
        }

        private void buttonQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReturnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu = (FrmMainMenu)CreateChild(new FrmMainMenu());
            frmMainMenu.MdiParent = this.MdiParent;
            frmMainMenu.RequestShow();
            Close();
        }
    }
}
