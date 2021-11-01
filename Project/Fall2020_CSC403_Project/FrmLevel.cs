using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private int frames = 0;
    Bitmap L1 = new Bitmap(Properties.Resources.AM_L1), LI = new Bitmap(Properties.Resources.AM_LI), L2 = new Bitmap(Properties.Resources.AM_L2), R1 = new Bitmap(Properties.Resources.AM_R1), RI = new Bitmap(Properties.Resources.AM_RI), R2 = new Bitmap(Properties.Resources.AM_R2), U1 = new Bitmap(Properties.Resources.AM_U1), UI = new Bitmap(Properties.Resources.AM_UI), U2 = new Bitmap(Properties.Resources.AM_U2), D1 = new Bitmap(Properties.Resources.AM_D1), DI = new Bitmap(Properties.Resources.AM_DI), D2 = new Bitmap(Properties.Resources.AM_D2);
    //private int directionfacing = 0;

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



    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
      frames++;
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
        AnimTimer.Start();
        switch (e.KeyCode) {
        case Keys.Left:
                    player.GoLeft();
                if (frames < 4)
                {
                    picPlayer.BackgroundImage = L1;
                }
                if (frames >= 4 && frames < 8)
                {
                    picPlayer.BackgroundImage = LI;

                }
                if (frames >= 8 && frames < 12)
                {
                    picPlayer.BackgroundImage = L2;

                }
                if (frames >= 12 && frames < 16)
                {
                    picPlayer.BackgroundImage = LI;

                }
                else if (frames >= 16)
                {
                        //AnimTimer.Stop();
                        //AnimTimer.Start();
                        frames = 0;
                }
                break;

        case Keys.Right:
          player.GoRight();
                    //AnimTimer.Start();
                    if (frames < 4)
                    {
                        //AnimTimer.Start();
                        picPlayer.BackgroundImage = R1; 
                    }
                    if (frames >= 4 && frames < 8)
                    {
                        picPlayer.BackgroundImage = RI;

                    }
                    if (frames >= 8 && frames < 12)
                    {
                        picPlayer.BackgroundImage = R2;

                    }
                    if (frames >= 12 && frames < 16)
                    {
                        picPlayer.BackgroundImage = RI;

                    }
                    else if (frames >= 16)
                    {
                        //AnimTimer.Stop();
                        //AnimTimer.Start();
                        frames = 0;
                    }
                    //picPlayer.BackgroundImage = Properties.Resources.AM_R1;
                    break;

        case Keys.Up:
          player.GoUp();
                    //AnimTimer.Start();
                    if (frames < 4)
                    {
                        //AnimTimer.Start();
                        picPlayer.BackgroundImage = U1;
                    }
                    if (frames >= 4 && frames < 8)
                    {
                        picPlayer.BackgroundImage = UI;

                    }
                    if (frames >= 8 && frames < 12)
                    {
                        picPlayer.BackgroundImage = U2;

                    }
                    if (frames >= 12 && frames < 16)
                    {
                        picPlayer.BackgroundImage = UI;

                    }
                    else if (frames >= 16)
                    {
                        //AnimTimer.Stop();
                        //AnimTimer.Start();
                        frames = 0;
                    }
                    //picPlayer.BackgroundImage = Properties.Resources.AM_U1;
                    break;

        case Keys.Down:
          player.GoDown();
                    //AnimTimer.Start();
                    if (frames < 4)
                    {
                        //AnimTimer.Start();
                        picPlayer.BackgroundImage = D1;
                    }
                    if (frames >= 4 && frames < 8)
                    {
                        picPlayer.BackgroundImage = DI;

                    }
                    if (frames >= 8 && frames < 12)
                    {
                        picPlayer.BackgroundImage = D2;

                    }
                    if (frames >= 12 && frames < 16)
                    {
                        picPlayer.BackgroundImage = DI;

                    }
                    else if (frames >= 16)
                    {
                        //AnimTimer.Stop();
                        //AnimTimer.Start();
                        frames = 0;
                    }
                    //picPlayer.BackgroundImage = Properties.Resources.AM_D1;
                    break;

        default:
          player.ResetMoveSpeed();
          frames = 0;
          break;
      }
    }private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      //player.ResetMoveSpeed();
      switch (e.KeyCode) {
        case Keys.Left:
          //player.GoLeft();
          picPlayer.BackgroundImage = Properties.Resources.AM_LI;
          player.ResetMoveSpeed();
          AnimTimer.Stop();
          frames = 0;
          break;

        case Keys.Right:
          //player.GoRight();
          picPlayer.BackgroundImage = Properties.Resources.AM_RI;
          player.ResetMoveSpeed();
          AnimTimer.Stop();
          frames = 0;

                    break;

        case Keys.Up:
          //player.GoUp();
          picPlayer.BackgroundImage = Properties.Resources.AM_UI;
          player.ResetMoveSpeed();
          AnimTimer.Stop();
          frames = 0;

                    break;

        case Keys.Down:
          //player.GoDown();
          picPlayer.BackgroundImage = Properties.Resources.AM_DI;
          player.ResetMoveSpeed();
          AnimTimer.Stop();
                    frames = 0;

                    break;

        default:
          player.ResetMoveSpeed();
          AnimTimer.Stop();
          //frames = 0;

                    break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            frames++;
            Debug.WriteLine(frames);
        }
    }
}
