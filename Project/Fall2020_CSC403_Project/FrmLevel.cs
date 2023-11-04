﻿using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using Fall2020_CSC403_Project.item_system;
using Fall2020_CSC403_Project.item_system.interfaces;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossChatgpt;
    private Enemy enemyCheeto;
    public Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    public Panel uiPanel;
  


        public FrmLevel() 
        {
      InitializeComponent();
        }


        private void FrmLevel_Load(object sender, EventArgs e) 
      {
          
          const int PADDING = 7;
          const int NUM_WALLS = 13;
            

          player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
          bossChatgpt = new Enemy(CreatePosition(picBossChatgpt), CreateCollider(picBossChatgpt, PADDING));
          enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
          enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

          bossChatgpt.Img = picBossChatgpt.BackgroundImage;
          enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
          enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      

          bossChatgpt.Color = Color.Green;
          enemyPoisonPacket.Color = Color.Green;
          enemyCheeto.Color = Color.FromArgb(255, 245, 161);

          bossChatgpt.Name = "boss";
          enemyPoisonPacket.Name = "poisonPacket";
          enemyCheeto.Name = "cheeto";


            // Still works here, and Enemy and Player are both accessible. I mean, it would be accessible elsewhere
            IItem rpot = InstantiateItem("RandomPotion", this, 767, 354);
            IItem rpot2 = InstantiateItem("RandomPotion", this, 667, 354);
            







            walls = new Character[NUM_WALLS];
          for (int w = 0; w < NUM_WALLS; w++) {
            PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
            walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
          }

          rpot2.ExecuteEffect(this);

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

    private void tmrPlayerMove_Tick(object sender, EventArgs e) 
    {
      // move player
      player.Move();

            // check collision with walls
            try 
            {
                if (HitAWall(player))
                {
                    player.MoveBack();
                }
            }
            catch 
            {

            }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossChatgpt))
      {
        Fight(bossChatgpt);
      }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

    }

    private bool HitAWall(Character c) {
      bool hitAWall = false;
            try 
            {
                for (int w = 0; w < walls.Length; w++)
                {
                    if (c.Collider.Intersects(walls[w].Collider))
                    {
                        hitAWall = true;
                        break;
                    }
                }
            }
            catch 
            {

            }
      
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    public void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      if (enemy.Name == "boss")
      {
          frmBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.Psychedelic;
      }
      else
      {
        frmBattle.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemyFightBG;
      }
      frmBattle.Show();

      if (enemy == bossChatgpt)
      {
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
