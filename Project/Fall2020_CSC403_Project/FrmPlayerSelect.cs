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
    public partial class FrmPlayerSelect : Form
    {
        public FrmPlayerSelect()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.setup();
        }

        private void setup()
        {
            this.BackColor = Color.DimGray;

            // Create Picture Boxes for each player type
            PictureBox TankPic = new PictureBox();
            PictureBox RoguePic = new PictureBox();
            PictureBox SwordsmanPic= new PictureBox();
        }
    }
}
