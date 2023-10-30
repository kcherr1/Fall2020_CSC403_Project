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

            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            // Create Picture Boxes for each player type
            PictureBox TankPic = new PictureBox();
            PictureBox RoguePic = new PictureBox();
            PictureBox SwordsmanPic= new PictureBox();

            TankPic.Parent = this;
            RoguePic.Parent = this;
            SwordsmanPic.Parent = this;

            TankPic.Image = Properties.Resources.tank;
            RoguePic.Image = Properties.Resources.rogue;
            SwordsmanPic.Image = Properties.Resources.swordsman;

            TankPic.Size = new Size((5 * width / 12) - (width / 6), (2*height)/3);
            RoguePic.Size = new Size((5*width / 12) - (width / 6), (2 * height) / 3);
            SwordsmanPic.Size = new Size((5*width / 12) - (width / 6), (2 * height) / 3);

            TankPic.SizeMode = PictureBoxSizeMode.StretchImage;
            RoguePic.SizeMode = PictureBoxSizeMode.StretchImage;
            SwordsmanPic.SizeMode = PictureBoxSizeMode.StretchImage;

            TankPic.Location = new Point(0+width/12, 0+height/12);
            RoguePic.Location = new Point(0 + width / 12+TankPic.Width + width/16, 0 + height / 12);
            SwordsmanPic.Location = new Point(0 + width / 12+(2* TankPic.Width) + width/8, 0 + height / 12);

            TankPic.BackColor = Color.Transparent;
            RoguePic.BackColor = Color.Transparent;
            SwordsmanPic.BackColor = Color.Transparent;
        }
    }
}
