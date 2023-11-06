﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using System.Text.Json;
using System.IO;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {

        private Form MainMenu;

        public int AreaNum { get; set; }
        public int score;

        public bool gameOver { get; set; }

        private DateTime timeBegin;
        private FrmBattleScreen frmBattleScreen;
        private FrmInventory frminventory;

        private Size itemSize = new Size(50, 50);
        private Size signSize = new Size(75, 50);

        public SoundPlayer gameAudio;

        public Area[] Areas;
        public PictureBox TerrainPic;

        private Direction TravelDirection = Direction.None;

        public Label ScoreLabel;

        public FrmLevel(Form MainMenu)
        {
            this.KeyPreview = true;
            this.DoubleBuffered = true;

            this.ScoreLabel = null;

            this.score = 0;

            this.gameAudio = new SoundPlayer(Resources.Game_audio);

            this.gameOver = false;
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            this.MainMenu = MainMenu;

            this.AreaNum = 4;



        }


        private void FrmLevel_Load(object sender, EventArgs e)
        {
            Game.Areas = new Area[10];
            Game.Areas[0] = new Area("Malek's Mountain", 12, 0.05);
            Game.Areas[1] = new Area("Village Ruins", 901, 0.05);
            Game.Areas[2] = new Area("Buddy Beachfront", 890, 0.05);
            Game.Areas[3] = new Area("Uphill Hill", 789, 0.05);
            Game.Areas[4] = new Area("Plainsfield", 678, 0.05);
            Game.Areas[5] = new Area("Lower Harmony Village", 567, 0.05);
            Game.Areas[6] = new Area("Windy Plateau", 456, 0.05);
            Game.Areas[7] = new Area("Harmony Plains", 345, 0.05);
            Game.Areas[8] = new Area("Harmony Village", 623, 0.15);
            Game.Areas[9] = new Area("Dragon's Lair", 123, 0.2);

            Game.CurrentArea = Game.Areas[this.AreaNum];

            for (int i = 0; i < 9; i++)
            {
                setAdjacency(i);
            }

            AreaSelect();

            InitializeAreaLayout();
            timeBegin = DateTime.Now;

            this.ScoreLabel = new Label();
            this.Controls.Add(ScoreLabel);
            ScoreLabel.BackColor = Color.Black;
            ScoreLabel.ForeColor = Color.White;
            ScoreLabel.Text = "Score: " + score.ToString();
            ScoreLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width - ScoreLabel.Width - 20, 15);
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

            SignPanel.Size = new Size(Screen.PrimaryScreen.Bounds.Width * 7 / 8, Screen.PrimaryScreen.Bounds.Height * 7 / 8);
            SignPanel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - SignPanel.Width / 2, 0);

            TravelLabel.Size = new Size(SignPanel.Size.Width, SignPanel.Size.Height / 2);
            TravelLabel.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - TravelLabel.Width / 2, 0);

            TravelButton.Size = new Size(SignPanel.Size.Width - 200, SignPanel.Size.Height / 4);
            TravelButton.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - SignPanel.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2);


        }

        private void InitializeAreaLayout()
        {

            if (Game.CurrentArea.Terrain != null)
            {

                Bitmap combinedImage = new Bitmap(Terrain.GridWidth * Terrain.TileSize.Width, Terrain.GridHeight * Terrain.TileSize.Width);
                using (Graphics g = Graphics.FromImage(combinedImage))
                {
                    for (int col = 0; col < Terrain.GridWidth; col++)
                    {
                        for (int row = 0; row < Terrain.GridHeight; row++)
                        {

                            int imageIndex = col + Terrain.GridWidth * row;

                            Image image = Game.CurrentArea.Terrain.Tiles[imageIndex].Pic;
                            g.DrawImage(image, new Point(col * Terrain.TileSize.Width, row * Terrain.TileSize.Width));
                        }
                    }
                }
                this.BackgroundImage = combinedImage;

                if (Game.CurrentArea.TravelSigns != null)
                {
                    foreach (Direction direction in Game.CurrentArea.TravelSigns.Keys)
                    {
                        Controls.Add(Game.CurrentArea.TravelSigns[direction].Pic);
                    }
                }

                if (Game.CurrentArea.Structures != null)
                {
                    for (int i = 0; i < Game.CurrentArea.Structures.Count; i++)
                    {
                        this.Controls.Add(Game.CurrentArea.Structures[i].Pic);
                    }
                }
                if (Game.CurrentArea.Items != null)
                {
                    for (int i = 0; i < Game.CurrentArea.Items.Count; i++)
                    {
                        this.Controls.Add(Game.CurrentArea.Items[i].Pic);
                    }
                }
            }


            if (Game.CurrentArea.Enemies != null)
            {
                for (int i = 0; i < Game.CurrentArea.Enemies.Count; i++)
                {
                    this.Controls.Add(Game.CurrentArea.Enemies[i].Pic);
                }
            }

            if(Game.CurrentArea.npcs != null)
            {
                for (int i = 0; i < Game.CurrentArea.npcs.Count; i++)
                {
                    this.Controls.Add(Game.CurrentArea.npcs[i].Pic);
                    Game.CurrentArea.npcs[i].Pic.BringToFront();
                }
            }

            if (Game.player != null)
            {
                this.Controls.Add(Game.player.Pic);
                Game.player.Pic.BringToFront();
            }

        }

        public void AddItemToScreen(Item item)
        {
            Controls.Add(item.Pic);
            Game.CurrentArea.Items.Add(item);
        }

        public PictureBox MakePictureBox(Bitmap pic, Point location, Size Size)
        {
            return new PictureBox
            {
                Size = Size,
                Location = location,
                Image = pic,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
            };
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            Game.player.ResetMoveSpeed();
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    Game.player.GoLeft();
                    break;

                case Keys.D:
                    Game.player.GoRight();
                    break;

                case Keys.W:
                    Game.player.GoUp();
                    break;

                case Keys.S:
                    Game.player.GoDown();
                    break;

                case Keys.E:
                    Game.player.ResetMoveSpeed();
                    frminventory = FrmInventory.GetInstance();
                    frminventory.Show();
                    break;

                case Keys.Escape:
                    FrmSettings frmsettings = new FrmSettings(this);
                    frmsettings.FormClosed += (s, args) => this.Close(); // Handle closure of FrmLevel to close the application
                    frmsettings.Show();
                    this.Hide();
                    break;

                default:
                    Game.player.ResetMoveSpeed();
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

            // move Game.playerd
            Game.player.Move();

            // check collision with walls
            if (HitAWall(Game.player))
            {
                Game.player.MoveBack();
            }

            // check collision with enemies
            int x = hitEnemy(Game.player);
            if (x >= 0)
            {
                Fight(Game.CurrentArea.Enemies[x]);


            }

            // check collision with NPCs
            int npcIndex = hitNPC(Game.player);
            if (npcIndex >= 0)
            {
                Converse(Game.CurrentArea.npcs[npcIndex]);
                Controls.Remove(Game.CurrentArea.npcs[npcIndex].Pic);
                Game.CurrentArea.npcs.Remove(Game.CurrentArea.npcs[npcIndex]);
            }

            x = HitAnItem(Game.player);
            if (x >= 0)
            {
                if (!Game.player.Inventory.BackpackIsFull())
                {
                    Item item = Game.CurrentArea.Items[x];
                    Game.CurrentArea.Items.Remove(item);
                    Game.player.Inventory.AddToBackpack(item);
                    item.HideEntity();
                }

            }

            x = InATile(Game.player);
            if (x >= 0 && x < Game.CurrentArea.Terrain.Tiles.Count)
            {
                Game.player.SPEED = (int)Game.CurrentArea.Terrain.Tiles[x].Effect;
            }

            this.TravelDirection = InASign(Game.player);
            if (this.TravelDirection != Direction.None)
            {
                TravelLabel.Text = Game.CurrentArea.TravelSigns[this.TravelDirection].Location;
                TravelButton.Enabled = true;
                SignPanel.Show();
                SignPanel.BringToFront();

            }
            else
            {
                SignPanel.Hide();
                TravelButton.Enabled = false;
            }

        }

        private Direction InASign(Player you)
        {
            foreach (Direction direction in Game.CurrentArea.TravelSigns.Keys)
            {
                if (you.Collider.Intersects(Game.CurrentArea.TravelSigns[direction].Collider))
                {
                    return direction;
                }
            }
            return Direction.None;
        }

        private bool HitAWall(Player c)
        {
            bool hitAWall = false;
            for (int w = 0; w < Game.CurrentArea.Structures.Count; w++)
            {
                if (c.Collider.Intersects(Game.CurrentArea.Structures[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private int hitEnemy(Player you)
        {
            if (Game.CurrentArea.Enemies == null)
            {
                return -1;
            }
            int hitChar = -1;
            for (int i = 0; i < Game.CurrentArea.Enemies.Count; i++)
            {
                if (Game.CurrentArea.Enemies[i] != null)
                {
                    if (you.Collider.Intersects(Game.CurrentArea.Enemies[i].Collider))
                    {
                        hitChar = i;
                        break;
                    }
                }
            }
            return hitChar;
        }

        private int hitNPC(Player you)
        {
            if(Game.CurrentArea.npcs == null)
            {
                return -1;
            }
            int hitChar = -1;
            for (int i = 0; i < Game.CurrentArea.npcs.Count; i++)
            {
                if (Game.CurrentArea.npcs[i] != null)
                {
                    if (you.Collider.Intersects(Game.CurrentArea.npcs[i].Collider))
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
            if (Game.CurrentArea.Items == null)
            {
                return -1;
            }
            int hitItem = -1;
            for (int i = 0; i < Game.CurrentArea.Items.Count; i++)
            {
                if (Game.CurrentArea.Items[i] != null)
                {
                    if (you.Collider.Intersects(Game.CurrentArea.Items[i].Collider))
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
            Game.player.ResetMoveSpeed();
            Game.player.MoveBack();
            frmBattleScreen = FrmBattleScreen.GetInstance(this, enemy);
            frmBattleScreen.Show();
        }

        public void RemoveEnemy(Enemy enemy)
        {
            Controls.Remove(enemy.Pic);
            Game.CurrentArea.Enemies.Remove(enemy);
            score += 100;
            ScoreLabel.Text = "Score: " + score.ToString();
        }

        private void Converse(NPC npc)
        {
            Game.player.ResetMoveSpeed();
            Game.player.MoveBack();

            // TODO: Insert conversation mechanic here

            if(Game.player.isPartyFull())
            {
                Console.WriteLine("PARTY IS FULL NOTIFICATION");
            }
            else
            {
                Game.player.addPartyMember(npc);
            }
        }

        public void GameOver()
        {
            this.gameOver = true;
            Game.player.SetEntityPosition(new Position(-100, -100));


            DisposeLevel();
            DisposeGame();



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

            RecordLeaderboardData();

            gameAudio.Stop();
        }

        private void RecordLeaderboardData()
        {
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


            for (int i = 0; i < topScores.Count; i++)
            {
                if (score > topScores[i])
                {
                    topPlayers.Insert(i, Game.player.Name);
                    topPlayers.RemoveAt(topPlayers.Count - 1);
                    topClasses.Insert(i, Game.player.archetype.name);
                    topClasses.RemoveAt(topClasses.Count - 1);
                    topScores.Insert(i, score);
                    topScores.RemoveAt(topScores.Count - 1);
                    if (Game.player.Inventory.Weapon != null)
                    {
                        topWeapons.Insert(i, Game.player.Inventory.Weapon.Name);
                        topWeapons.RemoveAt(topWeapons.Count - 1);
                    }
                    if (Game.player.Inventory.Armor != null)
                    {
                        topArmors.Insert(i, Game.player.Inventory.Armor.Name);
                        topArmors.RemoveAt(topArmors.Count - 1);
                    }
                    if (Game.player.Inventory.Utility != null)
                    {
                        topUtilities.Insert(i, Game.player.Inventory.Utility.Name);
                        topUtilities.RemoveAt(topUtilities.Count - 1);
                    }
                    break;
                }
            }
            string[] data = new string[9];
            data[0] = JsonSerializer.Serialize(topPlayers);
            data[1] = JsonSerializer.Serialize(topClasses);
            data[2] = JsonSerializer.Serialize(topScores);
            data[3] = JsonSerializer.Serialize(topWeapons);
            data[4] = JsonSerializer.Serialize(topArmors);
            data[5] = JsonSerializer.Serialize(topUtilities);

            File.WriteAllLines(filepath, data);
        }


        private void DisposeLevel()
        {

            foreach (Direction direction in Game.CurrentArea.TravelSigns.Keys)
            {
                this.Controls.Remove(Game.CurrentArea.TravelSigns[direction].Pic);
            }

            for (int i = 0; i < Game.CurrentArea.Enemies.Count; i++)
            {
                this.Controls.Remove(Game.CurrentArea.Enemies[i].Pic);
            }

            for (int i = 0; i < Game.CurrentArea.npcs.Count; i++)
            {
                this.Controls.Remove(Game.CurrentArea.npcs[i].Pic);
            }
            Game.CurrentArea.npcs = new List<NPC> { };

            //remove terrain here

            for (int i = 0; i < Game.CurrentArea.Items.Count; i++)
            {
                this.Controls.Remove(Game.CurrentArea.Items[i].Pic);
            }
            for (int i = 0; i < Game.CurrentArea.Structures.Count; i++)
            {
                this.Controls.Remove(Game.CurrentArea.Structures[i].Pic);
            }

            GC.Collect();

        }

        private void DisposeGame()
        {
            for (int i = 0; i < Game.Areas.Length; i++)
            {
                Game.Areas[i].Enemies = new List<Enemy> { };
                Game.Areas[i].TravelSigns.Clear();
                Game.Areas[i].AdjacentAreas.Clear();
                Game.Areas[i].Terrain.Tiles.Clear();
                Game.Areas[i].Items.Clear();
                Game.Areas[i].Structures.Clear();
            }
            Game.Areas = new Area[10];
            GC.Collect();

        }


        private void Menu_Click(object sender, EventArgs e)
        {
            frminventory = FrmInventory.GetInstance();
            frminventory.Show();
        }


        private void RestartButton_Click(object sender, EventArgs e)
        {
            this.score = 0;
            gameAudio.PlayLooping();

            Game.Areas[0] = new Area("Malek's Mountain", 12, 0.05);
            Game.Areas[1] = new Area("Village Ruins", 901, 0.05);
            Game.Areas[2] = new Area("Buddy Beachfront", 890, 0.05);
            Game.Areas[3] = new Area("Uphill Hill", 789, 0.05);
            Game.Areas[4] = new Area("Plainsfield", 678, 0.05);
            Game.Areas[5] = new Area("Lower Harmony Village", 567, 0.05);
            Game.Areas[6] = new Area("Windy Plateau", 456, 0.05);
            Game.Areas[7] = new Area("Harmony Plains", 345, 0.05);
            Game.Areas[8] = new Area("Harmony Village", 234, 0.05);
            Game.Areas[9] = new Area("Dragon's Lair", 123, 0.2);

            this.gameOver = false;
            Game.player = new Player(Game.player.Name, Game.player.Pic, Game.player.archetype);

            BlackSquare.Visible = false;
            GameOverText.Visible = false;
            RestartButton.Visible = false;
            ExitButton.Visible = false;
            MainMenuButton.Visible = false;

            RestartButton.Enabled = false;
            ExitButton.Enabled = false;
            MainMenuButton.Enabled = false;

            this.AreaNum = 4;
            AreaSelect();
            InitializeAreaLayout();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Game.player = null;
            Game.player = null;
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
            Game.CurrentArea = Game.Areas[this.AreaNum];
            switch (this.AreaNum)
            {
                case 0:
                    Area0();
                    break;
                case 1:
                    Area1();
                    break;
                case 2:
                    Area2();
                    break;
                case 3:
                    Area3();
                    break;
                case 4:
                    Area4();
                    break;
                case 5:
                    Area5();
                    break;
                case 6:
                    Area6();
                    break;
                case 7:
                    Area7();
                    break;
                case 8:
                    Area8();
                    break;
                case 9:
                    AreaBoss();
                    break;

                default:
                    Area4();
                    break;
            }
        }

        private void AreaBoss()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;
        }

        private void Area8()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;


            Bitmap house_long = Resources.house_long;

            Bitmap house_long_rot = Resources.house_long;
            house_long_rot.RotateFlip(RotateFlipType.Rotate90FlipNone);

            Bitmap house_L = Resources.house_L;

            Bitmap house_L_rot90 = Resources.house_L;
            house_L_rot90.RotateFlip(RotateFlipType.Rotate90FlipNone);

            Bitmap house_L_rot180 = Resources.house_L;
            house_L_rot180.RotateFlip(RotateFlipType.Rotate180FlipNone);

            Size longSize = new Size(Terrain.TileSize.Width * 6, Terrain.TileSize.Height * 3);
            Size longSize_rot = new Size(longSize.Height, longSize.Width);
            Size L_Size = new Size(Terrain.TileSize.Width * 6, Terrain.TileSize.Height * 4);
            Size L_Size_rot90 = new Size(L_Size.Height, L_Size.Width);

            Game.CurrentArea.AddStructure(new Structure(MakePictureBox(house_long_rot, new Point(Screen.PrimaryScreen.Bounds.Width * 3 / 4 - 100 , - 100), longSize_rot)));
            Game.CurrentArea.AddStructure(new Structure(MakePictureBox(house_long, new Point(Screen.PrimaryScreen.Bounds.Width / 2, 400), longSize)));
            Game.CurrentArea.AddStructure(new Structure(MakePictureBox(house_L, new Point(Screen.PrimaryScreen.Bounds.Width * 3 / 4, 300), L_Size)));
            Game.CurrentArea.AddStructure(new Structure(MakePictureBox(house_L_rot180, new Point(Screen.PrimaryScreen.Bounds.Width * 1 / 4, 80), L_Size)));


        }

        private void Area7()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;

        }

        private void Area6()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;

        }

        private void Area5()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;

        }



        private void Area4()
        {
            // leave this here, default case when this.AreaNum is unset.
            this.AreaNum = 4;

            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;


            Game.player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width / 2 - Game.player.Pic.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - Game.player.Pic.Height));
            Game.player.Pic.Visible = true;


            Game.CurrentArea.AddItem(new Item("Sting", MakePictureBox(Resources.common_dagger, new Point(300, 200), itemSize), 5, Item.ItemType.Weapon));
            Game.CurrentArea.AddItem(new Item("Lesser Heal", MakePictureBox(Resources.lesser_health_potion, new Point(500, 300), itemSize), 5, Item.ItemType.Utility, Item.PotionTypes.Healing));
            Game.CurrentArea.AddItem(new Item("Armor of Noob", MakePictureBox(Resources.common_armor, new Point(880, 800), itemSize), 5, Item.ItemType.Armor));
            Game.CurrentArea.AddItem(new Item("Potion of Speed", MakePictureBox(Resources.speed_potion, new Point(20, 400), itemSize), 10, Item.ItemType.Utility, Item.PotionTypes.Speed));

            Game.CurrentArea.AddEnemy(new Enemy("Poison Packet", MakePictureBox(Resources.enemy_poisonpacket, new Point(200, 500), new Size(100, 100)), new Minion()));
            Game.CurrentArea.AddEnemy(new Enemy("Cheeto", MakePictureBox(Resources.enemy_cheetos, new Point(600, 200), new Size(75, 125)), new Minion()));
            Game.CurrentArea.AddEnemy(new Enemy("BossKoolAid", MakePictureBox(Resources.enemy_koolaid, new Point(this.Width - 200, 100), new Size(150, 150)), new Boss()));

            Game.CurrentArea.AddNPC(new NPC("Harold", MakePictureBox(Resources.harold, new Point(150, 150), new Size(75, 100)), new Healer()));
            Game.CurrentArea.AddStructure(new Structure(MakePictureBox(Resources.wall_bricks, new Point(500, 500), new Size(20, 100))));
            Game.CurrentArea.Structures[0].Pic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void Area3()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;

        }

        private void Area2()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;

        }

        private void Area1()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }
            Game.CurrentArea.Visited = true;

        }

        private void Area0()
        {
            
            if (Game.CurrentArea.Visited)
            {
                return;
            }

            Game.CurrentArea.Visited = true;

        }


        private void setAdjacency(int area)
        {
            int up = area > 5 ? -1 : area + 3;
            int down = area < 3 ? -1 : area - 3;
            int left = area % 3 == 0 ? -1 : area - 1;
            int right = area % 3 == 2 ? -1 : area + 1;

            if (up >= 0)
            {
                Game.Areas[area].SetAdjacentArea(Direction.Up, up);
                Game.Areas[area].SetTravelSign(Direction.Up, new TravelSign(Game.Areas[up].AreaName, MakePictureBox(Resources.travel_sign, new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.signSize.Width / 2, 10), this.signSize)));
            }
            if (down >= 0)
            {
                Game.Areas[area].SetAdjacentArea(Direction.Down, down);
                Game.Areas[area].SetTravelSign(Direction.Down, new TravelSign(Game.Areas[down].AreaName, MakePictureBox(Resources.travel_sign, new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.signSize.Width / 2, Screen.PrimaryScreen.Bounds.Height - 80 - this.signSize.Height), this.signSize)));

            }
            if (left >= 0)
            {
                Game.Areas[area].SetAdjacentArea(Direction.Left, left);
                Game.Areas[area].SetTravelSign(Direction.Left, new TravelSign(Game.Areas[left].AreaName, MakePictureBox(Resources.travel_sign, new Point(10, Screen.PrimaryScreen.Bounds.Height / 2 - this.signSize.Height / 2), this.signSize)));

            }
            if (right >= 0)
            {
                Game.Areas[area].SetAdjacentArea(Direction.Right, right);
                Game.Areas[area].SetTravelSign(Direction.Right, new TravelSign(Game.Areas[right].AreaName, MakePictureBox(Resources.travel_sign, new Point(Screen.PrimaryScreen.Bounds.Width - 10 - this.signSize.Width, Screen.PrimaryScreen.Bounds.Height / 2 - this.signSize.Height / 2), this.signSize)));

            }
        }

        private void TravelButton_Click(object sender, EventArgs e)
        {
            DisposeLevel();
            this.AreaNum = Game.CurrentArea.AdjacentAreas[this.TravelDirection];

            switch (this.TravelDirection)
            {
                case Direction.Up:
                    Game.player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width / 2 - Game.player.Pic.Width / 2, Screen.PrimaryScreen.Bounds.Height - signSize.Height - Game.player.Pic.Height  - 100));
                    break;
                case Direction.Down:
                    Game.player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width / 2 - Game.player.Pic.Width / 2, signSize.Height + 20));
                    break;
                case Direction.Right:
                    Game.player.SetEntityPosition(new Position(signSize.Width + 10, Screen.PrimaryScreen.Bounds.Height / 2 - Game.player.Pic.Height / 2));
                    break;
                case Direction.Left:
                    Game.player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width - signSize.Width - 20 - Game.player.Pic.Width, Screen.PrimaryScreen.Bounds.Height / 2 - Game.player.Pic.Height / 2));
                    break;

                default:
                    Game.player.SetEntityPosition(new Position(Screen.PrimaryScreen.Bounds.Width / 2 - Game.player.Pic.Width, Screen.PrimaryScreen.Bounds.Height - Game.player.Pic.Height));
                    break;
            }

            AreaSelect();


            InitializeAreaLayout();

        }
    }
}
