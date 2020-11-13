using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Character[] walls;
    private Enemy Boss;
    private List<Enemy> Enemies;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private bool PlayerWalking = false;

    public FrmLevel() {
      InitializeComponent();
      Enemies = new List<Enemy>();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

      Boss = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), picBossKoolAid, Color.Red, OnEnemyDeath);
      Enemies.Add(Boss);
      Enemies.Add(new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), picEnemyPoisonPacket, Color.Green, OnEnemyDeath));
      Enemies.Add(new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), picEnemyCheeto, Color.FromArgb(255, 245, 161), OnEnemyDeath));

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private void OnEnemyDeath(Enemy enemy)
    {
      // Render enemy off of the screen
      enemy.Icon.Visible = false;

      // Generate an instance of gold to put in place of the enemy
      PictureBox goldInstance = new PictureBox();
      goldInstance.BackgroundImage = picGold.BackgroundImage;
      goldInstance.BackgroundImageLayout = picGold.BackgroundImageLayout;
      goldInstance.Size = picGold.Size;

      // Centers the image on the previous location of the enemy
      int x = enemy.Icon.Location.X + enemy.Icon.Width / 2 - picGold.Width / 2;
      int y = enemy.Icon.Location.Y + enemy.Icon.Height / 2 - picGold.Height / 2;
      goldInstance.Location = new Point(x, y);

      // Render the gold to the screen
      goldInstance.Visible = true;
      Controls.Add(goldInstance);
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
      //reset picture box with static image if already walking
      if (PlayerWalking)
      {
        PlayerWalking = false;
        picPlayer.LoadAsync(@".\data\player.png");
      }
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
      foreach (Enemy enemy in Enemies)
      {
        if (enemy.Alive && HitAChar(player, enemy))
        {
          Fight(enemy);
          break;
        }
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

      if (enemy == Boss) {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      //update picture box with walking gif if not already walking
      if (!PlayerWalking)
            {
                picPlayer.LoadAsync(@".\data\peanutwalking.gif");
                picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
                picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.playermoving;
                PlayerWalking = true;
            }
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

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
  }
}
