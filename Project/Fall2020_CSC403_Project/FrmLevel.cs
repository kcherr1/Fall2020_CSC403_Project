using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
	public partial class FrmLevel : Form
	{
		private Player player;

		private Enemy enemyPoisonPacket;
		private Enemy bossKoolaid;
		private Enemy enemyCheeto;
		private Entity[] walls;
		private Item[] items;


		private DateTime timeBegin;
		private FrmBattle frmBattle;

        public bool gameOver = false;

        public FrmLevel() {
            InitializeComponent();
        }

		private void FrmLevel_Load(object sender, EventArgs e)
		{
			const int PADDING = 7;
			const int NUM_WALLS = 13;
			const int NUM_ITEMS = 13;

			player = new Player("Peanut", picPlayer, CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

			bossKoolaid = new Enemy("KoolAidman", picBossKoolAid, CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
			enemyPoisonPacket = new Enemy("Poison", picEnemyPoisonPacket, CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
			enemyCheeto = new Enemy("CheetoKnives", picEnemyCheeto, CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

			bossKoolaid.Img = picBossKoolAid.BackgroundImage;
			enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
			enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

			bossKoolaid.Color = Color.Red;
			enemyPoisonPacket.Color = Color.Green;
			enemyCheeto.Color = Color.FromArgb(255, 245, 161);

			walls = new Entity[NUM_WALLS];
			for (int w = 0; w < NUM_WALLS; w++)
			{
				PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
				walls[w] = new Entity("wall", pic, CreatePosition(pic), CreateCollider(pic, PADDING));
			}


			Item start_sword = new Item("Sting", picStartingSword, 10, Item.ItemType.Weapon, CreatePosition(picStartingSword), CreateCollider(picStartingSword, PADDING));
			

            items = new Item[NUM_ITEMS];
            items[0] = start_sword;

			Game.player = player;
			timeBegin = DateTime.Now;
		}

		private Position CreatePosition(PictureBox pic)
		{
			return new Position(pic.Location.X, pic.Location.Y);
		}

		private Collider CreateCollider(PictureBox pic, int padding)
		{
			Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
			return new Collider(rect);
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
			if (HitAWall(player))
			{
				player.MoveBack();
			}

			// check collision with enemies
			if (HitAChar(player, enemyPoisonPacket))
			{
				Fight(enemyPoisonPacket);
			}
			else if (HitAChar(player, enemyCheeto))
			{
				Fight(enemyCheeto);
			}
			else if (HitAChar(player, bossKoolaid))
			{
				Fight(bossKoolaid);
			}

			int x = HitAnItem(player);
			if (x >= 0)
			{
				if (!player.Inventory.BackpackIsFull())
				{
                    player.Inventory.AddToBackpack(items[x]);
                    items[x].RemoveEntity();
                }
                
            }

			// update player's picture box
			picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
		}

		private bool HitAWall(Player c)
		{
			bool hitAWall = false;
			for (int w = 0; w < walls.Length; w++)
			{
				if (c.Collider.Intersects(walls[w].Collider))
				{
					hitAWall = true;
					break;
				}
			}
			return hitAWall;
		}

		private bool HitAChar(Player you, Entity other)
		{
			return you.Collider.Intersects(other.Collider);
		}

		private int HitAnItem(Player you)
		{
			int hitItem = -1;
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] != null)
				{
                    if (you.Collider.Intersects(items[i].Collider))
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

            if (enemy == bossKoolaid)
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
            bossKoolaid.RemoveEntity();
            enemyCheeto.RemoveEntity();
            enemyPoisonPacket.RemoveEntity();
            for (int w = 0; w < walls.Length; w++)
            {
                walls[w].RemoveEntity();
            }

        }

		private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Left:
					player.GoLeft();
					break;

				case Keys.Right:
					player.GoRight();
					break;

				case Keys.Up:
					player.GoUp();
					break;

				case Keys.Down:
					player.GoDown();
					break;

				default:
					player.ResetMoveSpeed();
					break;
			}
		}
	}
}
