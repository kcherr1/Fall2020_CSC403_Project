using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel : Form
    {
        private Player player;


        private EnemyType enemyPoisonPacket;
        private EnemyType bossKoolaid;
        private EnemyType enemyCheeto;
        private EnemyType bossPrimordialKoolaid;
        private EnemyType enemyRaisin;
        private EnemyType enemyGRIMACE;
        private Enemy nextAreaDoor;
        private Enemy obstacle1;
        private Enemy obstacle2;
        private Character[] walls;

        public Boolean worldSelect = false;
        public Boolean bossDeath = false;
        public Boolean secondWorld = false;
        public Boolean invincible = false;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public Boolean win = false;
        public Boolean lose = false;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 25;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new EnemyType(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new EnemyType(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new EnemyType(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
     enemyGRIMACE= new EnemyType(CreatePosition(picEnemyGRIMACE), CreateCollider(picEnemyGRIMACE, PADDING));
     enemyRaisin = new EnemyType(CreatePosition(picEnemyRaisin), CreateCollider(picEnemyRaisin, PADDING));
     bossPrimordialKoolaid = new EnemyType(CreatePosition(picBossPrimordialKoolaid), CreateCollider(picBossPrimordialKoolaid, PADDING));
     nextAreaDoor = new EnemyType(CreatePosition(picAreaDoor), CreateCollider(picAreaDoor, PADDING));

     enemyGRIMACE.Img = picEnemyGRIMACE.BackgroundImage;
      enemyRaisin.Img = picEnemyRaisin.BackgroundImage;
      bossPrimordialKoolaid.Img = picBossPrimordialKoolaid.BackgroundImage;
      
      obstacle1 = new EnemyType(CreatePosition(picObstacle1), CreateCollider(picObstacle1, PADDING));
      obstacle2 = new EnemyType(CreatePosition(picObstacle2), CreateCollider(picObstacle2, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      nextAreaDoor.Img = picAreaDoor.BackgroundImage;
      obstacle1.Img = picObstacle1.BackgroundImage;
      obstacle2.Img = picObstacle2.BackgroundImage;

     enemyGRIMACE.Color = Color.Purple;
     enemyRaisin.Color = Color.Blue;
     bossPrimordialKoolaid.Color = Color.Black;
      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      nextAreaDoor.Color = Color.Green;
      obstacle1.Color = Color.Red;
      obstacle2.Color = Color.Red;

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
                if (w >= 13)
                {
                    pic.Location = new System.Drawing.Point(pic.Location.X + 1500 , pic.Location.Y + 1500);
                    walls[w].Displace();
                }
      }


      Game.player = player;
      timeBegin = DateTime.Now;
      levelTheme.PlayLooping();
      UpdateMapHealth();
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

        private void UpdateMapHealth()
        {
            float playerHealth = player.Health / (float)player.MaxHealth;
            const int MAP_HEALTH_WIDTH = 226;
            lblPlayerHealthMap.Width = (int)(MAP_HEALTH_WIDTH * playerHealth);
            lblPlayerHealthMap.Text = player.Health.ToString();
        }


  

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // ensure dead enemies leave the screen and stay off it
      if (enemyPoisonPacket.Health <= 0)
      {
          enemyPoisonPacket.Displace();
          picEnemyPoisonPacket.Location = new Point(1500, 1500);
      }

      if (enemyCheeto.Health <= 0)
      {
        enemyCheeto.Displace();
        picEnemyCheeto.Location = new Point(1500, 1500);
      }
   
      if (bossKoolaid.Health <= 0)
      {
        bossKoolaid.Displace();
        picBossKoolAid.Location = new Point(1500, 1500);
      }
      
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        levelTheme.Stop();
        Fight(enemyPoisonPacket);
                
      }
      else if (HitAChar(player, enemyCheeto)) {
        levelTheme.Stop();
        Fight(enemyCheeto);
        
      } else if (HitAChar(player, enemyGRIMACE))
            {
                levelTheme.Stop();
                Fight(enemyGRIMACE);
            }
      else if (HitAChar(player, enemyRaisin))
            {
                levelTheme.Stop();
                Fight(enemyRaisin);
            }
      else if (HitAChar(player, bossPrimordialKoolaid))
            {
                levelTheme.Stop();
                Fight(bossPrimordialKoolaid);
            }
      if (HitAChar(player, bossKoolaid)) {
        levelTheme.Stop();
        Fight(bossKoolaid);
                
            }

            // if necessary move obstacles
            if (DateTime.Now.Second % 2 == 0) {
                // check the player is in the second world
                if (secondWorld == true) {
                    // place the obstacles in their respectful areas
                    picObstacle1.Location = new Point(600, 475);
                    obstacle1.Collider.MovePosition(600, 475);
                    picObstacle2.Location = new Point(850,475);
                    obstacle2.Collider.MovePosition(850, 475);

                    
                }
            } else {
                // remove the obstacles
                picObstacle1.Location = new Point(1500, 1500);
                obstacle1.Collider.MovePosition(1500, 1500);
                picObstacle2.Location = new Point(1500, 1500);
                obstacle2.Collider.MovePosition(1500, 1500);

                // remove player immunity to obstacles
                invincible = false;
            }

            // check collision with obstacles
            // if collision occurs make the player temporarily invincible to obstacles after damage calculation

            if (HitAChar(player, obstacle1)) {
                player.MoveBack();
                if (invincible == false) { 
                    player.AlterHealth(-2);
                    invincible = true;
                }
            }

            if (HitAChar(player, obstacle2))
            {
                player.MoveBack();
                if (invincible == false)
                {
                    player.AlterHealth(-2);
                    invincible = true;
                }
            }

            // check collision with the door character and change the world as necessary
            if (HitAChar(player, nextAreaDoor)) {
                
                if (bossKoolaid.Health <= 0 && bossDeath == false)
                {
                    // the first boss is defeated, load world 2 upon door interaction
                    bossDeath = true;
                    if (worldSelect == false)
                    {
                        // move the player to the new area's starting position
                        picPlayer.Location = new Point(200, 450);
                        player.Collider.MovePosition(200, 450);


                        for (int w = 0; w < 13; w++)
                        {
                            walls[w].Displace();
                            PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                            pic.Location = new Point(pic.Location.X + 1500, pic.Location.Y + 1500);
                        }
                        for (int i = 13; i < 20; i++)
                        {
                            walls[i].Replace();
                            PictureBox pic = Controls.Find("picWall" + i.ToString(), true)[0] as PictureBox;
                            pic.Location = new Point(pic.Location.X - 1500,pic.Location.Y - 1500);
                        }

                        picAreaDoor.Location = new Point(1000, 475);
                        nextAreaDoor.Collider.MovePosition(1000, 475);

                        // remove enemies from world one
                        enemyPoisonPacket.Displace();
                        picEnemyPoisonPacket.Location = new Point(1500, 1500);
                        enemyCheeto.Displace();
                        picEnemyCheeto.Location = new Point(1500, 1500);

                        // note the world for obstacles
                        secondWorld = true;


                    }
                    

                }
                else if (bossDeath == true) {
                    // switch between the secret and second worlds upon interaction with the door
                    if (worldSelect == false)
                    {
                        // switch from world 2 to secret world
                        for (int j = 13; j < 20; j++)
                        {
                            walls[j].Displace();
                            PictureBox pic = Controls.Find("picWall" + j.ToString(), true)[0] as PictureBox;
                            pic.Location = new Point(pic.Location.X + 1500, pic.Location.Y + 1500);


                        }
                        for (int k = 20; k < 25; k++)
                        {
                            walls[k].Replace();
                            PictureBox pic = Controls.Find("picWall" + k.ToString(), true)[0] as PictureBox;
                            pic.Location = new Point(pic.Location.X - 1500, pic.Location.Y - 1500);
                        }

                        // ensure the obstacles are removed
                        picObstacle1.Location = new Point(1500, 1500);
                        obstacle1.Collider.MovePosition(1500, 1500);
                        picObstacle2.Location = new Point(1500, 1500);
                        obstacle2.Collider.MovePosition(1500, 1500);

                        // move the area door
                        picAreaDoor.Location = new Point(200, 475);
                        nextAreaDoor.Collider.MovePosition(200, 475);

                        worldSelect = true;

                        // note the world for obstacles
                        secondWorld = false;
                    }
                    else {
                        worldSelect = false;
                        // switch form secret world to world 2
                        for (int t = 20; t < 25; t++)
                        {
                            walls[t].Displace();
                            PictureBox pic = Controls.Find("picWall" + t.ToString(), true)[0] as PictureBox;
                            pic.Location = new Point(pic.Location.X + 1500, pic.Location.Y + 1500);
                        }
                        for (int r = 13; r < 20; r++)
                        {
                            walls[r].Replace();
                            PictureBox pic = Controls.Find("picWall" + r.ToString(), true)[0] as PictureBox;
                            pic.Location = new Point(pic.Location.X - 1500, pic.Location.Y - 1500);
                        }

                        picAreaDoor.Location = new Point(1000, 475);
                        nextAreaDoor.Collider.MovePosition(1000,475);

                        worldSelect = false;

                        // note the world for obstacles
                        secondWorld = true;
                    }
                }
            }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
      UpdateMapHealth();
    }


  




        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }
        private void Fight(EnemyType enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            this.Hide();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.FormClosed += (s, args) => {
                
                if(player.Health <= 0)
                {
                    this.lose = true;
                    this.levelTheme.Stop();
                    this.Close();
                }
                else if(player.Health > 0)
                {
                    this.Show();
                    levelTheme.PlayLooping();
                } };
            frmBattle.Show();

            if (enemy == bossKoolaid || enemy == bossPrimordialKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
        }


        private bool HitAWall(Character c)
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

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
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
