﻿using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
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

    private void tmrUpdateEnemyPic_Tick(object sender, EventArgs e){
            if (enemyPoisonPacket.Health <= 0){
                picEnemyPoisonPacket.Hide();
            }
            if (bossKoolaid.Health <= 0){
                picBossKoolAid.Hide();
            }
            if (enemyCheeto.Health <= 0){
                picEnemyCheeto.Hide();
            }
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
    
    // move cheeto
    private void tmrEnemyCheetoMove_Tick(object sender, EventArgs e)
    {
        switch (enemyCheeto.Counter)
        {
            case 0:
                enemyCheeto.GoLeft();
                break;
            case 1:
                enemyCheeto.GoUp();
                break;
            case 2:
                enemyCheeto.GoDown();
                break;
            case 3:
                enemyCheeto.GoRight();
                break;
        }

        enemyCheeto.Move();

        if (HitAWall(enemyCheeto))
        {
            enemyCheeto.MoveBack();
            enemyCheeto.Counter += 1;
        }

        while (HitAChar(enemyCheeto, player)){
            enemyCheeto.MoveBack();
            enemyCheeto.ResetMoveSpeed();
        }

        if (enemyCheeto.Counter >= 4)
        {
            enemyCheeto.Counter = 0;
        }
        //updates cheeto picture box
        picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
    }
    
    //move poison packet
    private void tmrEnemyPoisonPacketMove_Tick(object sender, EventArgs e)
    {
        switch (enemyPoisonPacket.Counter)
        {
            case 0:
                enemyPoisonPacket.GoDown();
                break;
            case 1:
                enemyPoisonPacket.GoRight();
                break;
            case 2:
                enemyPoisonPacket.GoLeft();
                break;
            case 3:
                enemyPoisonPacket.GoUp();
                break;
        }
        enemyPoisonPacket.Move();

        if (HitAWall(enemyPoisonPacket))
        {
            enemyPoisonPacket.MoveBack();
            enemyPoisonPacket.Counter += 1;
        }

        while (HitAChar(enemyPoisonPacket, player))
        {
            enemyPoisonPacket.MoveBack();
            enemyPoisonPacket.ResetMoveSpeed();
        }

        if (enemyPoisonPacket.Counter >= 4)
        {
            enemyPoisonPacket.Counter = 0;
        }

        //updates posion packet picture box
        picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
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
    }
}
