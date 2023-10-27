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
                    }
                }
				if (terrain.Walls != null)
				{
                    for (int i = 0; i < terrain.Walls.Count; i++)
                    {
                        this.Controls.Add(terrain.Walls[i].Pic);
                    }
                }
				if (terrain.Items != null)
				{
                    for (int i = 0; i < terrain.Items.Count; i++)
                    {
                        this.Controls.Add(terrain.Items[i].Pic);
                    }
                }
            }

            if (player != null)
			{
				this.Controls.Add(player.Pic);
			}

			if (enemies != null)
			{
                for (int i = 0; i < enemies.Count; i++)
                {
                    this.Controls.Add(enemies[i].Pic);
                }
            }

		}


		private void FrmLevel_Load(object sender, EventArgs e)
		{
			
			player = new Player("Peanut", MakePictureBox(Resources.player, new Point(100, 600)), new Rogue());

			terrain = new Terrain();






            InitializeLevel();
            Game.player = player;
            timeBegin = DateTime.Now;


        }

        public PictureBox MakePictureBox(Bitmap pic, Point location)
        {
            return new PictureBox
            {
                Location = location,
                Image = pic,
                SizeMode = PictureBoxSizeMode.StretchImage
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
			int SPEED = 3;
			int x = 0;
			int y = 0;
            
            if (e.KeyCode == Keys.Left)
			{
				x -= SPEED;
			}
			if (e.KeyCode == Keys.Right)
			{
				x += SPEED;
			}
			if (e.KeyCode == Keys.Up)
			{
				y += SPEED;
			}
			if (e.KeyCode == Keys.Down)
			{
				y -= SPEED;
			}
			//new Position = (x, y);

        }
    }
}
