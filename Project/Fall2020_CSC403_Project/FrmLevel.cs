﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Enemy[] movingEnemies;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private FrmGameOver gameover;

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

      enemyCheeto.PicNumber = 1;
      enemyPoisonPacket.PicNumber = 2;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

            movingEnemies = new Enemy[] { enemyCheeto, enemyPoisonPacket };

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
      if (HitAChar(player, enemyPoisonPacket)) {
        if (enemyPoisonPacket.Health > 0 && player.Health > 0) {
         Fight(enemyPoisonPacket);
        }
      }
      else if (HitAChar(player, enemyCheeto)) {
        if (enemyCheeto.Health > 0 && player.Health > 0) {
         Fight(enemyCheeto);
        }
      }
      if (HitAChar(player, bossKoolaid)) {
        if (bossKoolaid.Health > 0 && player.Health > 0) {
         Fight(bossKoolaid);
        }
      }

      if (player.Health <= 0)
            {
                FrmGameOver.GetInstance(this);  
            }

      if (enemyPoisonPacket.Health <= 0) 
            {
                picEnemyPoisonPacket.Visible = false;
            }

      if (enemyCheeto.Health <= 0)
            {
                picEnemyCheeto.Visible = false;
            }

      if (bossKoolaid.Health <= 0)
            {
                FrmVictory.GetInstance(this);
                picBossKoolAid.Visible = false;
            }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

      // Change picture of Mr.Peanut to Baby Peanut if health is low
      if (player.Health <= 0.3 * player.MaxHealth) {
          picPlayer.BackgroundImage = Resources.playersmall;
          picPlayer.Refresh();
      }
      else {
          picPlayer.BackgroundImage = Resources.player;
          picPlayer.Refresh();
      }
            foreach (Enemy enemy in movingEnemies)
            {
                MoveEnemy(enemy);
            }


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
        //going into the backpack
        case Keys.B:
          var backpack = new Backpack();
          backpack.Setup();
          backpack.UpdateBackpack();
          backpack.Show();
           
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
            
        }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }
        private void MoveEnemy(Enemy enemy)
        {
            Random r = new Random();
            int move = r.Next(1, 4);
            switch (move)
            {
                case 1:
                    if (enemy.LastMove != 2)
                    {
                        enemy.GoLeft();
                    }
                    else
                    {
                        enemy.GoRight();
                    }
                    break;
                case 2:
                    if (enemy.LastMove != 1)
                    {
                        enemy.GoRight();
                    }
                    else
                    {
                        enemy.GoLeft();
                    }
                    break;
                case 3:
                    if (enemy.LastMove != 4)
                    {
                        enemy.GoUp();
                    }
                    else
                    {
                        enemy.GoDown();
                    }
                    break;
                case 4:
                    if (enemy.LastMove != 3)
                    {
                        enemy.GoDown();
                    }
                    else
                    {
                        enemy.GoUp();
                    }
                    break;
                default:
                    enemy.GoLeft();
                    break;
            }
            enemy.Move();
            if (HitAWall(enemy))
            {
                enemy.MoveBack();
            }
            switch(enemy.PicNumber)
            {
                case 1:
                    picEnemyCheeto.Location = new Point((int)enemy.Position.x, (int)enemy.Position.y);
                    break;
                case 2:
                    picEnemyPoisonPacket.Location = new Point((int)enemy.Position.x, (int)enemy.Position.y);
                    break;
                default:
                    break;
            }
                
        }
    }

    
}
