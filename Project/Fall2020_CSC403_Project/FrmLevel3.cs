using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel3 : Level {
    private Player player;
    private Enemy blue;
    private Enemy white;
    private Enemy bossRed;
    private Character[] walls;
    private Character[] obstacles;
    private Character[] tables;
    private FrmBattle frmBattle;
    private DateTime timeStart;
    private BossDefeatedWrapper bossIsDefeated = new BossDefeatedWrapper(false);

    public FrmLevel3() : base() {
      this.player = GameState.player;
      this.player.MoveTo(20, 357); //10, 257
      this.player.ResetMoveSpeed();
      InitializeComponent();
    }

    private void LoadLevel(object send, EventArgs e) {
      const int WALL_COUNT = 7;
      const int OBSTACLE_COUNT = 5;
      const int TABLE_COUNT = 5;
      const int PADDING = 0;
      blue = new Enemy(
      base.CreatePosition(picBlue),
      base.CreateCollider(picBlue, PADDING)
      );
      white = new Enemy(
        base.CreatePosition(picWhite),
        base.CreateCollider(picWhite, PADDING),
        50
      );
      bossRed = new Enemy(
        base.CreatePosition(picBossRed),
        base.CreateCollider(picBossRed, PADDING),
        100
      );
      timeStart = GameState.timeStart;
      player = GameState.player;

      blue.Img = picBlue.BackgroundImage;
      white.Img = picWhite.BackgroundImage;
      bossRed.Img = picBossRed.BackgroundImage;

      blue.Color = Color.LightBlue;
      white.Color = Color.LightGray;
      bossRed.Color = Color.Red;

      walls = new Character[WALL_COUNT];
      for (int w = 1; w <= WALL_COUNT; w++) {
        PictureBox pic = Controls.Find("wall" + w.ToString(), true)[0] as PictureBox;
        walls[w - 1] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      obstacles = new Character[OBSTACLE_COUNT];
      for (int o = 1; o <= OBSTACLE_COUNT; o++) {
        PictureBox pic = Controls.Find("obstacle" + o.ToString(), true)[0] as PictureBox;
        obstacles[o - 1] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      tables = new Character[TABLE_COUNT];
      for (int o = 1; o <= TABLE_COUNT; o++) {
        PictureBox pic = Controls.Find("table" + o.ToString(), true)[0] as PictureBox;
        tables[o - 1] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      this.player.ChangeCollider(base.CreateCollider(picPlayer, 0));
      Game.player = GameState.player;
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeStart;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
        //Debug.WriteLine("hit a wall!");
      }

      if (HitAnObstacle(player)) {
        player.MoveBack();
        //Debug.WriteLine("hit a obstacle!");
      }

      if (HitATable(player)) {
        player.MoveBack();
        //Debug.WriteLine("hit a obstacle!");
      }

      // check collision with enemies
      if (HitAChar(player, blue)) {
        Fight(blue);
      }
      else if (HitAChar(player, white)) {
        Fight(white);
      }

      if (HitAChar(player, bossRed) && bossIsDefeated.bossIsDefeated) {
        // this closes the current form and returns to main
        GameState.isLevelThreeCompleted = true;
        this.Close();
      }
      else if (HitAChar(player, bossRed)) {
        Fight(bossRed);
      }

      // check state of each enemy
      if (!blue.IsAlive) {
        RemoveEnemy(blue, picBlue);
      }
      if (!white.IsAlive) {
        RemoveEnemy(white, picWhite);
      }
      if (!bossRed.IsAlive) {
        RemoveEnemy(bossRed, picBossRed);
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

    private bool HitATable(Character c) {
      bool hitATable = false;
      for (int o = 0; o < tables.Length; o++) {
        if (c.Collider.Intersects(tables[o].Collider)) {
          hitATable = true;
          break;
        }
      }
      return hitATable;

    }

    private bool HitAnObstacle(Character c) {
      bool hitAnObstacle = false;
      for (int o = 0; o < obstacles.Length; o++) {
        if (c.Collider.Intersects(obstacles[o].Collider)) {
          hitAnObstacle = true;
          break;
        }
      }
      return hitAnObstacle;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, 3);
      frmBattle.Show();

      if (enemy == bossRed) {
        frmBattle.bossIsDefeatedReference = this.bossIsDefeated;
        frmBattle.SetupForBossBattle(3);
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

    private void RemoveEnemy(Enemy enemy, PictureBox picEnemy) {
      enemy.RemoveCollider();
      picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gravestone;
    }
  }
}
