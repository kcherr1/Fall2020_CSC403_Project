using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();
            setTitleFont();
            setTitleLocation();
        }

        //leave empty, needed to render label
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void setTitleFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("./Fonts/pixelated.ttf");
            label1.Font = new Font(pfc.Families[0], 48, FontStyle.Regular);
        }

        private void setTitleLocation()
        {
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, (this.ClientSize.Height - label1.Height) / 4);
        }

    }
}
