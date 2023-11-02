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

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private Form MainMenu;

        public int Area { get; set; }

        public bool gameOver { get; set; }

        private DateTime timeBegin;
        private FrmBattle frmBattle;
        private FrmInventory frminventory;

        private Size itemSize = new Size(50, 50);

        public SoundPlayer gameAudio;

        public Area[] Areas;

        public FrmLevel(Form MainMenu, Player player)
        {
            this.KeyPreview = true;
            this.DoubleBuffered = true;

            this.gameAudio = new SoundPlayer(Resources.Game_audio);

            this.player = player;
            this.gameOver = false;
            this.WindowState = FormWindowState.Maximized;
            this.Area = 4;
            InitializeComponent();
            this.MainMenu = MainMenu;

            this.Areas = new Area[10];
        }


        private void FrmLevel_Load(object sender, EventArgs e)
        {
            AreaSelect();

            InitializeAreaLayout();
            Game.player = player;
            timeBegin = DateTime.Now;


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

        private void InitializeAreaLayout()
        {

            if (this.Areas[Area].Terrain != null)
            {
                if (this.Areas[Area].Terrain.Tiles != null)
                {
                    for (int i = 0; i < this.Areas[Area].Terrain.Tiles.Count; i++)
                    {
                        this.Controls.Add(this.Areas[Area].Terrain.Tiles[i].Pic);
                        this.Areas[Area].Terrain.Tiles[i].Pic.SendToBack();
                    }
                }
                if (this.Areas[Area].Walls != null)
                {
                    for (int i = 0; i < this.Areas[Area].Walls.Count; i++)
                    {
                        this.Controls.Add(this.Areas[Area].Walls[i].Pic);
                        this.Areas[Area].Walls[i].Pic.BringToFront();
                    }
                }
                if (this.Areas[Area].Items != null)
                {
                    for (int i = 0; i < this.Areas[Area].Items.Count; i++)
                    {
                        this.Controls.Add(this.Areas[Area].Items[i].Pic);
                        this.Areas[Area].Items[i].Pic.BringToFront();
                    }
                }
            }


            if (this.Areas[Area].Enemies != null)
            {
                for (int i = 0; i < this.Areas[Area].Enemies.Count; i++)
                {
                    this.Controls.Add(this.Areas[Area].Enemies[i].Pic);
                    this.Areas[Area].Enemies[i].Pic.BringToFront();
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
                Fight(this.Areas[Area].Enemies[x]);
                Controls.Remove(this.Areas[Area].Enemies[x].Pic);
                this.Areas[Area].Enemies.Remove(this.Areas[Area].Enemies[x]);

            }

            x = HitAnItem(player);
            if (x >= 0)
            {
                if (!player.Inventory.BackpackIsFull())
                {
                    player.Inventory.AddToBackpack(this.Areas[Area].Items[x]);
                    this.Areas[Area].Items[x].RemoveEntity();
                }

            }

            x = InATile(player);
            if (x >= 0 && x < this.Areas[Area].Terrain.Tiles.Count)
            {
                player.SPEED = (int)this.Areas[Area].Terrain.Tiles[x].Effect;
            }

        }

        private bool HitAWall(Player c)
        {
            bool hitAWall = false;
            for (int w = 0; w < this.Areas[Area].Walls.Count; w++)
            {
                if (c.Collider.Intersects(this.Areas[Area].Walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private int HitAChar(Player you)
        {
            if (this.Areas[Area].Enemies == null)
            {
                return -1;
            }
            int hitChar = -1;
            for (int i = 0; i < this.Areas[Area].Enemies.Count; i++)
            {
                if (this.Areas[Area].Enemies[i] != null)
                {
                    if (you.Collider.Intersects(this.Areas[Area].Enemies[i].Collider))
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
            if (this.Areas[Area].Items == null)
            {
                return -1;
            }
            int hitItem = -1;
            for (int i = 0; i < this.Areas[Area].Items.Count; i++)
            {
                if (this.Areas[Area].Items[i] != null)
                {
                    if (you.Collider.Intersects(this.Areas[Area].Items[i].Collider))
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
            int x = ((int)you.Position.x + you.Pic.Width / 2) / Terrain.TileSize.Width;
            int y = ((int)you.Position.y + you.Pic.Height) / Terrain.TileSize.Width;

            int a = (int)((x) + Math.Floor((double)y * Terrain.GridWidth));


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

            gameAudio.Stop();
        }


        private void DisposeLevel()
        {
            // iterate through the controls and remove them from control

            for (int i = 0; i < this.Areas[Area].Enemies.Count; i++)
            {
                this.Controls.Remove(this.Areas[Area].Enemies[i].Pic);
            }
            this.Areas[Area].Enemies = new List<Enemy> { };


            for (int i = 0; i < this.Areas[Area].Terrain.Tiles.Count; i++)
            {
                this.Controls.Remove(this.Areas[Area].Terrain.Tiles[i].Pic);
            }
            this.Areas[Area].Terrain.Tiles.Clear();
            for (int i = 0; i < this.Areas[Area].Items.Count; i++)
            {
                this.Controls.Remove(this.Areas[Area].Items[i].Pic);
            }
            this.Areas[Area].Items.Clear();
            for (int i = 0; i < this.Areas[Area].Walls.Count; i++)
            {
                this.Controls.Remove(this.Areas[Area].Walls[i].Pic);
            }
            this.Areas[Area].Walls.Clear();
        }


        private void AddEnemy(Enemy enemy)
        {
            this.Areas[Area].Enemies.Add(enemy);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            frminventory = FrmInventory.GetInstance(player);
            frminventory.Show();
        }


        private void RestartButton_Click(object sender, EventArgs e)
        {
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

            this.Area = 1;
            AreaSelect();
            InitializeAreaLayout();
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

        private void AreaSelect()
        {
            switch (this.Area)
            {
                case 1:
                    Area5();
                    break;
                default:
                    Area5();
                    break;
            }
        }




        private void Area4()
        {
            this.Area = 4;

            if (this.Areas[4] != null)
            {
                return;
            }

            this.Areas[4] = new Area(5, 0.05);

            this.Areas[4].SetAdjacentArea(Direction.Left, Areas[3]);
            this.Areas[4].SetAdjacentArea(Direction.Right, Areas[5]);
            this.Areas[4].SetAdjacentArea(Direction.Up, Areas[7]);
            this.Areas[4].SetAdjacentArea(Direction.Down, Areas[1]);


            player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width / 2 - player.Pic.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - player.Pic.Height));
            player.Pic.Visible = true;


            this.Areas[4].AddItem(new Item("Sting", MakePictureBox(Resources.common_dagger, new Point(300, 200), itemSize), 5, Item.ItemType.Weapon));
            this.Areas[4].AddItem(new Item("Lesser Heal", MakePictureBox(Resources.lesser_health_potion, new Point(500, 300), itemSize), 5, Item.ItemType.Utility, Item.PotionTypes.Healing));
            this.Areas[4].AddItem(new Item("Armor of Noob", MakePictureBox(Resources.common_armor, new Point(880, 800), itemSize), 5, Item.ItemType.Armor));
            this.Areas[4].AddItem(new Item("Potion of Speed", MakePictureBox(Resources.speed_potion, new Point(20, 400), itemSize), 10, Item.ItemType.Utility, Item.PotionTypes.Speed));

            this.Areas[4].AddEnemy(new Enemy("Poison Packet", MakePictureBox(Resources.enemy_poisonpacket, new Point(200, 500), new Size(100, 100)), new Minion()));
            this.Areas[4].AddEnemy(new Enemy("Cheeto", MakePictureBox(Resources.enemy_cheetos, new Point(600, 200), new Size(75, 125)), new Minion()));
            this.Areas[4].AddEnemy(new Enemy("BossKoolAid", MakePictureBox(Resources.enemy_koolaid, new Point(this.Width - 200, 100), new Size(150, 150)), new Boss()));

        }

        private void Area3()
        {
            this.Area = 3;

            if (this.Areas[3] != null) { }
            {
                return;
            }

            this.Areas[3] = new Area(5, 0.05);

            this.Areas[3].SetAdjacentArea(Direction.Right, Areas[4]);
            this.Areas[3].SetAdjacentArea(Direction.Up, Areas[6]);
            this.Areas[3].SetAdjacentArea(Direction.Down, Areas[0]);


            player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width / 2 - player.Pic.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - player.Pic.Height));
            player.Pic.Visible = true;


            this.Areas[3].AddItem(new Item("Sting", MakePictureBox(Resources.common_dagger, new Point(300, 200), itemSize), 5, Item.ItemType.Weapon));
            this.Areas[3].AddItem(new Item("Lesser Heal", MakePictureBox(Resources.lesser_health_potion, new Point(500, 300), itemSize), 5, Item.ItemType.Utility, Item.PotionTypes.Healing));
            this.Areas[3].AddItem(new Item("Armor of Noob", MakePictureBox(Resources.common_armor, new Point(880, 800), itemSize), 5, Item.ItemType.Armor));
            this.Areas[3].AddItem(new Item("Potion of Speed", MakePictureBox(Resources.speed_potion, new Point(20, 400), itemSize), 10, Item.ItemType.Utility, Item.PotionTypes.Speed));

            this.Areas[3].AddEnemy(new Enemy("Poison Packet", MakePictureBox(Resources.enemy_poisonpacket, new Point(200, 500), new Size(100, 100)), new Minion()));
            this.Areas[3].AddEnemy(new Enemy("Cheeto", MakePictureBox(Resources.enemy_cheetos, new Point(600, 200), new Size(75, 125)), new Minion()));
            this.Areas[3].AddEnemy(new Enemy("BossKoolAid", MakePictureBox(Resources.enemy_koolaid, new Point(this.Width - 200, 100), new Size(150, 150)), new Boss()));

        }

    }
}
