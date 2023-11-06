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
      bossKoolaid = new EnemyType(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new EnemyType(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new EnemyType(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
     enemyGRIMACE= new EnemyType(CreatePosition(picEnemyGRIMACE), CreateCollider(picEnemyGRIMACE, PADDING));
     enemyRaisin = new EnemyType(CreatePosition(picEnemyRaisin), CreateCollider(picEnemyRaisin, PADDING));
     bossPrimordialKoolaid = new EnemyType(CreatePosition(picBossPrimordialKoolaid), CreateCollider(picBossPrimordialKoolaid, PADDING));

      enemyGRIMACE.Img = picEnemyGRIMACE.BackgroundImage;
      enemyRaisin.Img = picEnemyRaisin.BackgroundImage;
      bossPrimordialKoolaid.Img = picBossPrimordialKoolaid.BackgroundImage;
      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

     enemyGRIMACE.Color = Color.Purple;
     enemyRaisin.Color = Color.Blue;
     bossPrimordialKoolaid.Color = Color.Black;
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
            frmBattle.FormClosed += (s, args) => this.Show();
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
