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
        public bool IsTyping = false;

        string defaultText = "default line";

        int[] shownPoint = { 149, 567 };
        int[] hidePoint = { 149, 1000 };

        int[] labelShownPoint = { 165, 583 };
        int[] labelHidePoint = { 165, 1000-567+583 };

        Dialogue currentDialogue;

        public DialogueBox(Vector2 initPos, Collider collider, PictureBox picturebox, Label dialogueLabel) : base(initPos, collider) {
            PictureBox = picturebox;
            DialogueLabel = dialogueLabel;

            HideBox();
            DisableCollider();
        }

        public void ShowBox() {
            TypeText(currentDialogue.GetNextLine());
            PictureBox.Location = new Point(shownPoint[0], shownPoint[1]);
            DialogueLabel.Location = new Point(labelShownPoint[0], labelShownPoint[1]);
            IsShown = true;
            // TypeText(defaultText);
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

        public void SetCurrentDialogue(Dialogue enemyDialogue) {
            this.currentDialogue = enemyDialogue;
        }

        async Task TextDelay(int ms) { 
            await Task.Delay(ms);
        }

        public async void TypeText(String givenLine) {
            String text = "";
            IsTyping = true;
            for (int i = 0; i < givenLine.Length; i++) {
                text = text + givenLine[i];
                DialogueLabel.Text = text;
                /*
                 * PLAY TEXT SOUND
                 */
                await TextDelay(currentDialogue.GetLineSpeed());
            }
            IsTyping = false;
        }

        public bool IsLastLine() {
            return currentDialogue.IsLastLine();
        }

        public void GetNextText() {
            String text = currentDialogue.GetNextLine();
            TypeText(text);
        }

        public Enemy getEnemy()
        {
            return currentDialogue.enemy;
        }
    }
}
