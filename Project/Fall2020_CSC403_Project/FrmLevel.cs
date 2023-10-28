﻿using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
<<<<<<< HEAD
using System.Security.Cryptography.X509Certificates;
=======
using System.Net.NetworkInformation;
>>>>>>> 9a002a9a36abae29cdf7f1ef25e92cb8bd7c92ab
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    public static FrmLevel instance = null;
    // Private variables
    private Player player;
    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
<<<<<<< HEAD
    private Character[] potions;

        private DateTime timeBegin;
=======
    private DateTime timeBegin;
>>>>>>> 9a002a9a36abae29cdf7f1ef25e92cb8bd7c92ab
    private FrmBattle frmBattle;
    // Public variables
    public String character;
    public int UpKeyDown = 0;
    public int LeftKeyDown = 0;
    public int DownKeyDown = 0;
    public int RightKeyDown = 0;
    public int UpKeyUp = 0;
    public int LeftKeyUp = 0;
    public int DownKeyUp = 0;
    public int RightKeyUp = 0;
    public bool u = false;
    public bool l = false;
    public bool d = false;
    public bool r = false;
    public int U = 0;
    public int L = 0;
    public int D = 0;
    public int R = 0;
    // Timer used for KeyEvents
    private static System.Timers.Timer clock;

        public FrmLevel()
    {
      InitializeComponent();
            Console.WriteLine("  " + UpKeyDown + "        " + UpKeyUp + "        " + U +
                "\n" + LeftKeyDown + "   " + RightKeyDown + "    " + LeftKeyUp + "   " + RightKeyUp + "    " + L + "   " + R +
                "\n  " + DownKeyDown + "        " + DownKeyUp + "        " + D);
        }

    public static FrmLevel GetInstance(int flag)
    {
        if (flag == 1)
        {
            instance = null;
        }
        else
        {
            if (instance == null)
            {
                instance = new FrmLevel();
            }
        }
        return instance;
    }
        private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 0;
      const int NUM_WALLS = 13;
      const int NUM_POTS = 3;

        
      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), character);
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
<<<<<<< HEAD
      
=======
        
        if (character == "baby")
        {
            picPlayer.Size = new Size(35, 60);
            player.Collider = CreateCollider(picPlayer, PADDING);
        }
