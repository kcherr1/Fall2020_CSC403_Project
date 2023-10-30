using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmPlayerSelect : Form
    {
        private Player player;
        private TextBox playerNameTextBox;
        int selected = 0;
        private PictureBox TankPic;
        private PictureBox RoguePic;
        private PictureBox SwordsmanPic;
        private Form MainMenu;
        

        public FrmPlayerSelect(Form MainMenu)
        private Label InstructionLabel;

        public FrmPlayerSelect()
        {
            this.MainMenu = MainMenu;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.setup();
        }

        private void setup()
        {
            this.BackColor = Color.DimGray;

            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            // Create Picture Boxes for each player type
            TankPic = new PictureBox();
            RoguePic = new PictureBox();
            SwordsmanPic= new PictureBox();

            TankPic.Parent = this;
            RoguePic.Parent = this;
            SwordsmanPic.Parent = this;

            TankPic.Image = Properties.Resources.tank;
            RoguePic.Image = Properties.Resources.rogue;
            SwordsmanPic.Image = Properties.Resources.swordsman;

            TankPic.Size = new Size((5 * width / 12) - (width / 6), (2*height)/3);
            RoguePic.Size = new Size((5*width / 12) - (width / 6), (2 * height) / 3);
            SwordsmanPic.Size = new Size((5*width / 12) - (width / 6), (2 * height) / 3);

            TankPic.SizeMode = PictureBoxSizeMode.StretchImage;
            RoguePic.SizeMode = PictureBoxSizeMode.StretchImage;
            SwordsmanPic.SizeMode = PictureBoxSizeMode.StretchImage;

            TankPic.Location = new Point(0+width/12, 0+height/12);
            RoguePic.Location = new Point(0 + width / 12+TankPic.Width + width/16, 0 + height / 12);
            SwordsmanPic.Location = new Point(0 + width / 12+(2* TankPic.Width) + width/8, 0 + height / 12);

            TankPic.BackColor = Color.Transparent;
            RoguePic.BackColor = Color.Transparent;
            SwordsmanPic.BackColor = Color.Transparent;

            TankPic.Click += TankPic_Click;
            RoguePic.Click += RoguePic_Click;
            SwordsmanPic.Click += SwordsmanPic_Click;


            // Add player type labels

            Label TankLabel = new Label();
            Label RogueLabel = new Label();
            Label SwordsmanLabel = new Label();

            TankLabel.AutoSize = false;
            TankLabel.BackColor = Color.Transparent;
            TankLabel.Parent = this;
            TankLabel.Text = "Tank";
            TankLabel.Size = new Size(TankPic.Width, height / 12);
            TankLabel.Font = new Font("NSimSun", TankLabel.Height / 2);
            TankLabel.Location = new Point(TankPic.Location.X+TankPic.Width/3, TankPic.Location.Y - TankLabel.Height);

            RogueLabel.AutoSize = false;
            RogueLabel.BackColor = Color.Transparent;
            RogueLabel.Parent = this;
            RogueLabel.Text = "Rogue";
            RogueLabel.Size = new Size(RoguePic.Width, height / 12);
            RogueLabel.Font = new Font("NSimSun", RogueLabel.Height / 2);
            RogueLabel.Location = new Point(RoguePic.Location.X+RoguePic.Width/3, RoguePic.Location.Y - RogueLabel.Height);

            SwordsmanLabel.AutoSize = false;
            SwordsmanLabel.BackColor = Color.Transparent;
            SwordsmanLabel.Parent = this;
            SwordsmanLabel.Text = "Swordsman";
            SwordsmanLabel.Size = new Size(SwordsmanPic.Width, height / 12);
            SwordsmanLabel.Font = new Font("NSimSun", SwordsmanLabel.Height / 2);
            SwordsmanLabel.Location = new Point(SwordsmanPic.Location.X+SwordsmanPic.Width/5, SwordsmanPic.Location.Y - SwordsmanLabel.Height);


            // Add Start Game Button
            Button StartGame_Button = new Button();
            StartGame_Button.Parent = this;
            StartGame_Button.Text = "Start Game";
            StartGame_Button.Size = new Size(width / 5, height / 12);
            StartGame_Button.Location = new Point(3 * width / 4, 13 * height / 16);
            StartGame_Button.Font = new Font("NSimSun", StartGame_Button.Height / 2);
            StartGame_Button.Click += StartGame_Button_Click;


            // Add a TextBox for the user to input their name
            playerNameTextBox = new TextBox();
            playerNameTextBox.Parent = this;
            playerNameTextBox.TextAlign = HorizontalAlignment.Center;
            playerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            playerNameTextBox.AutoSize = false;
            playerNameTextBox.Size = new Size(width / 5, height / 12);
            playerNameTextBox.Location = new Point(1* width / 4, 13*height / 16);
            playerNameTextBox.Font = new Font("NSimSun", playerNameTextBox.Height / 4);
            playerNameTextBox.Text = "Enter your name"; // Set initial text
            playerNameTextBox.Click += playerNameTextBox_Click;

            // Add instructions
            InstructionLabel = new Label();
            InstructionLabel.AutoSize = false;
            InstructionLabel.TextAlign = ContentAlignment.MiddleCenter;
            InstructionLabel.BackColor = Color.Black;
            InstructionLabel.ForeColor = Color.Red;
            InstructionLabel.Parent = this;
            InstructionLabel.Text = "Choose a class by clicking the image, and enter a name";
            InstructionLabel.Size = new Size(width, height / 20);
            InstructionLabel.Font = new Font("NSimSun", TankLabel.Height / 2);
            InstructionLabel.Location = new Point(0,115*height/128);


        }

        private void StartGame_Button_Click(object sender, EventArgs e)
        {
            string playerName = playerNameTextBox.Text.Trim(); // Get the input from the TextBox

            if (selected == 0)
            {
                InstructionLabel.Text = "I said pick a class and choose a name.";
                return;
            }

            if (string.IsNullOrWhiteSpace(playerName) || playerName == "Enter your name")
            {
                InstructionLabel.Text = "I said pick a class and choose a name.";
                return;
            }

            PictureBox img = null;
            switch (selected)
            {
                case 1:
                    img = MakePictureBox(Properties.Resources.tank, new Point(100, this.Height - 200), new Size(50, 100));
                    this.player = new Player(playerName, img, new Tank());
                    break;
                case 2:
                    img = MakePictureBox(Properties.Resources.rogue, new Point(100, this.Height - 200), new Size(50, 100));
                    this.player = new Player(playerName, img, new Rogue());
                    break;
                case 3:
                    img = MakePictureBox(Properties.Resources.swordsman, new Point(100, this.Height - 200), new Size(50, 100));
                    this.player = new Player(playerName, img, new Swordsman());
                    break;
            }

            if (this.player != null)
            {
                FrmLevel frmlevel = new FrmLevel(MainMenu, player);
                frmlevel.FormClosed += (s, args) => this.Close();
                frmlevel.Show();
                this.Hide();
            }
        }

        private void playerNameTextBox_Click(object sender, EventArgs e)
        {
            playerNameTextBox.Text = "";
        }

        private void TankPic_Click(object sender, EventArgs e)
        {
            TankPic.BackColor = Color.Transparent;
            RoguePic.BackColor = Color.Transparent;
            SwordsmanPic.BackColor = Color.Transparent;
            selected = 1;
            TankPic.BackColor = Color.White;

        }

        private void RoguePic_Click(object sender, EventArgs e)
        {
            TankPic.BackColor = Color.Transparent;
            RoguePic.BackColor = Color.Transparent;
            SwordsmanPic.BackColor = Color.Transparent;
            selected = 2;
            RoguePic.BackColor = Color.White;
        }

        private void SwordsmanPic_Click(object sender, EventArgs e)
        {
            TankPic.BackColor = Color.Transparent;
            RoguePic.BackColor = Color.Transparent;
            SwordsmanPic.BackColor = Color.Transparent;
            selected = 3;
            SwordsmanPic.BackColor = Color.White;
        }


        public PictureBox MakePictureBox(Bitmap pic, Point location, Size Size)
        {
            return new PictureBox
            {
                Size = Size,
                Location = location,
                Image = pic,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent
            };
        }
    }
}
