using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class FrmInventory : Form
    {
        public static FrmInventory instance = null;
        public static FrmInventory GetInstance()
        {
            if (instance == null)
            {
                instance = new FrmInventory();
            }
            return instance;
        }

        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    Hide();
                    break;
                case Keys.Escape:
                    Hide();
                    break;
                default:
                    break;
            }
        }
    }
}
