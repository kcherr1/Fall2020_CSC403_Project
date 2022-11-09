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
    public partial class FrmCharacter : Form
    {
        private FrmLevel frmlvl;

        public FrmCharacter()
        {
            InitializeComponent();
        }

        private void orginial_peanut_Click(object sender, EventArgs e)
        {
            frmlvl = new FrmLevel();
            this.Close();
            frmlvl.Show();
        }
    }
}
