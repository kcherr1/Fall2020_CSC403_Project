using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using Fall2020_CSC403_Project.item_system;
using Fall2020_CSC403_Project.item_system.interfaces;
using Fall2020_CSC403_Project.Properties;
using System.Media;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;

    public Enemy enemyPoisonPacket;
    public Enemy bossChatgpt;
    public Enemy enemyCheeto;
    public Character[] walls;
    public static SoundPlayer levelMusic; // background music for the level

    private DateTime timeBegin;
    private FrmBattle frmBattle;    
    private Random random; // Random number generator for item system
    private IItem rpot; //rpot is always the handle regardless of the item called because its a random item, thus rpot



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

          bossChatgpt.Name = "BossChatgpt";
          enemyPoisonPacket.Name = "PoisonPacket";
          enemyCheeto.Name = "Cheeto";

            

            walls = new Character[NUM_WALLS];
          for (int w = 0; w < NUM_WALLS; w++) {
            PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
            walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
          }

          // executing the effect of removing the walls should happen after the walls are built otherwise null object error
          //rpot2.ExecuteEffect(this); 

          Game.player = player;
          timeBegin = DateTime.Now;

          // Initialize the looping level music
          levelMusic = new SoundPlayer(Resources.gamemusic);
          levelMusic.PlayLooping();

          // Get a random number generator
          random = new Random();
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
                // walls dont exist to collide with!
            }

            // check collision with enemies
            try 
            {
                if (HitAChar(player, enemyPoisonPacket))
                {
                    Fight(enemyPoisonPacket);

                    // Generate a random number to get a random effect from the RandomPotion (first 3 potions will be random potion candidates)
                    
                    // In the current state, the potion cannot be generated under improper conditions, BUT
                    // if you do something new like FLEE from battle, the potion will generate like this! Need a condition to fix this.
                    // Wait to see how Nis implements flee
                    rpot = InstantiateItem(random.Next(1, 3), this, enemyPoisonPacket.Position.x, enemyPoisonPacket.Position.y);
                    
                    

                }
                else if (HitAChar(player, enemyCheeto))
                {
                    Fight(enemyCheeto);
                }
                if (HitAChar(player, bossChatgpt))
                {
                    Fight(bossChatgpt);
                }
            }
            catch 
            {
                // if enemy was nulled, cant execute these, so we only try them and not force them on every tick
            }

            if (HitAnItem(player)) 
            {
                player.MoveBack();
                rpot.ExecuteEffect(this); //rpot is always the handle regardless of the item called because its a random item, thus rpot
            }
      

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

    }

        private bool HitAnItem(Character player) 
        {

            bool hitAnItem = false;
            try 
            {
                if (rpot != null) 
                {
                    if (player.Collider.Intersects(rpot.collider)) 
                    {
                        hitAnItem = true;
                    }
                }
            }
            catch 
            {
                //Error: null item?
            }

            return hitAnItem;
        }
    private bool HitAWall(Character c) {
      bool hitAWall = false;
            try 
            {
                if (walls[0] != null) 
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
                
            }
            catch 
            {
                // walls dont exist to collide with!
            }
      
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    public void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy, this);
      if (enemy.Name == "BossChatgpt")
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
