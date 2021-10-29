using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyGameLibrary.Story;

namespace Fall2020_CSC403_Project
{
    public partial class TextEngine : Form
    {
        private Story story { get; set; }
        //current options queue
        public TextEngine()
        {
            this.story = new Story("\\Fall2021_CSC403_Project\\Project\\Fall2020_CSC403_Project\\data\\", "Story.txt");
            string line = story.GetNextLine();
            InitializeComponent();
            this.ChangeText(line);
        }

        public void NewBackground(Image newBackground)
        {
            BackgroundImage = newBackground;
        }

        public void NewForeground(Image newImage)
        {
            ForegroundImage.Image = newImage;
        }

        public void ChangeText(string newText)
        {
            Textbox.Text = newText;
        }

        public void TextboxVisible(bool hide)
        {
            Textbox.Visible = hide;
        }

        private void TextEngine_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.DisplayOptions(new List<Option>());
            //if current options is not null, down and up should iterate through options queue
            //if focused changed in options property, change associated label color to slightly darker
            string line = story.GetNextLine();
            this.ChangeText(line);
        }
    }
}
