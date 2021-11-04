using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MyGameLibrary.Shop;
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
        private double ForegroundImage_AspectRatio { get; set; }
        private int originalHeight { get; set; }
        private int originalWidth { get; set; }
        public TextEngine()
        {
            this.Story = new Story("\\data\\story\\", "Story.txt");
            string line = Story.GetNextLine();
            InitializeComponent();

            ForegroundImage_Xscale = (double)ForegroundImage.Left / Width;
            ForegroundImage_Yscale = (double)ForegroundImage.Top / Height;
            ForegroundImage_AspectRatio = ForegroundImage.Size.Width / (ForegroundImage.Size.Height * 1.0);
            originalHeight = Height;
            originalWidth = Width;
            this.ForegroundImage.BackColor = Color.Transparent;

            this.ChangeText(line);
        }

        public void NewBackground(Image newBackground)
        {
            NormalPanel.BackgroundImage = newBackground;
            OptionsPanel.BackgroundImage = newBackground;
        }

        public void NewForeground(Image newImage)
        {
            ForegroundImage.BackgroundImage = newImage;
        }

        public void ChangeText(string newText)
        {
            Textbox.Text = newText;
        }

        public void ForegroundVisibile(bool hide)
        {
            ForegroundImage.Visible = hide;
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
                    //Potentially a simple check to see if there is a store instance running and if so not remove options on select
                    this.RemoveOptions(options);
                    //Then if there is a store instance running and the markup was #E then remove options and handle next thing
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
                case Markup.HideForeground:
                    // line is: nothing, this is just a signal to hide the foreground
                    this.ForegroundVisibile(false);
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.ShowForeground:
                    // line is: nothing, this is just a signal to show the foreground
                    this.ForegroundVisibile(true);
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.HideTextBox:
                    // line is: nothing, this is just a signal to hide the textbox
                    this.TextboxVisible(false);
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.ShowTextbox:
                    // line is: nothing, this is just a signal to show the textbox
                    this.TextboxVisible(true);
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.Options:
                    //line is: Option 1, #A ID] Option 2, #A ID] Exit, #CT] text
                    // (ex: #O Option 1,#CT Oh, you selected that] Option 2,#CT You've selected this] Oh look, it's the options page)
                    //Note: make sure there is no space between ,#
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
                case Markup.AddItemToInventory:
                    // line is: id           
                    string nameAdd = Enum.GetName(typeof(Items), int.Parse(line));
                    Items identifierAdd = (Items)Enum.Parse(typeof(Items), nameAdd);
                    //For the store I recommend that we have something constant somewhere with the description and prices associated with ID
                    Item itemAdd = new Item(identifierAdd, nameAdd, "Temp description", 5);
                    Inventory.withdrawMoney(itemAdd.ItemPrice);
                    Inventory.addItem(identifierAdd, itemAdd);
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.GiveItem:
                    // line is: id
                    string nameGive = Enum.GetName(typeof(Items), int.Parse(line));
                    Items identifierGive = (Items)Enum.Parse(typeof(Items), nameGive);
                    Inventory.useItem(identifierGive);
                    //TO DO!!!!: 
                    //Change character love score
                    //Make a character enum as well?
                    //LoveUpdate(identifierGive)
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.ReadInNewStory:
                    // line is: story_location story_name
                    string[] newStoryInfo = line.Split(' ');
                    Story.ChangeStory(newStoryInfo[1], newStoryInfo[0]);
                    HandleMarkup(Story.GetNextLine());
                    break;
                case Markup.ViewInventory:
                    // line is: empty, just display inventory
                    //for items in current inventory create options where markup is #CT item_description
                    //to leave inventory handle pressing escape? press escape maybe to view inventory and then escape to exit?
                    break;
                case Markup.CheckThresholdsForTree:
                    // line is: empty, just check thresholds
                    break;
            }
        }

        private void ResizeHandler(object sender, EventArgs e)
        {
            SuspendLayout();
            if (ForegroundImage_AspectRatio != 0)
            {
                ForegroundImage.Size = new Size((int)(ClientRectangle.Size.Height * ForegroundImage_AspectRatio), ClientRectangle.Size.Height);
            }
            if (ForegroundImage_Xscale != 0 && ForegroundImage_Yscale != 0)
            {
                ForegroundImage.Location = new Point((int)(ForegroundImage_Xscale * ClientRectangle.Size.Width), (int)(ForegroundImage_Yscale*Height));
            }
            if (originalHeight != 0)
            {
                double heightScaling = Height / (double)originalHeight;
                double widthScaling = Width / (double)originalWidth;
                Textbox.Height = (int)(heightScaling * 80);
                Textbox.Font = new Font(Textbox.Font.FontFamily, (int)(heightScaling * 12));
                int location_Y = 50;
                foreach(Option option in Options) 
                {
                    option.OptionLabel.Size = new Size((int)(widthScaling * 150), (int)(heightScaling * 30));
                    option.OptionLabel.Font = new Font(option.OptionLabel.Font.FontFamily, (int)(heightScaling * 8));
                    option.OptionLabel.Location = new Point(option.OptionLabel.Location.X, (int)(location_Y*heightScaling));
                    location_Y += 40;
                }
            }
            ResumeLayout();
        }

        private void TextEngine_Load(object sender, EventArgs e)
        {

        }
    }
}
