﻿using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using KeyEventArgs = System.Windows.Forms.KeyEventArgs;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private bool isPaused;
    private Stopwatch timer;
    private Tuple<Key, Vector2>[] KeyBindings;
    private FrmBattle frmBattle;
    private FrmPause frmPause; 

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      // Bindings: an array of tuples. Each tuple includes a key
      // and which direction that key should cause the player to move.
      // Tuples are normalized before being applied, so we don't
      // have to worry about adding them.
      KeyBindings = new Tuple<Key, Vector2>[] {
        Tuple.Create(Key.Left,  new Vector2(-1, 0)),
        Tuple.Create(Key.Right, new Vector2(+1, 0)),
        Tuple.Create(Key.Up,    new Vector2(0, -1)),
        Tuple.Create(Key.Down,  new Vector2(0, +1)),
        Tuple.Create(Key.A,     new Vector2(-1, 0)),
        Tuple.Create(Key.D,     new Vector2(+1, 0)),
        Tuple.Create(Key.W,     new Vector2(0, -1)),
        Tuple.Create(Key.S,     new Vector2(0, +1)),
      };

      Game.player = player;
      isPaused = false;

      // Initiate Stopwatch instance and start the timer 
      timer = new Stopwatch();
      timer.Start();
        }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      CheckKeys();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) { 

        // If the pause window is shown then pause the timer 
        if (isPaused)
           timer.Stop();
        else
            timer.Start();

        // Counts how many seconds have passed since the timer first started
        TimeSpan span = timer.Elapsed;
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
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
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
      CheckKeys();
    }

    private void CheckKeys() {
      // We will add each binding's Vector2 to MovementDirection
      // to obtain the final direction.
      Vector2 MovementDirection = new Vector2(0, 0);

      // Check if we're pressing each bound button
      foreach (Tuple<Key, Vector2> Binding in this.KeyBindings) {
        if (Keyboard.IsKeyDown(Binding.Item1)) {
          MovementDirection = Vector2.Add(MovementDirection, Binding.Item2);
        }
      }

      // Normalize MovementDirection so that the maximum absolute value
      // of either direction is 1
      MovementDirection.NormalizeSquare();

        case Keys.Escape:
           
          // Game is paused when the escape key is hit 
          isPaused = true;

          // Get instance of FrmPause window and show it 
          frmPause = FrmPause.GetInstance();

          // ShowDialog() ensures no other windows can be accessed while 
          // frmPause window is shown
          frmPause.ShowDialog();

          // Once frmPause window is closed, the game is no longer paused
          isPaused = false;

          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
      if (MovementDirection.IsZero())
        player.ResetMoveSpeed();
      else
        player.GoVector(MovementDirection);
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {
        
    }
  }
}
