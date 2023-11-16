using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmFAQ : Form
    {
        private Form previousForm;
        public FrmFAQ(Form previous)
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            InitializeButtons();
            this.setup();
            previousForm = previous;
        }
        private void setup()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            //Adding back button here
            Button backButton = new Button();
            backButton.Location = new Point(width / 18, height / 12);
            backButton.Size = new Size(70, 50);
            backButton.BackgroundImage = Properties.Resources.Back_button;
            backButton.BackgroundImageLayout = ImageLayout.Stretch; // This will stretch the image without maintaining the aspect ratio
            backButton.BackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.Parent = this;

            // Adding a click event handler for the back button
            backButton.Click += backButton_Click;

            // Adding the home button here
/*            Button homeButton = new Button();
            homeButton.Location = new Point(16 * width / 18, height / 12);
            homeButton.Size = new Size(70, 50);
            homeButton.BackgroundImage = Properties.Resources.Home_button;
            homeButton.BackgroundImageLayout = ImageLayout.Stretch; // This will stretch the image without maintaining the aspect ratio
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.Parent = this;*/

            // Adding a click event handler for the home button
            //homeButton.Click += homeButton_Click;

            //Heading Label for FAQ's
            Label headingLabel = new Label();
            headingLabel.Text = "Frequently Asked Questions";
            headingLabel.Font = new Font("Century Gothic", 32, FontStyle.Bold);
            headingLabel.BackColor = Color.Transparent;
            headingLabel.Location = new Point(Width / 3, height / 10);
            headingLabel.AutoSize = true;
            //(this.ClientSize.Width - headingLabel.Width)

            //Label for Answer1
            Label answer1Label = new Label();
            answer1Label.Text = "Playable characters are Tank, Rouge, and Swordsmen";
            answer1Label.Font = new Font("Arial", 12, FontStyle.Regular);
            answer1Label.BackColor = Color.Transparent;
            answer1Label.Location = new Point(250, 232);
            answer1Label.AutoSize = true;

            //Label for Answer2
            Label answer2Label = new Label();
            answer2Label.Text = "Yes, you can interact and play with NPC's";
            answer2Label.Font = new Font("Arial", 12, FontStyle.Regular);
            answer2Label.BackColor = Color.Transparent;
            answer2Label.Location = new Point(250, 295); // You may adjust the location as needed
            answer2Label.AutoSize = true;

            // Label for Answer3
            Label answer3Label = new Label();
            answer3Label.Text = "You are in for a fantastic ride. Explore and find the surprises yourself.";
            answer3Label.Font = new Font("Arial", 12, FontStyle.Regular);
            answer3Label.BackColor = Color.Transparent;
            answer3Label.Location = new Point(250, 360); // Adjust the location as needed
            answer3Label.AutoSize = true;

            // Label for Answer4
            Label answer4Label = new Label();
            answer4Label.Text = "Currently, there are 10 levels for you to explore in the game.";
            answer4Label.Font = new Font("Arial", 12, FontStyle.Regular);
            answer4Label.BackColor = Color.Transparent;
            answer4Label.Location = new Point(250, 425); // Adjust the location as needed
            answer4Label.AutoSize = true;

            // Label for Answer5
            Label answer5Label = new Label();
            answer5Label.Text = "Yes. You can move between different levels and interact with enemies and NPCs as you like.";
            answer5Label.Font = new Font("Arial", 12, FontStyle.Regular);
            answer5Label.BackColor = Color.Transparent;
            answer5Label.Location = new Point(250, 490); // Adjust the location as needed
            answer5Label.AutoSize = true;



            // Adding the buttons and labels to the form's Controls collection
            //this.Controls.Add(homeButton);
            this.Controls.Add(backButton);
            this.Controls.Add(headingLabel);
            this.Controls.Add(answer1Label);
            this.Controls.Add(answer2Label);
            this.Controls.Add(answer3Label);    
            this.Controls.Add(answer4Label);
            this.Controls.Add(answer5Label);

            /*Adding buttons for the questions
            Button question1 = new Button();
            question1.Location = new Point((this.ClientSize.Width - headingLabel.Width) / 2, 2 * height / 10);
            question1.AutoSize = true;
            question1.BackColor = Color.Transparent;
            question1.FlatStyle = FlatStyle.Flat;
            question1.FlatAppearance.BorderSize = 0;
            question1.Parent = this;
            question1.Text = "What are the characters that I can choose?";
            question1.Font = new Font("Arial", 13,FontStyle.Bold);

            question1.Click += question1_Click;*/
        }
        private void InitializeButtons()
        {

            // Create multiple buttons with associated text
            string[] buttonTexts = {
            "What are the characters that I can choose?",
            "Can I interact with the NPC's?",
            "Are there any hidden secrets in the game?",
            "How many levels are there in the game?",
            "Can I customize my exploration experience?",
            };

            for (int i = 0; i < buttonTexts.Length; i++)
            {
                CreateButton(buttonTexts[i], Width / 3, (3 + i) * Height / 5);
            }
        }
        //Setting up the apperance for buttons
        private void CreateButton(string buttonText, int locationX, int locationY)
        {
            Button dynamicButton = new Button();
            dynamicButton.Location = new Point(locationX, locationY);
            dynamicButton.AutoSize = true;
            dynamicButton.BackColor = Color.Transparent;
            dynamicButton.FlatStyle = FlatStyle.Flat;
            dynamicButton.FlatAppearance.BorderSize = 0;
            dynamicButton.Parent = this;
            dynamicButton.Text = buttonText;
            dynamicButton.Font = new Font("Arial", 13, FontStyle.Regular);

            dynamicButton.Click += QuestionButton_Click;

            this.Controls.Add(dynamicButton);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();

        }
        private void QuestionButton_Click(object sender, EventArgs e)
        { 
            Button clickedButton = (Button)sender;
        }
    }
}
