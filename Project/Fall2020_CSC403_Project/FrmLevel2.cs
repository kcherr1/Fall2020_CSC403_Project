using Fall2020_CSC403_Project.code;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel2 : Level {
    public GameState gameState { get; private set; }
    private Player player;
    private Enemy goose;
    private Enemy alligator;
    private Enemy bossSquirrels;
    private Character[] walls;
    private Character[] hedges;
    private Character[] obstacles;
    private FrmBattle frmBattle;
    private DateTime timeStart;
    
    public FrmLevel2(GameState gameState) : base() {
      this.gameState = gameState;
      InitializeComponent();
    }

    private void LoadLevel(object send, EventArgs e) {
      const int WALL_COUNT = 46;
      const int HEDGE_COUNT = 23;
      const int OBSTACLE_COUNT = 14;
      const int PADDING = 0;
      goose = new Enemy(
      base.CreatePosition(picGoose),
      base.CreateCollider(picGoose, PADDING)
      );
      alligator = new Enemy(
        base.CreatePosition(picAlligator),
        base.CreateCollider(picAlligator, PADDING)
      );
      bossSquirrels = new Enemy(
        base.CreatePosition(picSquirrel3),
        base.CreateCollider(picSquirrel3, PADDING)
      );
      timeStart = gameState.timeStart;
      player = gameState.player;

      goose.Img = picGoose.BackgroundImage;
      alligator.Img = picAlligator.BackgroundImage;
      bossSquirrels.Img = picSquirrel3.BackgroundImage;

      goose.Color = Color.White;
      alligator.Color = Color.Green;
      bossSquirrels.Color = Color.Brown;

      walls = new Character[WALL_COUNT];
      for (int w = 0; w < WALL_COUNT; w++) {
        PictureBox pic = Controls.Find("wall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      obstacles = new Character[OBSTACLE_COUNT];
      for (int w = 0; w < OBSTACLE_COUNT; w++) {
        PictureBox pic = Controls.Find("obstacle" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      hedges = new Character[HEDGE_COUNT];
      for (int w = 0; w < HEDGE_COUNT; w++) {
        PictureBox pic = Controls.Find("hedge" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = gameState.player;
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    //private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
    //  TimeSpan span = DateTime.Now - timeStart;
    //  string time = span.ToString(@"hh\:mm\:ss");
    //  lblInGameTime.Text = "Time: " + time.ToString();
    //}

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, goose)) {
        Fight(goose);
      }
      else if (HitAChar(player, alligator)) {
        Fight(alligator);
      }
      if (HitAChar(player, bossSquirrels)) {
        Fight(bossSquirrels);
      }

      // check state of each enemy
      if (!goose.IsAlive) {
        RemoveEnemy(goose, picGoose);
      }
      if (!alligator.IsAlive) {
        RemoveEnemy(alligator, picAlligator);
      }
      if (!bossSquirrels.IsAlive) {
        RemoveEnemy(bossSquirrels, picSquirrel3);
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

      if (enemy == bossSquirrels) {
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



    private void RemoveEnemy(Enemy enemy, PictureBox picEnemy) {
      enemy.RemoveCollider();
      picEnemy.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.gravestone;
    }
  }
}
