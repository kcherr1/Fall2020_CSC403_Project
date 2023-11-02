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
    public partial class FrmLeaderboard : Form
    {
        public Form PreviousForm;

        public int[] TopScores;
        public FrmLeaderboard(Form PreviousForm)
        {
            this.WindowState = FormWindowState.Maximized;
            this.PreviousForm = PreviousForm;
            this.TopScores = new int[10];
            InitializeComponent();
            this.Setup();
        }

        private void Setup()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            // Set up background
            PictureBox BackgroundImg = new PictureBox();
            this.Controls.Add(BackgroundImg);
            BackgroundImg.Image = Properties.Resources.BackgroundForRPG3;
            BackgroundImg.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImg.Size = new Size(width, height);

            // Add Buttons For Start, Settings and Exit
            Button ExitButton = new Button();

            ExitButton.Location = new Point(0 + (width / 18), 0 + (7 * height / 9));
            ExitButton.Parent = BackgroundImg;
            ExitButton.Size = new Size(width / 3, height / 10);
            ExitButton.Text = ("Exit");
            ExitButton.Font = new Font("NSimSun", ExitButton.Size.Height / 2);
            ExitButton.Click += ExitButton_Click;


            // Add Title
            Label Title = new Label();
            Title.Text = "Leaderboard";
            Title.Parent = BackgroundImg;
            Title.Size = new Size(width, height / 5);
            Title.Font = new Font("NSimSun", Title.Size.Height / 2);
            Title.BackColor = Color.Transparent;
            Title.Location = new Point(0 + (width / 6), 0 + (height / 12));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }
    }
}
