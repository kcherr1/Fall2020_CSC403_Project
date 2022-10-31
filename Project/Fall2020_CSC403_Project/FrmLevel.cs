using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Pausemenu psMenu =  Pausemenu.getInstance();
    private Player player;
    private string saveName;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
    private Enemy trixBunny;
    private Enemy tonyTigerWeak;
    private Enemy tonyTigerStrong;


    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private bool playerIsDead;
    private bool bossKoolAidIsDead;
    private bool enemyCheetoIsDead;
        private bool enemyPoisonPacketIsDead;
        private bool tonyTigerWeakIsDead;
        private bool trixBunnyIsDead;
        private bool tonyTigerStrongIsDead;
    SoundPlayer battleMusic = new SoundPlayer(stream: Resources.battle_music);
    SoundPlayer level_music = new SoundPlayer(stream: Resources.level_music);

        public FrmLevel() {
      InitializeComponent();
    }

    public FrmLevel(string saveName)
        {
            this.saveName = saveName;
            InitializeComponent();
        }
    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      playerIsDead = false;
      level_music.PlayLooping();

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            trixBunny.Img = picEnemyTrixBunny.BackgroundImage;
            tonyTigerStrong.Img = picEnemyTonyTigerStrong.BackgroundImage;
            tonyTigerWeak.Img = picEnemyTonyTigerWeak.BackgroundImage;

            trixBunny.Color = Color.White;
            tonyTigerStrong.Color = Color.Orange;
            tonyTigerWeak.Color = Color.Orange;
            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);
            picEnemyTonyTigerStrong.Visible = false;
            walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }
      Game.player = player;
      timeBegin = DateTime.Now;

        //checks if its a new game
        //if there is
        if(saveName == null)
        {
            //checks for a valid savegame to save to
            for (int i = 0; i < 3; i++)
            {
                string saveName = "Save" + i + ".txt";
                if (!SaveSystem.IsSaveFileValid(saveName))
                {
                    this.saveName = saveName;
                    SaveSystem.SaveGame(saveName, player, enemyPoisonPacket, enemyCheeto, bossKoolaid);
                    break;
                }
            }
            if(saveName == null)
                {
                    saveName = "Save0.txt";
                }
        }
        //if its loading a game
        else
        {
            SaveSystem.LoadGame(saveName, player, enemyPoisonPacket, enemyCheeto, bossKoolaid);
        }
      
    }

    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }
        private Collider RemoveCollider(PictureBox pic)
        {
            return null;
        }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e) {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e) {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
      if(player.Health <= 0 && !playerIsDead) {
        KillPlayer();
      }
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e) {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player)) {
        player.MoveBack();
      }

      // check collision with enemies, removes enemy collisions and images after combat
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
                if (enemyPoisonPacketIsDead == true)
                {
                }
                else
                {
                    player.enemySpeed = 2;
                    player.enemyStrength = 4;
                    player.enemyDefense = 2;
                    Fight(enemyPoisonPacket);
                    picEnemyPoisonPacket.Visible = false;
                    enemyPoisonPacketIsDead = true;
                }
                picEnemyPoisonPacket.Visible = false;
      }
      else if (HitAChar(player, enemyCheeto)) {
                if (enemyCheetoIsDead == true)
                {
                }
                else
                {
                    player.enemySpeed = 2;
                    player.enemyStrength = 4;
                    player.enemyDefense = 2;
                    Fight(enemyCheeto);
                    picEnemyCheeto.Visible = false;
                    enemyCheetoIsDead = true;
                }
            }
        
            else if (HitAChar(player, trixBunny))
            {
                if (trixBunnyIsDead == true)
                {
                }
                else
                {
                    player.enemySpeed = 4;
                    player.enemyStrength = 2;
                    player.enemyDefense = 1;
                    Fight(trixBunny);
                    picEnemyTrixBunny.Visible = false;
                    trixBunnyIsDead = true;
                }
            }
            else if (HitAChar(player, tonyTigerWeak))
            {
                if (tonyTigerWeakIsDead == true)
                {
                }
                else
                {
                    player.enemySpeed = 3;
                    player.enemyStrength = 2;
                    player.enemyDefense = 3;
                    Fight(tonyTigerWeak);
                    picEnemyTonyTigerWeak.Visible = false;
                    picEnemyTonyTigerStrong.Visible = true;
                    tonyTigerWeakIsDead = true;
                }
            }
            else if (HitAChar(player, tonyTigerStrong))
            {
                if (tonyTigerStrongIsDead == true)
                {
                }
                else
                {
                    player.enemySpeed = 5;
                    player.enemyStrength = 5;
                    player.enemyDefense = 5;
                    Fight(tonyTigerStrong);
                    picEnemyTonyTigerStrong.Visible = false;
                    tonyTigerStrongIsDead = true;
                }
            }
            if (HitAChar(player, bossKoolaid)) {
                if (bossKoolAidIsDead == true) { }
                else
                {
                    player.enemySpeed = 3;
                    player.enemyStrength = 8;
                    player.enemyDefense = 2;
                    Fight(bossKoolaid);
                    picBossKoolAid.Visible = false;
                    bossKoolAidIsDead = true;
                }
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
      string Difficulty = checkDifficulty();
            switch (Difficulty) { 
                case "Easy":
                    enemy.MaxHealth += 0;
                    break;
                case "Medium":
                    enemy.MaxHealth += 10;
                    enemy.Health = enemy.MaxHealth;
                    break;
                case "Hard":
                    enemy.MaxHealth += 20;
                    enemy.Health = enemy.MaxHealth;
                    break;
                }
      level_music.Stop();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
                //f5 to save to save slot
                case Keys.F5:
                    SaveSystem.SaveGame(saveName, player, enemyPoisonPacket, enemyCheeto, bossKoolaid);
                    break;
                //f9 to load from save slot
                case Keys.F9:
                    if (SaveSystem.IsSaveFileValid(saveName))
                    {
                        SaveSystem.LoadGame(saveName, player, enemyPoisonPacket, enemyCheeto, bossKoolaid);
                    }
                    break;
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
                    psMenu.Show();
                    break;


                default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

        public void KillPlayer()
        {
            playerIsDead = true;
            MakePlayerDisappear();
            PromptUserToRestart();
        }

        //makes the player disappear when they die
        public void MakePlayerDisappear()
        {
            picPlayer.Visible = false;
            picPlayer.Refresh();
        }

        //prompts the user to restart the game
        public void PromptUserToRestart()
        {
            bool restart = MessageBox.Show("Restart?", "", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (restart)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
        public string checkDifficulty()
        {
            return psMenu.difMenu.Dif;
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
