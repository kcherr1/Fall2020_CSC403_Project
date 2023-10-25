using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Projectile arrow;
    private Character[] walls;
    public string playerDirection = "right";
    private DateTime timeBegin;
    private FrmBattle frmBattle;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int ARROW_PADDING = 2;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      // character projectile attack
      arrow = new Projectile(CreatePosition(picPlayer), CreateCollider(picArrow, ARROW_PADDING));
      picArrow.Hide();

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

    private void tmrArrowMove_Tick(object sender, EventArgs e)
    {
            // check if projectile hits a wall
            if (ArrowHitAWall(arrow))
            {
                arrow.inFlight = false;
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                picArrow.Hide();
            }
            // update position if object is inFlight
            if (arrow.inFlight)
            {
                arrow.arrowMove(playerDirection);
                picArrow.Location = new Point((int)arrow.Position.x, (int)arrow.Position.y);
            }
            else
            {
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
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

      // check collision with enemies and projectiles
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
    /// <summary>
    /// decides if arrow collides with a wall, return arrow to player
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
     private bool ArrowHitAWall(Projectile p)
     {
          bool hitAWall = false;
          for (int w = 0; w < walls.Length; w++)
          {
              if (p.Collider.Intersects(walls[w].Collider))
              {
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
        case Keys.Space:
          if (!arrow.inFlight)
             {
                picArrow.Show();
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                arrow.Position = new Vector2(player.Position.x, player.Position.y);
                arrow.arrowMove(playerDirection);
                arrow.inFlight = true;
              }
          break;

        case Keys.Left:
          player.GoLeft();
          if (!arrow.inFlight)
               playerDirection = "left";
                    //player.direction = "left";
          break;

        case Keys.Right:
          player.GoRight();
             if(!arrow.inFlight)
                playerDirection = "right";
                    //player.direction = "right";
          break;

        case Keys.Up:
          player.GoUp();
            if (!arrow.inFlight)
                playerDirection = "up";
                    //player.direction = "up";
          break;

        case Keys.Down:
          player.GoDown();
            if (!arrow.inFlight)
                playerDirection = "down";
                    //player.direction = "down";
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// Closes the application when FrmLevel is closed 
    /// </summary>
    public void onFormClosed(object sender, FormClosedEventArgs e)
        {            
            System.Windows.Forms.Application.Exit();
        }
    
  }
}
