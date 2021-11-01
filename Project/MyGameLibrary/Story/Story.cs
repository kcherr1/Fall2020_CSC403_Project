using System.Collections.Generic;
using System.IO;

namespace MyGameLibrary.Story
{
    public class Story
    {
        private string StoryLocation { get; set; }
        private string StoryTitle { get; set; }

        public Queue<string> CurrentStoryText = new Queue<string>();
        public Story(string storyLocation, string storyTitle)
        {
            this.StoryLocation = storyLocation;
            this.ChangeStory(storyTitle);
        }

        public void ChangeStory(string newStoryTitle)
        {
            this.StoryTitle = newStoryTitle;
            this.ReadInStory();
        }

        private void ReadInStory()
        {
            List<string> lines = new List<string>{ "This is a test.", " ","OPTIONS", "This is an option page", "Let's see if the text changes." };
            foreach (string line in lines)
            {
                if(!string.IsNullOrEmpty(line.Trim()))
                {
                    this.CurrentStoryText.Enqueue(line.Trim());
                }
            }
        }

        public string GetNextLine()
        {
            return this.CurrentStoryText.Dequeue();
        }

        public bool Empty()
        {
            return this.CurrentStoryText.Count == 0;
        }
    }
}
