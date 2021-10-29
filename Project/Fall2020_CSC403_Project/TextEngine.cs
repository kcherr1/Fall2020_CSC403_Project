using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary.Story;

namespace Fall2020_CSC403_Project
{
    public partial class TextEngine : Form
    {
        private Story story { get; set; }
        private double ForegroundImage_Xscale{get;set; }
        private double ForegroundImage_Yscale { get; set; }
        public TextEngine()
        {
            this.story = new Story("\\Fall2021_CSC403_Project\\Project\\Fall2020_CSC403_Project\\data\\", "Story.txt");
            string line = story.GetNextLine();
            InitializeComponent();
            ForegroundImage_Xscale = (double)ForegroundImage.Location.X / Width;
            Console.WriteLine(ForegroundImage.Location);
            ForegroundImage_Yscale = (double)ForegroundImage.Location.Y / Height;
            this.ForegroundImage.BackColor = Color.Transparent;
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

        private void TextEngine_KeyPress(object sender, KeyPressEventArgs e)
        {
            string line = story.GetNextLine();
            this.ChangeText(line);
        }

        private void ForegroundImage_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Console.WriteLine("foregroundimage resize event");
            double ratio = this.ForegroundImage.Size.Width / (this.ForegroundImage.Size.Height * 1.0);
            ForegroundImage.Size = new Size((int)(ClientRectangle.Height * ratio), (int)ClientRectangle.Height);
            Console.WriteLine(ForegroundImage.Location);
            ForegroundImage.Location = new Point((int)ForegroundImage_Xscale*Width, (int)ForegroundImage_Yscale*Height);
        }
    }
}
