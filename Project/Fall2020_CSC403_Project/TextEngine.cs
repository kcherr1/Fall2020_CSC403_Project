using System;
using System.Drawing;
using System.Windows.Forms;
using MyGameLibrary.Story;

namespace Fall2020_CSC403_Project
{
    public partial class TextEngine : Form
    {
        private Story story { get; set; }
        public TextEngine()
        {
            this.story = new Story("\\Fall2021_CSC403_Project\\Project\\Fall2020_CSC403_Project\\data\\", "Story.txt");
            string line = story.GetNextLine();
            InitializeComponent();
            this.ChangeText(line);
        }

        //Switch modes
        //https://stackoverflow.com/questions/13584902/change-content-in-a-windows-form?lq=1
        //Panels? Active panel -> options panel

        public void NewBackground(Image newBackground)
        {
            BackgroundImage = newBackground;
        }

        public void NewForeground(PictureBox newImage)
        {
            ForegroundImage = newImage;
        }

        public void ChangeText(string newText)
        {
            Textbox.Text = newText;
        }

        public void TextboxVisible(bool hide)
        {
            Textbox.Visible = hide;
        }

        private void Textbox_Click(object sender, EventArgs e)
        {
            string line = story.GetNextLine();
            this.ChangeText(line);
        }

        private void TextEnginge_KeyPress(object sender, KeyPressEventArgs e)
        {
            string line = story.GetNextLine();
            this.ChangeText(line);
        }
    }
}
