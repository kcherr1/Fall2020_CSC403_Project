using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
    public class DialogueBox : Character {
        public DialogueBox(Vector2 initPos, Collider collider) : base(initPos, null) {
            //string[] lines = new string[] { "Line 1", "Line 2" };
            //double[] letterSpeeds = new double[] { 0.1, 0.1 };
            //int line = 0;
            //bool dialogueOn = false;
            string text = "default line";
            double letterSpeed = 0.1;
            DialogueBox nextDialogueBox = null;
        }

        public void ShowBox() {

        }

        public void RemoveBox() {

        }

        public void TypeText() {

        }

        public void NextBox() {

        }
    }
}
