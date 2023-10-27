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
            this.Level = 1;
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

            this.player = new Player("Peanut", MakePictureBox(Resources.player, new Point(100, this.Height - 200), new Size(50, 100)), new Rogue());
            LevelSelect();


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
                    player.Inventory.AddToBackpack(terrain.Items[x]);
                    terrain.Items[x].RemoveEntity();
                }
                
            }

            x = InATile(player);
            Debug.WriteLine(x);
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
            int x = ((int)you.Position.x + you.Pic.Width / 2) / 50;
            int y = ((int)you.Position.y + you.Pic.Height) / 50;



            return (x) + (y * this.Width / 50);
        }

		private void Fight(Enemy enemy)
		{
			player.ResetMoveSpeed();
			player.MoveBack();
			frmBattle = FrmBattle.GetInstance(this, enemy);
			frmBattle.Show();

            if (enemy.name == "BossKoolAid")
            {
                frmBattle.SetupForBossBattle();
            }
        }

		public void GameOver()
		{
			ClearWindow();

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
        }


        private void ClearWindow()
        {
			// iterate through the controls and make them invisible
			foreach (Control ctrl in this.Controls)
			{
				ctrl.Visible = false;
			}
		}


        private void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        


        private void RestartButton_Click(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = true;
            }

            BlackSquare.Visible = false;
            GameOverText.Visible = false;
            RestartButton.Visible = false;
            ExitButton.Visible = false;

            RestartButton.Enabled = false;
            ExitButton.Enabled = false;

            terrain = new Terrain();
            this.enemies.Clear();
            player = new Player(player.Name, player.Pic, player.archetype);

            this.Level = 1;
            LevelSelect();
            InitializeLevel();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void LevelSelect()
        {
            switch(this.Level)
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
            player.SetEntityPosition(new Position(100, this.Height - 200));

            int grid_width = this.Width / 50;
            int grid_height = this.Height / 50;

            terrain.GenerateTerrain(grid_height, grid_width, 1);


            terrain.AddItem(new Item("Sting", MakePictureBox(Resources.common_dagger, new Point(300, 200), new Size(50, 50)), 5, Item.ItemType.Weapon));

            AddEnemy(new Enemy("Poison Packet", MakePictureBox(Resources.enemy_poisonpacket, new Point(200, 500), new Size(100, 100)), new Swordsman()));
            AddEnemy(new Enemy("Cheeto", MakePictureBox(Resources.enemy_cheetos, new Point(600, 200), new Size(75, 125)), new Rogue()));
            AddEnemy(new Enemy("KoolAidMan", MakePictureBox(Resources.enemy_koolaid, new Point(this.Width - 200, 100), new Size(150, 150)), new Tank()));

        }
    }
}
