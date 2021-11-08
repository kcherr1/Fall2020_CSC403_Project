using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : ChildForm {
    public static bool win = false;
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;

    public SoundPlayer mapMusic = new SoundPlayer(Resources.map_music);

      
        public FrmLevel()
        {
            PreviewKeyDown += FrmLevel_PreviewKeyDown;
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e) {
            Parent.KeyDown += FrmLevel_KeyDown;
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      MapMusic();

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), 2, 2, 2);
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 2, 2, 2);
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), 2, 2, 2);
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 2, 2, 2);

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

    public void MapMusic()
        {
            mapMusic.PlayLooping();
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
      // update the player's health
      UpdateHealthBar();

      //check for enemy death and updates map
      if(enemyCheeto.Health <= 0){
        Dispose(enemyCheeto);
      }
      if(enemyPoisonPacket.Health <= 0){
        Dispose(enemyPoisonPacket);
      }
      if(bossKoolaid.Health <= 0){
        Dispose(bossKoolaid);
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
      frmBattle = (FrmBattle)CreateChild(FrmBattle.GetInstance(enemy));
      frmBattle.MdiParent = this.MdiParent;
      RequestHide();
      frmBattle.Show();

     
        

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }
        public void keyListener(KeyEventArgs e)
        {
     
            FrmLevel_KeyDown(this, e);
        }

    private void FrmLevel_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
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
        
        case Keys.X:
          cheatMenu.Visible = true;
          break;

        case Keys.P:
          OpenStatsMenu();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

        private void OpenStatsMenu()
        {
           StatsMenu newChild = (StatsMenu) CreateChild(new StatsMenu());
            newChild.player = this.player;
            tmrPlayerMove.Stop();
            newChild.RequestShow();

        }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

    private void Dispose(Enemy enemy){

      //not scalable, but a hilariously simple way of moving the collider sufficiently afar
      //to make it impossible to reach by the player
      enemy.Collider.MovePosition(1500,1500);

      //sets the visibility of the picture depending on the enemy
      //had to do this since the pic of the enemy is stored seperate from the rest of enemy attributes
      if(enemy == enemyCheeto)
      {
                if (picEnemyCheeto.Visible)
                {
                    player.AlterHealth(4);
                }
                picEnemyCheeto.Visible = false;
      }
      if(enemy == bossKoolaid){
                if (picBossKoolAid.Visible)
                {
                    player.AlterHealth(4);
                }
        picBossKoolAid.Visible = false;
      }
      if(enemy == enemyPoisonPacket)
            {
                if (picEnemyPoisonPacket.Visible)
                {
                    player.AlterHealth(4);
                }
                picEnemyPoisonPacket.Visible = false;
      }
    }

    private void winChecker(object sender, EventArgs e)
    {
            Console.WriteLine("tack");
        if (win)
        {
            winImage.Visible = true;
        }
    }
        
    private void UpdateHealthBar() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
    }

    private void closeCheatMenu(object sender, EventArgs e)
    {
      cheatMenu.Visible = false;
      this.ActiveControl = null;
    }

        private void cheatMenuEvasionLabel_Click(object sender, EventArgs e)
        {

        }
    }
  
}
