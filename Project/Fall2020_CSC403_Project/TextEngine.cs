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
    public partial class TextEngine : Form
    {
        public TextEngine()
        {
            InitializeComponent();
            this.ForegroundImage.BackColor = Color.Transparent;
        }

        public void NewBackground(Image newBackground)
        {
            this.BackgroundImage = newBackground;
        }

        public void NewForeground(PictureBox newImage)
        {
            ForegroundImage = newImage;
        }

        public void ChangeText(string newText)
        {
            this.Textbox.Text = newText;
        }

        public void TextboxVisible(bool hide)
        {
            this.Textbox.Visible = hide;
        }

        private void Textbox_Click(object sender, EventArgs e)
        {

        }
    }
}
