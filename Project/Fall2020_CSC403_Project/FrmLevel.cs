﻿using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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
		private FrmInv frmInv;

        public FrmLevel() {
            InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
        }

		private void FrmLevel_Load(object sender, EventArgs e)
		{
			const int PADDING = 7;
			const int NUM_WALLS = 13;
			const int NUM_ITEMS = 3;

			player = new Player("Peanut", picPlayer, CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), new Rogue());

			bossKoolaid = new Enemy("KoolAidman", picBossKoolAid, CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), new Swordsman());
			enemyPoisonPacket = new Enemy("Poison", picEnemyPoisonPacket, CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), new Swordsman());
			enemyCheeto = new Enemy("CheetoKnives", picEnemyCheeto, CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), new Swordsman());

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


			Item rare_dagger = new Item("Sting", picRareDagger, 10, Item.ItemType.Weapon, CreatePosition(picRareDagger), CreateCollider(picRareDagger, PADDING));
			Item common_armor = new Item("Armor of Awesome", picCommonArmor, 10, Item.ItemType.Armor, CreatePosition(picCommonArmor), CreateCollider(picCommonArmor, PADDING));
			Item lesser_heal = new Item("Lesser Health Potion", picLesserHealthPotion, 10, Item.ItemType.Utility, CreatePosition(picLesserHealthPotion), CreateCollider(picLesserHealthPotion, PADDING));

            items = new Item[NUM_ITEMS];
            items[0] = rare_dagger;
			items[1] = common_armor;
			items[2] = lesser_heal;

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
			frmBattle = FrmBattle.GetInstance(this, enemy);
			frmBattle.Show();

            if (enemy == bossKoolaid)
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

        private void Menu_Click(object sender, EventArgs e)
        {
            FrmInv frmInv = new FrmInv();
			frmInv= FrmInv.GetInstance(player);
			frmInv.WindowState = FormWindowState.Maximized;
            frmInv.Show();
        }


        private void RestartButton_Click(object sender, EventArgs e)
        {
			// Most of this function will contain functions for levels that Carter will be making.
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

            bossKoolaid.RestoreHealth();
            enemyCheeto.RestoreHealth();
            enemyPoisonPacket.RestoreHealth();
            player.RestoreHealth();

			
            player = new Player("Peanut", picPlayer, CreatePosition(picPlayer), CreateCollider(picPlayer, 7), new Rogue());
            player.SetEntityPosition(new Position(178, 500));
			Game.player = player;

			for (int i = 0; i < items.Length; i++)
			{
				items[i].RestoreEntity();
			}

			timeBegin = DateTime.Now;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
