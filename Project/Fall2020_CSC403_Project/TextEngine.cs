using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyGameLibrary.Story;

namespace Fall2020_CSC403_Project
{
    public partial class TextEngine : Form
    {
        private Story Story { get; set; }
        private Stack<Option> Options = new Stack<Option>();
        private Stack<Option> TempOptions = new Stack<Option>();
        public TextEngine()
        {
            this.Story = new Story("\\Fall2021_CSC403_Project\\Project\\Fall2020_CSC403_Project\\data\\", "Story.txt");
            string line = Story.GetNextLine();
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
                    foreach(Option _ in TempOptions)
                    {                        
                        options.Add(TempOptions.Pop());
                    }
                    foreach(Option _ in Options)
                    {
                        options.Add(Options.Pop());
                    }
                    this.RemoveOptions(options);
                }
            }
            else 
            {
                string line = Story.GetNextLine();
                //TODO: Needs further implementation for markup and particular "type" of markup to check with for cleaner checking
                //This is a "for now" thing to demonstrate the ability to HAVE options
                if (line.Equals("OPTIONS"))
                {
                    //We skip the "markup" text indicating the option to set line
                    //Theoretically, this will have been parsed by now for our options list
                    line = Story.GetNextLine();
                    //This will need to be handled to take in parsed option markup
                    List<Option> options = new List<Option>() { new Option("Test", "[fgi]"), new Option("This", "yada") };
                    this.DisplayOptions(options); //Display options
                    options.Reverse(); //Start at end
                    foreach (Option option in options)
                    {
                        option.OptionFocused = false; //Unfocus all options
                        this.Options.Push(option);
                    }
                    this.Options.Peek().OptionFocused = true; //Focus the top option 
                }
                this.ChangeText(line);
            }            
        }
    }
}
