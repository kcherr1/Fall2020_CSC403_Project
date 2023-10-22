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
        // DialogueBox nextDialogueBox = null;
        public Dialogue(string[] lines, int[] letterSpeeds) {
            this.lines = lines;
            this.letterSpeeds = letterSpeeds;
            
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
            Console.WriteLine(lineNumber);
            String lineToReturn = lines[lineNumber];
            lineNumber++;
            return lineToReturn;
        }

        public int GetLineSpeed () { 
            return letterSpeeds[lineNumber - 1];
        }
        
    }
}
