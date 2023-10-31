using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    public bool playerHasKey = false;

    private Enemy enemyPoisonPacket;
    public Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls, fences, dialog, key;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
        private int keyHitCount = 0;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      const int NUM_FENCES = 1;
      const int NUM_DIALOG = 1;
      const int NUM_KEY = 1;
            

        


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
      fences = new Character[NUM_FENCES];
      for (int w = 0; w < NUM_FENCES; w++) {
        PictureBox pic = Controls.Find("picFence" + w.ToString(), true)[0] as PictureBox;
        fences[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
       dialog = new Character[NUM_DIALOG];
      for (int w = 0; w < NUM_DIALOG; w++) {
        PictureBox pic = Controls.Find("picDialog" + w.ToString(), true)[0] as PictureBox;
        dialog[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      key = new Character[NUM_KEY];
      for (int w = 0; w < NUM_KEY; w++) {
        PictureBox pic = Controls.Find("picKey" + w.ToString(), true)[0] as PictureBox;
        key[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      picDialog0.Visible = false;
            picKey0.Visible = false;

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
            bool x,y,z;
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with fences
      if (HitAFence(player)) {
        player.MoveBack();
      }

      // check collision with key
      if (HitAKey(player)) {
        player.MoveBack();
                
                
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
                x = IsEnemyDead(enemyPoisonPacket);
                if(x == true) {Fight(enemyPoisonPacket); }
        
      }
      else if (HitAChar(player, enemyCheeto)) { 
                 y = IsEnemyDead(enemyCheeto);
                if(y == true) { 
        Fight(enemyCheeto);}
      }
      if (HitAChar(player, bossKoolaid)) {
                 z = IsEnemyDead(bossKoolaid);
                if(z == true) {Fight(bossKoolaid); }
      
      }
         
      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }
        private void AllSideEnemyDied(Character c) {
            //bool allSideEnemyDied = false;
            bool keyHit = HitAKey(player);
            
            
        if (IsEnemyDead(enemyPoisonPacket) == false && IsEnemyDead(enemyCheeto) == false)
            {   
                if(keyHit == true)
                {
                   
                    picKey0.Visible = false;
                   
                }
                else if (keyHit == false && keyHitCount ==0) { 
                picKey0.Visible = true;
                    }
            
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
        private bool HitAKey(Character c) {
      bool hitAKey = false;
            if(playerHasKey == false) { 
        for (int w = 0; w < key.Length; w++) {
        if (c.Collider.Intersects(key[w].Collider)) {
                    hitAKey = true;
                    playerHasKey = true;
                    keyHitCount ++;
                    picKey0.Visible = false;
                    break;
                    }
        }
        }
        return hitAKey;
        
        
        }

        private bool HitAFence(Character c) {
      bool hitAFence = false;
      for (int w = 0; w < fences.Length; w++) {
                if(playerHasKey == false) { 
        if (c.Collider.Intersects(fences[w].Collider)) {
          hitAFence = true;
                    picDialog0.Visible = true;
       Timer timer = new Timer();
       timer.Interval = 1500;
       timer.Tick += (sender, e) => {
         picDialog0.Visible = false;
         timer.Stop();
         timer.Dispose();
       };
       timer.Start();
       
       break;
        }
        }
                else
                {
                    picDialog0.Visible = false;
                    picFence0.Visible = false;
                    
                  
                }
      }
      return hitAFence;
    }

    private bool HitAChar(Character you, Character other) {
            AllSideEnemyDied(other);
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

        case Keys.Escape:
          DialogResult exitDialogue = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (exitDialogue == DialogResult.Yes)
          {
              Application.Exit();
          }
          break;

        case Keys.Q:
          DialogResult gotoHomeDialogue = MessageBox.Show("Are you sure you want to go to home and lose all progress?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (gotoHomeDialogue == DialogResult.Yes)
          {
                FrmHome homeForm = new FrmHome();
                homeForm.Show();
                this.Close();
          }
          break;

        default:
          player.ResetMoveSpeed();
          break;
      } 
    }

        private void lblInGameTime_Click(object sender, EventArgs e) {

    }

        private void goToHome_Click(object sender, EventArgs e)
        {
            DialogResult gotoHomeDialogue = MessageBox.Show("Are you sure you want to go to home and lose all progress?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (gotoHomeDialogue == DialogResult.Yes)
            {
                FrmHome homeForm = new FrmHome();
                homeForm.Show();
                this.Close();
            }
        }
        public bool IsEnemyDead(Enemy enemy) { 

          
            if (enemy.Health <= 0)
                {
                Enemy x = enemy;
      

            if (x == enemyPoisonPacket )
            {
                 picEnemyPoisonPacket.Visible = false;
                   
            }
              
            if (x == bossKoolaid )
            {
                 picBossKoolAid.Visible = false;
              
            }
             
            if (x == enemyCheeto )
            {
                 picEnemyCheeto.Visible = false;
                    
                    
            }
            
            return false;
                }
             else
                {
                    return true;
                }
            
   }
        
  }
}
