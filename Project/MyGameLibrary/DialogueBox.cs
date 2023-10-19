using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
    public class DialogueBox : Character {
        public Image Img { get; set; }
        public PictureBox PictureBox { get; set; }
        public Label DialogueLabel { get; set; }

        public bool IsShown = true;
        string defaultText = "default line";

        int[] shownPoint = { 149, 567 };
        int[] hidePoint = { 149, 1000 };

        int[] labelShownPoint = { 165, 583 };
        int[] labelHidePoint = { 165, 1000-567+583 };

        public DialogueBox(Vector2 initPos, Collider collider, PictureBox picturebox, Label dialogueLabel) : base(initPos, collider) {
            //string[] lines = new string[] { "Line 1", "Line 2" };
            //double[] letterSpeeds = new double[] { 0.1, 0.1 };

            PictureBox = picturebox;
            DialogueLabel = dialogueLabel;
            
            DialogueBox nextDialogueBox = null;
            HideBox();
            DisableCollider();
        }

        public void ShowBox() {
            PictureBox.Location = new Point(shownPoint[0], shownPoint[1]);
            DialogueLabel.Location = new Point(labelShownPoint[0], labelShownPoint[1]);
            IsShown = true;
            TypeText();
        }

        public void HideBox() {
            PictureBox.Location = new Point(hidePoint[0], hidePoint[1]);
            DialogueLabel.Location = new Point(labelHidePoint[0], labelHidePoint[1]);
            DialogueLabel.Text = "";
            IsShown = false;
        }

        public void ToggleBox() {
            if (IsShown) {
                HideBox();
            }
            else {
                ShowBox();
            }
        }

        async Task TextDelay() { 
            await Task.Delay(50);
        }

        public async void TypeText() {

            // Had help from this source for timing purposes
            // https://stackoverflow.com/questions/22158278/wait-some-seconds-without-blocking-ui-execution
            String text = "";
            for (int i = 0; i < defaultText.Length; i++) {
                text = text + defaultText[i];
                DialogueLabel.Text = text;
                await TextDelay();
            }
        }

        public void GetNextText() {

        }
    }
}
