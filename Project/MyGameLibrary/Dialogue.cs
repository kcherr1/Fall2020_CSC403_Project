using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Dialogue
    {
        private string[] lines;
        private int[] letterSpeeds;
        private int lineNumber = 0;
        public bool happened = false; 
        public Enemy enemy;
        // DialogueBox nextDialogueBox = null;
        public Dialogue(string[] lines, int[] letterSpeeds, Enemy enemy)
        {
            this.lines = lines;
            this.letterSpeeds = letterSpeeds;
            this.enemy = enemy;
        }

        public bool IsLastLine()
        {
            if (lines.Length == lineNumber)
            {
                lineNumber = 0;
                return true;
            }
            return false;
        }

        public String GetNextLine () {
            String lineToReturn = lines[lineNumber];
            lineNumber++;
            return lineToReturn;
        }

        public int GetLineSpeed () { 
            return letterSpeeds[lineNumber - 1];
        }
        
    }
}
