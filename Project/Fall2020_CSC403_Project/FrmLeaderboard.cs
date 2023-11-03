using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLeaderboard : Form
    {
        public Form PreviousForm;
        public FrmLeaderboard(Form PreviousForm)
        {
            this.WindowState = FormWindowState.Maximized;
            this.PreviousForm = PreviousForm;
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

            // Get leaderboard data from LeaderboardData.json and put the rankings into lists
            string filepath = "../../data/LeaderboardData.json";
            string[] text = File.ReadAllLines(filepath);

            string playerText = text[0];
            string classText = text[1];
            string scoresText = text[2];
            string weaponText = text[3];
            string armorText = text[4];
            string utilityText = text[5];

            List<String> topPlayers = JsonSerializer.Deserialize<List<String>>(playerText);
            List<String> topClasses = JsonSerializer.Deserialize<List<String>>(classText);
            List<int> topScores = JsonSerializer.Deserialize<List<int>>(scoresText);
            List<String> topWeapons = JsonSerializer.Deserialize<List<String>>(weaponText);
            List<String> topArmors = JsonSerializer.Deserialize<List<String>>(armorText);
            List<String> topUtilities = JsonSerializer.Deserialize<List<String>>(utilityText);

            new Label
            {
                Location = new Point(0 + (7 * width / 16), 0),
                Text = String.Format("{0,-8} {1,-10} {2,-10} {3,-6}", "Rank", "Name", "Class", "Score"),
                Parent = BackgroundImg,
                Size = new Size(9 * width / 16, height / 15),
                Font = new Font("NSimSun", height / 25),
                BackColor = Color.FromArgb(64, Color.White),
                ForeColor = Color.Black,
            };

            Label Ranking;
            for (int i = 0; i < topPlayers.Count; i++)
            {
                if (topPlayers[i] != null)
                {
                    Ranking = new Label
                    {
                        Location = new Point(0 + (7 * width / 16), 0 + ((i + 1) * height / 15)),
                        Text = String.Format("{0,-8} {1,-10} {2,-10} {3,-6}", (i + 1), topPlayers[i], topClasses[i], topScores[i]),
                        Parent = BackgroundImg,
                        Size = new Size(9 * width / 16, height / 15),
                        Font = new Font("NSimSun", height / 25),
                        BackColor = Color.FromArgb(64, Color.White),
                        ForeColor = Color.Black,
                    };
                    Ranking.Click += Ranking_Click;
                }
            }


            // Add Buttons For Start, Settings and Exit
            Button ExitButton = new Button();

            ExitButton.Location = new Point(0 + (width / 18), 0 + (7 * height / 9));
            ExitButton.Parent = BackgroundImg;
            ExitButton.Size = new Size(width / 3, height / 10);
            ExitButton.Text = ("Exit");
            ExitButton.Font = new Font("NSimSun", ExitButton.Size.Height / 2);
            ExitButton.Click += ExitButton_Click;


            //// Add Title
            //Label Title = new Label();
            //Title.Text = "Leaderboard";
            //Title.Parent = BackgroundImg;
            //Title.Size = new Size(width, height / 5);
            //Title.Font = new Font("NSimSun", Title.Size.Height / 2);
            //Title.BackColor = Color.Transparent;
            //Title.Location = new Point(0 + (width / 6), 0 + (height / 12));
        }

        private void Ranking_Click(object sender, EventArgs e)
        {
            Label Ranking = (Label)sender;
            string text = Ranking.Text;
            Ranking.BackColor = Color.FromArgb(128, Color.White);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Hide();
        }
    }
}