>>>>>>> 9a002a9a36abae29cdf7f1ef25e92cb8bd7c92ab

      picPlayer.BackgroundImage = player.img;
     
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

      potions = new Character[NUM_POTS];
      for (int x = 0; x < NUM_POTS;x++)
      {
         PictureBox pic = Controls.Find("potion" + x.ToString(), true)[0] as PictureBox;
         potions[x] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
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
      int x = 0;
      if(HitAPotion(player))
      {
        player.MoveBack();
        player.AlterHealth(10);
         //potions[x] = null;
         x++;
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
    private bool HitAPotion(Character c)
    {
       bool hitAPotion = false;
       for (int w = 0; w < potions.Length; w++)
       {
          if (c.Collider.Intersects(potions[w].Collider))
          {
              hitAPotion = true;
              break;
          }
       }
       return hitAPotion;
    }

        private bool HitAChar(Character you, Character other) {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy) {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();
      //enemy.RemoveCollider();
     

      if (enemy == bossKoolaid) {
        frmBattle.SetupForBossBattle();
      }
    }

    protected override void OnKeyUp(KeyEventArgs e)
    {
        //
        // This event handler is raised every time
        // some key on the keyboard is released
        //

        base.OnKeyUp(e);

        //
        // Set corresponding key down flag state to false
        //

        if (e.KeyCode == Keys.Up)
        {
            u = false;
            player.charPosition[4] = 1;
            player.charPosition[5] = 0;
            player.charPosition[6] = 0;
            player.charPosition[7] = 0;
            UpKeyUp = ReturnKeyUpInt();
        }
        if (e.KeyCode == Keys.Left)
        {
            l = false;
            player.charPosition[4] = 0;
            player.charPosition[5] = 1;
            player.charPosition[6] = 0;
            player.charPosition[7] = 0;
            LeftKeyUp = ReturnKeyUpInt();
        }
        if (e.KeyCode == Keys.Down)
        {
            d = false;
            player.charPosition[4] = 0;
            player.charPosition[5] = 0;
            player.charPosition[6] = 1;
            player.charPosition[7] = 0;
            DownKeyUp = ReturnKeyUpInt();
        }
        if (e.KeyCode == Keys.Right)
        {
            r = false;
            player.charPosition[4] = 0;
            player.charPosition[5] = 0;
            player.charPosition[6] = 0;
            player.charPosition[7] = 1;
            RightKeyUp = ReturnKeyUpInt();
        }
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        //
        // This event handler is raised every time
        // some key on the keyboard is first pressed
        //

        base.OnKeyDown(e);

        //
        // Set corresponding key down flag state to true
        //

        if (e.KeyCode == Keys.Up)
        {
            u = true;
            player.charPosition[0] = 1;
            player.charPosition[1] = 0;
            player.charPosition[2] = 0;
            player.charPosition[3] = 0;
            UpKeyDown = ReturnKeyDownInt();
        }
        if (e.KeyCode == Keys.Left)
        {
            l = true;
            player.charPosition[0] = 0;
            player.charPosition[1] = 1;
            player.charPosition[2] = 0;
            player.charPosition[3] = 0;
            LeftKeyDown = ReturnKeyDownInt();
        }
        if (e.KeyCode == Keys.Down)
        {
            d = true;
            player.charPosition[0] = 0;
            player.charPosition[1] = 0;
            player.charPosition[2] = 1;
            player.charPosition[3] = 0;
            DownKeyDown = ReturnKeyDownInt();
        }
        if (e.KeyCode == Keys.Right)
        {
            r = true;
            player.charPosition[0] = 0;
            player.charPosition[1] = 0;
            player.charPosition[2] = 0;
            player.charPosition[3] = 1;
            RightKeyDown = ReturnKeyDownInt();
        }
    }

    public int ReturnKeyDownInt()
    {
        if (u == true)
        {
            return 1;
        }
        if (l == true)
        {
            return 1;
        }
        if (d == true)
        {
            return 1;
        }
        if (r == true)
        {
            return 1;
        }
        else
            return 0;
    }

    public int ReturnKeyUpInt()
    {
        if (u == false)
        {
            return 1;
        }
        if (l == false)
        {
            return 1;
        }
        if (d == false)
        {
            return 1;
        }
        if (r == false)
        {
            return 1;
        }
        else
            return 0;
    }

    public void UpdateKeyValues(Object source, System.Timers.ElapsedEventArgs e)
    {
        U = 0;
        L = 0;
        D = 0;
        R = 0;

        if (u) // Strictly Up
        {
            UpKeyDown = 1;
            LeftKeyDown = 0;
            DownKeyDown = 0;
            RightKeyDown = 0;
            UpKeyUp = 1;
            LeftKeyUp = 0;
            DownKeyUp = 0;
            RightKeyUp = 0;
            U++;
        }
        if (l) // Strictly Left
        {
            UpKeyDown = 0;
            LeftKeyDown = 1;
            DownKeyDown = 0;
            RightKeyDown = 0;
            UpKeyUp = 0;
            LeftKeyUp = 1;
            DownKeyUp = 0;
            RightKeyUp = 0;
            L++;
        }
        if (d) // Strictly Down
        {
            UpKeyDown = 0;
            LeftKeyDown = 0;
            DownKeyDown = 1;
            RightKeyDown = 0;
            UpKeyUp = 0;
            LeftKeyUp = 0;
            DownKeyUp = 1;
            RightKeyUp = 0;
            D++;
        }
        if (r) // Strictly Right
        {
            UpKeyDown = 0;
            LeftKeyDown = 0;
            DownKeyDown = 0;
            RightKeyDown = 1;
            UpKeyUp = 0;
            LeftKeyUp = 0;
            DownKeyUp = 0;
            RightKeyUp = 1;
            R++;
        }
            
    }

    public void ResetKeyValues()
    {
        UpKeyDown = 0;
        LeftKeyDown = 0;
        DownKeyDown = 0;
        RightKeyDown = 0;
        UpKeyUp = 0;
        LeftKeyUp = 0;
        DownKeyUp = 0;
        RightKeyUp = 0;
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e) {
        // Track directional keypresses
        Console.WriteLine("FrameLevel_KeyDownCall\n"+"  " + UpKeyDown + "        " + UpKeyUp + "        " + U +
            "\n" + LeftKeyDown + "   " + RightKeyDown + "    " + LeftKeyUp + "   " + RightKeyUp + "    " + L + "   " + R +
            "\n  " + DownKeyDown + "        " + DownKeyUp + "        " + D);
        // if Control key is pressed then call method that will change player values otherwise stay stock size
        if (e.Control == true)
        {
            if (character == "mr")
            {
                picPlayer.Size = new Size(36, 71);
                player.Collider = CreateCollider(picPlayer, 0);
                player.CharacterSelectedSpeed(1);
            }
            if (character == "mrs")
            {
                picPlayer.Size = new Size(36, 71);
                player.Collider = CreateCollider(picPlayer, 0);
                player.CharacterSelectedSpeed(1);
            }
            if (character == "baby")
            {
                picPlayer.Size = new Size(30, 50);
                player.Collider = CreateCollider(picPlayer, 0);
                player.CharacterSelectedSpeed(1);
            }
        }
        else
        {
            if (character == "mr")
            {
                picPlayer.Size = new Size(44, 90);
                player.Collider = CreateCollider(picPlayer, 0);
                player.CharacterSelectedSpeed(2);
            }
            if (character == "mrs")
            {
                picPlayer.Size = new Size(44, 90);
                player.Collider = CreateCollider(picPlayer, 0);
                player.CharacterSelectedSpeed(3);
            }
            if (character == "baby")
            {
                picPlayer.Size = new Size(35, 60);
                player.CharacterSelectedSpeed(1);
            }
        }
        player.KeysPressed(e,UpKeyDown,LeftKeyDown,DownKeyDown,RightKeyDown,UpKeyUp,LeftKeyUp,DownKeyUp,RightKeyDown);
        clock = new System.Timers.Timer(60.666);
        clock.Elapsed += UpdateKeyValues;
        clock.AutoReset = true;
        clock.Enabled = true;
        ResetKeyValues();
    }

<<<<<<< HEAD

    }
=======
        private void lblInGameTime_Click(object sender, EventArgs e) {

    }
    }
>>>>>>> 9a002a9a36abae29cdf7f1ef25e92cb8bd7c92ab
}
