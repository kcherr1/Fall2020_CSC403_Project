using Fall2020_CSC403_Project.code;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Enemy enemyMikeTysonsNugget;
    private Enemy enemySusNugget;
    private Character[] walls;
    public static bool IsPaused = false;
    private Armor armor;

    private Stopwatch stopwatch;
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
      enemyMikeTysonsNugget = new Enemy(CreatePosition(picEnemyMikeTysonsNugget), CreateCollider(picEnemyMikeTysonsNugget, PADDING));
      enemySusNugget = new Enemy(CreatePosition(picEnemySusNugget), CreateCollider(picEnemySusNugget, PADDING));
      armor = new Armor(CreatePosition(armorPickup), CreateCollider(armorPickup, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      enemyMikeTysonsNugget.Img = picEnemyMikeTysonsNugget.BackgroundImage;
      enemySusNugget.Img = picEnemySusNugget.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      enemyMikeTysonsNugget.Color = Color.FromArgb(255, 245, 161);
      enemySusNugget.Color = Color.FromArgb(255, 245, 161);

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      stopwatch = new Stopwatch();
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

    public void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
            if (IsPaused == false)
            {
                stopwatch.Start();
                TimeSpan span = stopwatch.Elapsed;
                string time = span.ToString(@"hh\:mm\:ss");
                lblInGameTime.Text = "Time: " + time.ToString();
            }
            else
            {
                stopwatch.Stop();
            }
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
            if (enemyMikeTysonsNugget.Health <= 0){
              picEnemyMikeTysonsNugget.Hide();
            }
            if (enemySusNugget.Health <= 0){
              picEnemySusNugget.Hide();
            }
            if (player.Health <= 0)
            {
                picPlayer.Hide();
                IsPaused = true;
                Death.Show();
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
        IsPaused = true;
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
        IsPaused = true;
      }
      else if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
        IsPaused = true;
      }
      else if (HitAChar(player, enemyMikeTysonsNugget))
      {
          Fight(enemyMikeTysonsNugget);
      }
      else if (HitAChar(player, enemySusNugget))
      {
          Fight(enemySusNugget);
      }
      if (HitAChar(player, armor))
      {
          //player.Armor += 5;
          //player.MaxArmor = 10;
          applyArmor();
          armorPickup.Hide();
     }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }
    // updates Cheeto picture box
    private void tmrEnemyCheetoMove_Tick(object sender, EventArgs e)
    {
            if (IsPaused == false)
            {
                if (enemyCheeto.Health >= 0)
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

                    while (HitAChar(enemyCheeto, player))
                    {
                        Fight(enemyCheeto);
                        enemyCheeto.MoveBack();
                        enemyCheeto.ResetMoveSpeed();
                    }

                    if (enemyCheeto.Counter >= 4)
                    {
                        enemyCheeto.Counter = 0;
                    }
                    picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
                }
            }
    }

    private void tmrEnemyPoisonPacketMove_Tick(object sender, EventArgs e)
    {
            if (IsPaused == false)
            {
                if (enemyPoisonPacket.Health >= 0)
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
                        Fight(enemyPoisonPacket);
                        enemyPoisonPacket.MoveBack();
                        enemyPoisonPacket.ResetMoveSpeed();
                    }

                    if (enemyPoisonPacket.Counter >= 4)
                    {
                        enemyPoisonPacket.Counter = 0;
                    }

                    picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
                }
            }
       
    }

void applyArmor()
{

   if (player.Armor < 10)
   {
     player.AlterShield(4);
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
      IsPaused = true;
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
        }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
        if (IsPaused == false)
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

                    case Keys.Escape:
                        PauseMenu pauseMenu = new PauseMenu();
                        pauseMenu.Show();
                        IsPaused = true;
                        player.ResetMoveSpeed();
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
      }
    }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
