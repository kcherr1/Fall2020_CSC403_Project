using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
                    this.CurrentStoryText.Enqueue(line.Trim());
                }
            }
        }

        public string GetNextLine()
        {
            if (Empty())
            {
                Application.Exit();
            }
            return this.CurrentStoryText.Dequeue();
        }

        public bool Empty()
        {
            return this.CurrentStoryText.Count == 0;
        }
    }
}
