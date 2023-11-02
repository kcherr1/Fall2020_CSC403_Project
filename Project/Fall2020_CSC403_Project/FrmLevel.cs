using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Threading;
using System.Media;
using System.Text.Json;
using System.IO;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;
        private List<Enemy> enemies;
        private Terrain terrain;

        private Form MainMenu;

        public int Level { get; set; }
        public int score;

        public bool gameOver { get; set; }

		private DateTime timeBegin;
		private FrmBattle frmBattle;
        private FrmInventory frminventory;

        private Size itemSize = new Size(50, 50);

        public SoundPlayer gameAudio;

        public Label ScoreLabel;

        public FrmLevel(Form MainMenu, Player player)
        {
            this.KeyPreview = true;
            this.DoubleBuffered = true;

            this.ScoreLabel = null;

            this.score = 0;

            this.gameAudio = new SoundPlayer(Resources.Game_audio);

            this.player = player;
            this.gameOver = false;
            this.WindowState = FormWindowState.Maximized;
            this.Level = 1;
            InitializeComponent();
            this.MainMenu = MainMenu;
        }

        
        private void FrmLevel_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            Size TileSize = new Size(width / 15, width / 15);
            int grid_width = width / TileSize.Width;
            int grid_height = height / TileSize.Width;

            

            this.terrain = new Terrain(grid_width, grid_height, TileSize);
            enemies = new List<Enemy> { };

            LevelSelect();


            InitializeLevelLayout();
            Game.player = player;
            timeBegin = DateTime.Now;

            this.ScoreLabel = new Label();
            this.Controls.Add(ScoreLabel);
            ScoreLabel.BackColor = Color.Black;
            ScoreLabel.ForeColor = Color.White;
            ScoreLabel.Text = "Score: " + score.ToString();
            ScoreLabel.Location = new Point(width - ScoreLabel.Width - 20, 15);
            ScoreLabel.Font = new Font("Microsoft Sans Serif", 11);
            ScoreLabel.Visible = true;
            ScoreLabel.BringToFront();
            
            
            

            //Adding stop condition to mainMenu_music here
            FrmMain mainMenuPlayer = Application.OpenForms["FrmMain"] as FrmMain;
            FrmMain mainMenu = Application.OpenForms["FrmMain"] as FrmMain;
            if (mainMenu != null && mainMenu.mainMenuPlayer != null)
            {
                mainMenu.mainMenuPlayer.Stop();
                mainMenu.mainMenuPlayer.Dispose();
            }

            //Adding gameAudio here
            this.gameAudio.PlayLooping();
        }

        private void InitializeLevelLayout()
        {

            if (this.terrain != null)
            {
                if (this.terrain.Tiles != null)
                {
                    for (int i = 0; i < this.terrain.Tiles.Count; i++)
                    {
                        this.Controls.Add(this.terrain.Tiles[i].Pic);
                        this.terrain.Tiles[i].Pic.SendToBack();
                    }
                }
                if (this.terrain.Walls != null)
                {
                    for (int i = 0; i < this.terrain.Walls.Count; i++)
                    {
                        this.Controls.Add(this.terrain.Walls[i].Pic);
                        this.terrain.Walls[i].Pic.BringToFront();
                    }
                }
                if (this.terrain.Items != null)
                {
                    for (int i = 0; i < this.terrain.Items.Count; i++)
                    {
                        this.Controls.Add(this.terrain.Items[i].Pic);
                        this.terrain.Items[i].Pic.BringToFront();
                    }
                }
            }


            if (enemies != null)
            {
                for (int i = 0; i < enemies.Count; i++)
                {
                    this.Controls.Add(enemies[i].Pic);
                    enemies[i].Pic.BringToFront();
                }
            }


            if (player != null)
            {
                this.Controls.Add(player.Pic);
            }
            player.Pic.BringToFront();

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

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    player.GoLeft();
                    break;

                case Keys.D:
                    player.GoRight();
                    break;

                case Keys.W:
                    player.GoUp();
                    break;

                case Keys.S:
                    player.GoDown();
                    break;

                case Keys.E:
                    player.ResetMoveSpeed();
                    frminventory = FrmInventory.GetInstance(player);
                    frminventory.Show();
                    break;

                case Keys.Escape:
                    FrmSettings frmsettings = new FrmSettings(this);
                    frmsettings.FormClosed += (s, args) => this.Close(); // Handle closure of FrmLevel to close the application
                    frmsettings.Show();
                    this.Hide();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }


        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            if (gameOver)
            {
                return;
            }

            // move playerd
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            int x = HitAChar(player);
            if (x >= 0)
            {
                Fight(enemies[x]);
            }

            x = HitAnItem(player);
            if (x >= 0)
            {
                if (!player.Inventory.BackpackIsFull())
                {
                    player.Inventory.AddToBackpack(this.terrain.Items[x]);
                    this.terrain.Items[x].RemoveEntity();
                }

            }

            x = InATile(player);
            if (x >= 0 && x < this.terrain.Tiles.Count)
            {
                player.SPEED = (int)this.terrain.Tiles[x].Effect;
            }

        }

        private bool HitAWall(Player c)
        {
            bool hitAWall = false;
            for (int w = 0; w < this.terrain.Walls.Count; w++)
            {
                if (c.Collider.Intersects(this.terrain.Walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private int HitAChar(Player you)
        {
            if (enemies == null)
            {
                return -1;
            }
            int hitChar = -1;
            for (int i = 0; i < enemies.Count; i++)
            {
                if (enemies[i] != null)
                {
                    if (you.Collider.Intersects(enemies[i].Collider))
                    {
                        hitChar = i;
                        break;
                    }
                }
            }
            return hitChar;
        }

        private int HitAnItem(Player you)
        {
            if (this.terrain.Items == null)
            {
                return -1;
            }
            int hitItem = -1;
            for (int i = 0; i < this.terrain.Items.Count; i++)
            {
                if (this.terrain.Items[i] != null)
                {
                    if (you.Collider.Intersects(this.terrain.Items[i].Collider))
                    {
                        hitItem = i;
                        break;
                    }
                }
            }
            return hitItem;
        }

        public int InATile(Player you)
        {
            int x = ((int)you.Position.x + you.Pic.Width / 2) / this.terrain.TileSize.Width;
            int y = ((int)you.Position.y + you.Pic.Height) / this.terrain.TileSize.Width;

            int a = (int)((x) + Math.Floor((double)y * this.terrain.GridWidth));


            return a;
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(this, enemy);
            frmBattle.Show();

            if (enemy.Name == "BossKoolAid")
            {
                frmBattle.SetupForBossBattle();
            }
        }

        public void RemoveEnemy(Enemy enemy)
        {
            Controls.Remove(enemy.Pic);
            enemies.Remove(enemy);
            score += 100;
            ScoreLabel.Text = "Score: " + score.ToString();
        }

        public void GameOver()
        {
            this.gameOver = true;
            this.player.SetEntityPosition(new Position(-100, -100));

            DisposeLevel();


            // set the location and size of the square 
            // to the location and size of the form
            BlackSquare.Location = this.Location;
            BlackSquare.Size = this.Size;

            BlackSquare.Visible = true;
            BlackSquare.BringToFront();

            // find the x-coordinate to perfectly center the GameOverText
            int centerGameOverText = (this.Width / 2) - (GameOverText.Width / 2);

            GameOverText.Location = new Point(centerGameOverText, 100);
            GameOverText.Visible = true;
            GameOverText.BringToFront();

            // find the x-coordinate to offset the RestartButton from the center so that it's symmetrical
            int centerRestartButton = (this.Width / 2) - (RestartButton.Width / 2);


            RestartButton.Enabled = true;
            RestartButton.Location = new Point(centerRestartButton - 150, 400);
            RestartButton.Size = new Size(100, 30);
            RestartButton.Visible = true;
            RestartButton.BringToFront();

            // find the x-coordinate to offset the ExitButton from the center so that it's symmetrical
            int centerExitButton = (this.Width / 2) - (ExitButton.Width / 2);

            ExitButton.Enabled = true;
            ExitButton.Location = new Point(centerExitButton + 150, 400);
            ExitButton.Size = new Size(100, 30);
            ExitButton.Visible = true;
            ExitButton.BringToFront();

            // find the x-coordinate to put the MainMenuButton in the center
            int centerMainMenuButton = (this.Width / 2) - (MainMenuButton.Width / 2);

            MainMenuButton.Enabled = true;
            MainMenuButton.Location = new Point(centerMainMenuButton, 400);
            MainMenuButton.Size = new Size(100, 30);
            MainMenuButton.Visible = true;
            MainMenuButton.BringToFront();

            RecordData();

            gameAudio.Stop();
        }

        private void RecordData()
        {
            int[] TopScores = new int[10];
            for (int i = 0; i < TopScores.Length; i++)
            {
                if(score > TopScores[i])
                {
                    TopScores[i] = score;
                    break;
                }
            }
            string filepath = "../../data/GameData.json";
            string data = JsonSerializer.Serialize(TopScores);
            File.WriteAllText(filepath, data);
        }


        private void DisposeLevel()
        {
            // iterate through the controls and remove them from control

            for (int i = 0; i < this.enemies.Count; i++)
            {
                this.Controls.Remove(this.enemies[i].Pic);
            }
            this.enemies = new List<Enemy> { };


            for (int i = 0; i < this.terrain.Tiles.Count; i++)
            {
                this.Controls.Remove(this.terrain.Tiles[i].Pic);
            }
            this.terrain.Tiles.Clear();
            for (int i = 0; i < this.terrain.Items.Count; i++)
            {
                this.Controls.Remove(this.terrain.Items[i].Pic);
            }
            this.terrain.Items.Clear();
            for (int i = 0; i < this.terrain.Walls.Count; i++)
            {
                this.Controls.Remove(this.terrain.Walls[i].Pic);
            }
            this.terrain.Walls.Clear();
        }


        private void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            frminventory = FrmInventory.GetInstance(player);
            frminventory.Show();
        }


        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.score = 0;
            gameAudio.PlayLooping();

            this.gameOver = false;
            this.player = new Player(player.Name, player.Pic, player.archetype);
            Game.player = this.player;

            BlackSquare.Visible = false;
            GameOverText.Visible = false;
            RestartButton.Visible = false;
            ExitButton.Visible = false;
            MainMenuButton.Visible = false;

            RestartButton.Enabled = false;
            ExitButton.Enabled = false;
            MainMenuButton.Enabled = false;

            this.Level = 1;
            LevelSelect();
            InitializeLevelLayout();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Game.player = null;
            this.player = null;
            MainMenu.Show();
            FrmMain mainMenu = Application.OpenForms["FrmMain"] as FrmMain;
            mainMenu.mainMenuPlayer = new SoundPlayer(Resources.Mainmenu_audio);
            mainMenu.mainMenuPlayer.PlayLooping();
            this.gameAudio.Dispose();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LevelSelect()
        {
            switch (this.Level)
            {
                case 1:
                    Level1();
                    break;
                default:
                    Level1();
                    break;
            }
        }

        private void Level1()
        {
            
            player.SetEntityPosition(new Position(100, 700));
            player.Pic.Visible = true;


            this.terrain.GenerateTerrain(2);

            this.terrain.AddItem(new Item("Sting", MakePictureBox(Resources.common_dagger, new Point(300, 200), itemSize), 5, Item.ItemType.Weapon));
            this.terrain.AddItem(new Item("Lesser Heal", MakePictureBox(Resources.lesser_health_potion, new Point(500, 300), itemSize), 5, Item.ItemType.Utility, Item.PotionTypes.Healing));
            this.terrain.AddItem(new Item("Armor of Noob", MakePictureBox(Resources.common_armor, new Point(880, 800), itemSize), 5, Item.ItemType.Armor));
            this.terrain.AddItem(new Item("Potion of Speed", MakePictureBox(Resources.speed_potion, new Point(20, 400), itemSize), 10, Item.ItemType.Utility, Item.PotionTypes.Speed));

            AddEnemy(new Enemy("Poison Packet", MakePictureBox(Resources.enemy_poisonpacket, new Point(200, 500), new Size(100, 100)), new Minion()));
            AddEnemy(new Enemy("Cheeto", MakePictureBox(Resources.enemy_cheetos, new Point(600, 200), new Size(75, 125)), new Minion()));
            AddEnemy(new Enemy("BossKoolAid", MakePictureBox(Resources.enemy_koolaid, new Point(this.Width - 200, 100), new Size(150, 150)), new Boss()));
        }
    }
}
