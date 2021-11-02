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
            string line = this.CurrentStoryText.First();
            List<string> splitLine = line.Split(' ').ToList();
            Markup markup = Markup.ChangeText;
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
            this.Current_Action = markup;
            splitLine.RemoveAt(0);
            line = string.Join(" ", splitLine);
            this.CurrentStoryText.RemoveFirst();
            this.CurrentStoryText.AddFirst(line);
        }

        public string GetNextLine()
        {
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
