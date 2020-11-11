using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
		private Enemy enemyTony;
		private Enemy enemyRonald;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;


    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));

			SpawnEnemies();

			enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING)) {
				Img = picEnemyPoisonPacket.BackgroundImage,
				Color = Color.Green
				
			};

			enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING)) {
				Img = picEnemyCheeto.BackgroundImage,
				Color = Color.FromArgb(255, 245, 161)
			};

			enemyTony = new Enemy(CreatePosition(picEnemyTony), CreateCollider(picEnemyTony, PADDING)) {
				Img = picEnemyTony.BackgroundImage,
				Color = Color.Orange
			};

			enemyRonald = new Enemy(CreatePosition(picEnemyRonald), CreateCollider(picEnemyRonald, PADDING)) {
				Img = picEnemyRonald.BackgroundImage,
				Color = Color.Yellow
			};

			bossKoolaid.Img = picBossKoolAid.BackgroundImage;      
			bossKoolaid.Color = Color.Red;
      
      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

			// check collision with enemies
			if (HitAChar(player, enemyPoisonPacket) && picEnemyPoisonPacket.Visible) {
				Fight(enemyPoisonPacket);
			}
			else if (HitAChar(player, enemyTony) && picEnemyTony.Visible) {
				Fight(enemyTony);
			}
			else if (HitAChar(player, enemyCheeto) && picEnemyCheeto.Visible) {
				Fight(enemyCheeto);
			}
			else if (HitAChar(player, enemyRonald) && picEnemyRonald.Visible) {
				Fight(enemyRonald);
			}
			if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++) {
        if (c.Collider.Intersects(walls[w].Collider)) {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
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

		private int[] RandomIntegers() {
			Random ran = new Random();
			int getRanNum1 = ran.Next(4);
			int getRanNum2 = ran.Next(4);
			int getRanNum3 = ran.Next(4);
			// loop until you get two unique numbers
			while (getRanNum1 == getRanNum2)
				getRanNum2 = ran.Next(4);
			// loop until you get a third number unique from the first two
			while ((getRanNum3 == getRanNum2) || (getRanNum3 == getRanNum1))
					getRanNum3 = ran.Next(4);
			int[] randomIntArray = { getRanNum1, getRanNum2, getRanNum3 };
			return randomIntArray;
		}

		private void SpawnEnemies() {
			// Get which random integers will spawn enemies
			int[] enemyInitilizerArray = RandomIntegers();

			// Hide all pictureboxes
			picEnemyPoisonPacket.Visible = false;
			picEnemyCheeto.Visible = false;
			picEnemyTony.Visible = false;
			picEnemyRonald.Visible = false;

			// Randomize Which Enemies are "spawned" on the map
			foreach (int i in enemyInitilizerArray) {
				if (i == 0)
					picEnemyPoisonPacket.Visible = true;
				else if (i == 1)
					picEnemyCheeto.Visible = true;
				else if (i == 2)
					picEnemyTony.Visible = true;
				else if (i == 3)
					picEnemyRonald.Visible = true;
			}
		}

	}
}
