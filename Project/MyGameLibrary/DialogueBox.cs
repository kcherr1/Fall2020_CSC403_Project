using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;
using System;
using System.Windows;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project.code {
    public class DialogueBox : Character {
        public Image Img { get; set; }
        public PictureBox PictureBox { get; set; }
        public bool IsShown = true;

        public DialogueBox(Vector2 initPos, Collider collider, PictureBox picturebox) : base(initPos, collider) {
            //string[] lines = new string[] { "Line 1", "Line 2" };
            //double[] letterSpeeds = new double[] { 0.1, 0.1 };
            //int line = 0;
            //bool dialogueOn = false;
            PictureBox = picturebox;
            string text = "default line";
            double letterSpeed = 0.1;
            DialogueBox nextDialogueBox = null;
            DisableCollider();
        }

        public void ShowBox() {
            PictureBox.Location = new Point(149, 567);
            IsShown = true;
        }

        public void HideBox() {
            PictureBox.Location = new Point(149, 1000);
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
