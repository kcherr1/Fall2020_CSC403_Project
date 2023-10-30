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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.setup();
        }

        private void setup()
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;
            // Set up background
            PictureBox BackgroundImg = new PictureBox();
            this.Controls.Add(BackgroundImg);
            BackgroundImg.Image = Properties.Resources.BackgroundForRPG3;
            BackgroundImg.SizeMode = PictureBoxSizeMode.StretchImage;
            BackgroundImg.Size = new Size(width, height);

            // Add Buttons For Start, Settins and Exit
            Button StartButton = new Button();
            Button SettingsButton = new Button();
            Button ExitButton = new Button();

            StartButton.Location = new Point(0+(width/18), 0+(height / 2));
            SettingsButton.Location = new Point(0+(width/18), 0 + ((5*height)/8));
            ExitButton.Location = new Point(0+(width/18), 0 + (6*height / 8));

            StartButton.Parent = BackgroundImg;
            SettingsButton.Parent = BackgroundImg;
            ExitButton.Parent = BackgroundImg;

            StartButton.Size = new Size(width/3, height/10);
            SettingsButton.Size = new Size(width / 3, height / 10);
            ExitButton.Size = new Size(width / 3, height / 10);

            StartButton.Text = ("Start Game");
            SettingsButton.Text = ("Settings");
            ExitButton.Text = ("Quit Game");

            StartButton.Font = new Font("NSimSun", StartButton.Size.Height/2);
            SettingsButton.Font = new Font("NSimSun", SettingsButton.Size.Height / 2);
            ExitButton.Font = new Font("NSimSun", ExitButton.Size.Height / 2);

            StartButton.Click += StartButton_click;

        }

        private void StartButton_click(object sender, EventArgs e)
        {
            FrmLevel frmlevel = new FrmLevel();
            frmlevel.Show();
            this.Close();
        }
    }
}
