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
            Button homeButton = new Button();
            homeButton.Location = new Point(16 * width / 18, height / 12);
            homeButton.Size = new Size(70, 50);
            homeButton.BackgroundImage = Properties.Resources.Home_button;
            homeButton.BackgroundImageLayout = ImageLayout.Stretch; // This will stretch the image without maintaining the aspect ratio
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.Parent = this;

            // Adding a click event handler for the home button
            homeButton.Click += homeButton_Click;

            //Heading Label for FAQ's
            Label headingLabel = new Label();
            headingLabel.Text = "Frequently Asked Questions";
            headingLabel.Font = new Font("Century Gothic", 32, FontStyle.Bold);
            headingLabel.BackColor = Color.Transparent;
            headingLabel.Location = new Point(Width / 3, height / 10);
            headingLabel.AutoSize = true;
            //(this.ClientSize.Width - headingLabel.Width)

            // Adding the buttons to the form's Controls collection
            this.Controls.Add(homeButton);
            this.Controls.Add(backButton);
            this.Controls.Add(headingLabel);

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
            "Can I customize my exploration experience?",
            "How many levels are there in the game?",
            };

            for (int i = 0; i < buttonTexts.Length; i++)
            {
                CreateButton(buttonTexts[i], Width / 3, (3 + i) * Height / 7);
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
        /*private void DisplayTextBox(string textToShow)
        {
            // Create and configure a TextBox dynamically
            TextBox dynamicTextBox = new TextBox();
            dynamicTextBox.Multiline = true;
            dynamicTextBox.ScrollBars = ScrollBars.Vertical;
            dynamicTextBox.Text = textToShow;
            dynamicTextBox.Font = new Font("Arial", 12);
            dynamicTextBox.Size = new Size(300, 150);
            dynamicTextBox.Location = new Point((this.ClientSize.Width - dynamicTextBox.Width) / 2, 4 * Height / 10);

            // Add the TextBox to the form
            this.Controls.Add(dynamicTextBox);

            // Attach an event handler for TextBox to handle its disposal
            dynamicTextBox.TextChanged += (s, e) => DynamicTextBox_TextChanged(dynamicTextBox);
        }

        private void DynamicTextBox_TextChanged(TextBox textBox)
        {
            // Remove the TextBox when its text is changed
            textBox.Dispose();
        }*/

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
            //DisplayTextBox(clickedButton.Text);
        }
    }
}
