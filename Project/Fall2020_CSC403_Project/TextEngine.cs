using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MyGameLibrary.Story;

namespace Fall2020_CSC403_Project
{
    public partial class TextEngine : Form
    {
        private Story Story { get; set; }
        private Stack<Option> Options = new Stack<Option>();
        private Stack<Option> TempOptions = new Stack<Option>();          
        private double ForegroundImage_Xscale { get; set; }
        private double ForegroundImage_Yscale { get; set; }
        private int originalHeight { get; set; }
        public TextEngine()
        {
            this.Story = new Story("\\data\\story\\", "Story.txt");
            string line = Story.GetNextLine();
            InitializeComponent();

            ForegroundImage_Xscale = (double)ForegroundImage.Location.X / Width;
            ForegroundImage_Yscale = (double)ForegroundImage.Location.Y / Height;
            originalHeight = Height;
            this.ForegroundImage.BackColor = Color.Transparent;

            this.ChangeText(line);
        }

        public void NewBackground(Image newBackground)
        {
            NormalPanel.BackgroundImage = newBackground;
        }

        public void NewForeground(Image newImage)
        {
            ForegroundImage.BackgroundImage = newImage;
        }

        public void ChangeText(string newText)
        {
            Textbox.Text = newText;
        }

        public void TextboxVisible(bool hide)
        {
            Textbox.Visible = hide;
        }

        private void TextEngine_KeyPress(object sender, KeyEventArgs e)
        {
            if (this.Options.Count != 0)
            {                
                if(e.KeyCode == Keys.Down && Options.Count > 1)
                {
                    Options.Peek().OptionFocused = false; //Top option unfocused
                    TempOptions.Push(Options.Pop()); //Put it in the temp stack
                    Options.Peek().OptionFocused = true; //New top option focused
                }
                if(e.KeyCode == Keys.Up && TempOptions.Count > 0)
                {
                    Options.Peek().OptionFocused = false; //Top option unfocused
                    Options.Push(TempOptions.Pop()); //Put it in the temp stack
                    Options.Peek().OptionFocused = true; //New top option focused
                }
                if(e.KeyCode == Keys.Enter)
                {
                    //DO MARKUP OF OPTION
                    List<Option> options = new List<Option>();
                    Option focusedOption = new Option("uh oh", "#CT ERROR, OPTION NOT FOUND");
                    foreach(Option option in TempOptions)
                    {                       
                        if (option.OptionFocused)
                        {
                            focusedOption = option;
                        }
                        options.Add(option);
                    }
                    foreach(Option option in Options)
                    {
                        if (option.OptionFocused)
                        {
                            focusedOption = option;
                        }
                        options.Add(option);
                    }
                    TempOptions.Clear();
                    Options.Clear();
                    this.RemoveOptions(options);
                    Story.CurrentStoryText.AddFirst(focusedOption.OptionBackendMarkup);
                    HandleMarkup(Story.GetNextLine());
                }
            }
            else 
            {
                HandleMarkup(Story.GetNextLine());                
            }            
        }

        private void HandleMarkup(string line)
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            switch (Story.Current_Action)
            {
                case Markup.ChangeText:
                    //line is plain text (ex: #CT Hello)
                    this.ChangeText(line);
                    break;
                case Markup.ChangeBackgroundImage:
                    //line is: image_location image_name text (ex: #CB \\data\\background\\ hannah_store.jpg We've changed the background)
                    List<string> backgroundInfo = line.Split(' ').ToList();
                    Image backgroundImage = Image.FromFile(_filePath + backgroundInfo[0] + backgroundInfo[1]);
                    this.NewBackground(backgroundImage);
                    backgroundInfo.RemoveAt(0);
                    backgroundInfo.RemoveAt(0);
                    string newLineBG = string.Join(" ", backgroundInfo);
                    this.ChangeText(newLineBG);
                    break;
                case Markup.ChangeForegroundImage:
                    //line is: image_location image_name text (ex: #CF \\data\\foreground\\ player.png We've changed the foreground)
                    List<string> foregroundInfo = line.Split(' ').ToList();
                    Image foregroundImage = Image.FromFile(_filePath + foregroundInfo[0] + foregroundInfo[1]);
                    this.NewForeground(foregroundImage);
                    foregroundInfo.RemoveAt(0);
                    foregroundInfo.RemoveAt(0);
                    string newLineFG = string.Join(" ", foregroundInfo);
                    this.ChangeText(newLineFG);
                    break;
                case Markup.Options:
                    //line is: Option 1, #A ID] Option 2, #A ID] Exit, #CT] text
                    // (ex: #O Option 1,#CT Oh, you selected that] Option 2,#CT You've selected this] Oh look, it's the options page)
                    //Display options
                    List<string> optionsInfo = line.Split(']').ToList();

                    string newLineOptions = optionsInfo[optionsInfo.Count - 1];
                    optionsInfo.RemoveAt(optionsInfo.Count - 1);

                    List<Option> options = new List<Option>();
                    foreach (string info in optionsInfo)
                    {
                        string newInfo = info.Replace(",#", "-");
                        string[] newOption = newInfo.Split('-');
                        options.Add(new Option(newOption[0], '#'+newOption[1]));
                    }                     
                    this.DisplayOptions(options); //Display options
                    options.Reverse(); //Start at end
                    foreach (Option option in options)
                    {
                        option.OptionFocused = false; //Unfocus all options
                        this.Options.Push(option);
                    }
                    this.Options.Peek().OptionFocused = true; //Focus the top option 
                    this.ChangeText(newLineOptions);
                    break;
                case Markup.ReadInNewStory:
                    // line is: story_location story_name
                    break;
                case Markup.CheckThresholdsForTree:
                    // line is: empty, just check thresholds
                    break;
            }
        }

        private void ResizeHandler(object sender, EventArgs e)
        {
            SuspendLayout();
            double ratio = this.ForegroundImage.Size.Width / (this.ForegroundImage.Size.Height * 1.0);
            ForegroundImage.Size = new Size((int)(ClientRectangle.Height * ratio), (int)ClientRectangle.Height);
            if (ForegroundImage_Xscale != 0 && ForegroundImage_Yscale != 0)
            {
                ForegroundImage.Location = new Point((int)Math.Floor(ForegroundImage_Xscale * Width), (int)Math.Floor(ForegroundImage_Yscale * Height));
            }
            if (originalHeight != 0)
            {
                double scaling = Height / (double)originalHeight;
                Textbox.Height = (int)(scaling * 100);
                Textbox.Font = new Font(Textbox.Font.FontFamily, (int)(scaling * 12));

                foreach(Option option in Options) 
                {
                    option.OptionLabel.Height = (int)scaling * 20;
                    option.OptionLabel.Width = (int)scaling * 150;
                }
            }
            ResumeLayout();
        }
        //protected override void OnResizeBegin(EventArgs e)
        //{
        //    SuspendLayout();
        //    this.TurnOffFormLevelDoubleBuffering();
        //    base.OnResizeBegin(e);
        //}
        //protected override void OnResizeEnd(EventArgs e)
        //{
        //    ResumeLayout();
        //    this.TurnOffFormLevelDoubleBuffering();
        //    base.OnResizeEnd(e);
        //}
        private void TextEngine_Load(object sender, EventArgs e)
        {

        }
    }
}
