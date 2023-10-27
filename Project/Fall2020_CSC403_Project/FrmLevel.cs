using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Input;

namespace Fall2020_CSC403_Project
{
	public partial class FrmLevel : Form
	{
		private Player player;
		private List<Enemy> enemies;
        private Terrain terrain;

        public int Level { get; set; }
        public bool gameOver = false;


        private DateTime timeBegin;
		private FrmBattle frmBattle;

        public FrmLevel() {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();

        }

		private void InitializeLevel()
		{

			if (terrain != null)
			{
				if (terrain.Tiles != null)
				{
                    for (int i = 0; i < terrain.Tiles.Count; i++)
                    {
                        this.Controls.Add(terrain.Tiles[i].Pic);
                        terrain.Tiles[i].Pic.SendToBack();
                    }
                }
				if (terrain.Walls != null)
				{
                    for (int i = 0; i < terrain.Walls.Count; i++)
                    {
                        this.Controls.Add(terrain.Walls[i].Pic);
                        terrain.Walls[i].Pic.BringToFront();
                    }
                }
				if (terrain.Items != null)
				{
                    for (int i = 0; i < terrain.Items.Count; i++)
                    {
                        this.Controls.Add(terrain.Items[i].Pic);
                        terrain.Items[i].Pic.BringToFront();
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


		private void FrmLevel_Load(object sender, EventArgs e)
		{
			
            terrain = new Terrain();
            enemies = new List<Enemy> { };

			




            Level1();

            InitializeLevel();
            Game.player = player;
            timeBegin = DateTime.Now;


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

		private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
		{
			TimeSpan span = DateTime.Now - timeBegin;
			string time = span.ToString(@"hh\:mm\:ss");
			lblInGameTime.Text = "Time: " + time.ToString();
		}

		private void tmrPlayerMove_Tick(object sender, EventArgs e)
		{
			// move player
			player.Move();

			// check collision with walls
			if (false && HitAWall(player))
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
                    player.Inventory.AddToBackpack(terrain.Items[x]);
                    terrain.Items[x].RemoveEntity();
                }
                
            }

            x = InATile(player);
            if (x >= 0)
            {
                player.SPEED = (int)terrain.Tiles[x].Effect;
            } 

            
		}

		private bool HitAWall(Player c)
		{
			bool hitAWall = false;
			for (int w = 0; w < terrain.Walls.Count; w++)
			{
				if (c.Collider.Intersects(terrain.Walls[w].Collider))
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
            if (terrain.Items == null)
            {
                return -1;
            }
            int hitItem = -1;
			for (int i = 0; i < terrain.Items.Count; i++)
			{
				if (terrain.Items[i] != null)
				{
                    if (you.Collider.Intersects(terrain.Items[i].Collider))
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
            int InTile = -1;
            for (int i = 0; i < terrain.Tiles.Count; i++)
            {
                if (terrain.Tiles[i].ContainsCharacter(you))
                {
                    InTile = i;
                }
            }
            return InTile;
        }

		private void Fight(Enemy enemy)
		{
			player.ResetMoveSpeed();
			player.MoveBack();
			frmBattle = FrmBattle.GetInstance(enemy);
			frmBattle.Show();

            if (enemy.name == "BossKoolAid")
            {
                frmBattle.SetupForBossBattle();
            }
        }

        

        private void LoadBattle(Enemy enemy)
        {
            ClearWindow();

        }


        private void ClearWindow()
        {
            //player.RemoveEntity();
            
			for (int e = 0; 0 < enemies.Count; e++) { }
            for (int w = 0; w < terrain.Walls.Count; w++)
            {
                terrain.Walls[w].RemoveWall();
            }
			for (int t = 0; t < terrain.Tiles.Count; t++)
			{
				terrain.Tiles[t].RemoveTile();
			}

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

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }


        private void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        private void Level1()
        {
            int grid_width = this.Width / 50;
            int grid_height = this.Height / 50;

            terrain.GenerateTerrain(grid_height, grid_width, 1);

            terrain.AddItem(new Item("Sting", MakePictureBox(Resources.common_dagger, new Point(300, 200), new Size(50, 50)), 5, Item.ItemType.Weapon));

            this.player = new Player("Peanut", MakePictureBox(Resources.player, new Point(100, this.Height - 200), new Size(50, 100)), new Rogue());


            AddEnemy(new Enemy("Poison Packet", MakePictureBox(Resources.enemy_poisonpacket, new Point(200, 500), new Size(100, 100)), new Swordsman()));
            AddEnemy(new Enemy("Cheeto", MakePictureBox(Resources.enemy_cheetos, new Point(600, 200), new Size(75, 125)), new Rogue()));
            AddEnemy(new Enemy("KoolAidMan", MakePictureBox(Resources.enemy_koolaid, new Point(this.Width - 200, 100), new Size(150, 150)), new Tank()));

        }
    }
}
