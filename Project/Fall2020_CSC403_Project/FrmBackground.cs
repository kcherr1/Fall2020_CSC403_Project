using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fall2020_CSC403_Project
{
    public partial class FrmBackground : Form
    {
        public static FrmBackground instance = null;

        private FrmMainMenu mainMenu;
        public FrmBackground()
        {
            InitializeComponent();
            startGame();
        }

        public void startGame()
        {
            mainMenu = new FrmMainMenu();
            mainMenu.Show();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            mainMenu.Closed += (s, args) => {
                int formCount = Application.OpenForms.OfType<Form>().Count();
                if (formCount == 1)
                {
                    Application.Exit();
                }
                Debug.WriteLine(formCount);
            };
        }
    }
}
