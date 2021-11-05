using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyGameLibrary.Story
{
    public class Story
    {
        private string StoryLocation { get; set; }
        private string StoryTitle { get; set; }

        public LinkedList<string> CurrentStoryText = new LinkedList<string>();
        public Markup Current_Action { get; set; }
        public Story(string storyLocation, string storyTitle)
        {
            this.StoryLocation = storyLocation;
            this.ChangeStory(storyTitle);
        }

        public void ChangeStory(string newStoryTitle, string newStoryLocation = "")
        {
            if(!string.IsNullOrEmpty(newStoryLocation.Trim()))
            {
                this.StoryLocation = newStoryLocation;
            }
            this.StoryTitle = newStoryTitle;
            this.ReadInStory();
        }

        private void ReadInStory()
        {
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            _filePath = Directory.GetParent(Directory.GetParent(_filePath).FullName).FullName;
            _filePath += StoryLocation+StoryTitle;
            string[] lines = File.ReadAllLines(_filePath);
            foreach (string line in lines)
            {
                if(!string.IsNullOrEmpty(line.Trim()))
                {
                    this.CurrentStoryText.AddLast(line.Trim());
                }
            }
        }

        private void ParseLine()
        {
            //Get currently read in line
            string line = this.CurrentStoryText.First();
            //Split it by spaces
            List<string> splitLine = line.Split(' ').ToList();
            Markup markup = Markup.ChangeText;
            //Check first chunk for what will be happening, set that to the current action
            //Swtich case will not work in this scenario due to how strings need .equals and the current version of c# won't allow ==
            if (string.Equals(splitLine[0], "#CT"))
            {
                markup = Markup.ChangeText;
            }
            else if (string.Equals(splitLine[0], "#CB"))
            {
                markup = Markup.ChangeBackgroundImage;
            }
            else if (string.Equals(splitLine[0], "#CF"))
            {
                markup = Markup.ChangeForegroundImage;
            }
            else if (string.Equals(splitLine[0], "#O"))
            {
                markup = Markup.Options;
            }
            else if (string.Equals(splitLine[0], "#NS"))
            {
                markup = Markup.ReadInNewStory;
            }
            else if (string.Equals(splitLine[0], "#T"))
            {
                markup = Markup.CheckThresholdsForTree;
            }
            else if (string.Equals(splitLine[0], "#A"))
            {
                markup = Markup.AddItemToInventory;
            }
            else if (string.Equals(splitLine[0], "#G"))
            {
                markup = Markup.GiveItem;
            }
            else if (string.Equals(splitLine[0], "#VI"))
            {
                markup = Markup.ViewInventory;
            }
            else if (string.Equals(splitLine[0], "#HF"))
            {
                markup = Markup.HideForeground;
            }
            else if (string.Equals(splitLine[0], "#SF"))
            {
                markup = Markup.ShowForeground;
            }
            else if (string.Equals(splitLine[0], "#HT"))
            {
                markup = Markup.HideTextBox;
            }
            else if (string.Equals(splitLine[0], "#ST"))
            {
                markup = Markup.ShowTextbox;
            }
            else if (string.Equals(splitLine[0], "#E"))
            {
                markup = Markup.ExitOptions;
            }
            else if (string.Equals(splitLine[0], "#S1"))
            {
                markup = Markup.HannahShopOptions;
            }
            else if (string.Equals(splitLine[0], "#S2"))
            {
                markup = Markup.HayleyShopOptions;
            }
            //Set the current action to the markup enum
            this.Current_Action = markup;
            //Remove the tagging chunk
            splitLine.RemoveAt(0);
            //Fix the line to a single line as it previously was.
            line = string.Join(" ", splitLine);
            //Replace line without the tag
            this.CurrentStoryText.RemoveFirst();
            this.CurrentStoryText.AddFirst(line);
        }

        public string GetNextLine()
        {
            //This is a problem for later
            if (Empty())
            {
                Application.Exit();
            }  
            this.ParseLine();
            string line = this.CurrentStoryText.First();
            this.CurrentStoryText.RemoveFirst();
            return line;
        }

        public bool Empty()
        {
            return this.CurrentStoryText.Count == 0;
        }
    }
}
