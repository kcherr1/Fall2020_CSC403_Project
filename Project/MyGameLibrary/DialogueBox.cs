using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Fall2020_CSC403_Project.code {
    public class DialogueBox : Character {
        public Image Img { get; set; }
        public PictureBox PictureBox { get; set; }
        public Label DialogueLabel { get; set; }

        public bool IsShown = true;

        int[] shownPoint = { 149, 567 };
        int[] hidePoint = { 149, 1000 };

        int[] labelShownPoint = { 165, 583 };
        int[] labelHidePoint = { 165, 1000-567+583 };

        public DialogueBox(Vector2 initPos, Collider collider, PictureBox picturebox, Label dialogueLabel) : base(initPos, collider) {
            //string[] lines = new string[] { "Line 1", "Line 2" };
            //double[] letterSpeeds = new double[] { 0.1, 0.1 };
            //int line = 0;
            //bool dialogueOn = false;
            PictureBox = picturebox;
            DialogueLabel = dialogueLabel;
            string text = "default line";
            double letterSpeed = 0.1;
            DialogueBox nextDialogueBox = null;
            HideBox();
            DisableCollider();
        }

        public void ShowBox() {
            PictureBox.Location = new Point(shownPoint[0], shownPoint[1]);
            DialogueLabel.Location = new Point(labelShownPoint[0], labelShownPoint[1]);
            IsShown = true;
        }

        public void HideBox() {
            PictureBox.Location = new Point(hidePoint[0], hidePoint[1]);
            DialogueLabel.Location = new Point(labelHidePoint[0], labelHidePoint[1]);
            IsShown = false;
        }

        public void ToggleBox() {
            if (IsShown)
            {
                HideBox();
            }
            else
            {
                ShowBox();
            }
        }

        public void TypeText() {

        }

        public void GetNextText() {

        }
    }
}
