using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    public static FrmLevel instance = null;
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Enemy Doritto; //new enemy called doritto
    private Enemy Knife; // new enemy called knife
    private Enemy GrapeKoolAid; // new enemy called GrapeKoolAid
    private Item health0;
    private Item health1;
    private Item offScreenItem;
    private Character[] walls;  

    private Enemy offScreenEnemy; // whenever an enemy dies, set that enemy to this instance (a hidden pictureBox)
    private Player offScreenPlayer;
    
    private DateTime timeBegin;
    private FrmBattle frmBattle;

    public Boolean invisibleEnemies = true; // This is what is used to turn on the ghost game mode

    System.Random random = new System.Random(); // calls the random class
    

    public FrmLevel() {
        InitializeComponent();
        this.ControlBox = false;
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
    private void setup() {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

      // Leave the enemies invisible if they select ghost game mode
      if (invisibleEnemies == false) {
        RandomEnemies();
      }
      else {
        picEnemyPoisonPacket.Visible = false;
        picEnemyCheeto.Visible = false;
        picEnemyDorittoMan.Visible = false;
        picEnemyKnife.Visible = false;
        picEnemyGrapeKoolAid.Visible = false;
      }

      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      
      offScreenEnemy = new Enemy(CreatePosition(picOffScreen), CreateCollider(picOffScreen, 0));
      offScreenPlayer = new Player(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0));
      Doritto = new Enemy(CreatePosition(picEnemyDorittoMan), CreateCollider(picEnemyDorittoMan, PADDING));
      Knife = new Enemy(CreatePosition(picEnemyKnife), CreateCollider(picEnemyKnife, PADDING));
      GrapeKoolAid = new Enemy(CreatePosition(picEnemyGrapeKoolAid), CreateCollider(picEnemyGrapeKoolAid, PADDING));
      health0 = new Item("Health", CreatePosition(picHeartContainer0), CreateCollider(picHeartContainer0, PADDING));
      health1 = new Item("Health", CreatePosition(picHeartContainer1), CreateCollider(picHeartContainer1, PADDING));
      offScreenItem = new Item("off_screen", CreatePosition(picOffScreen), CreateCollider(picOffScreen, 1));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      Doritto.Img = picEnemyDorittoMan.BackgroundImage;
      Knife.Img = picEnemyKnife.BackgroundImage;
      GrapeKoolAid.Img = picEnemyGrapeKoolAid.BackgroundImage;
                
      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      Doritto.Color = Color.AliceBlue;
      Knife.Color = Color.Brown;
      GrapeKoolAid.Color = Color.Purple;

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;

      // Show health
      PlayerHealthBar();
    }

    // cheeky fix because FrmLevelDesigner else needs a version of this function that takes arguments
    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));

      if (invisibleEnemies == false)
      {
        RandomEnemies();
      }
      else
      {
        picEnemyPoisonPacket.Visible = false;
        picEnemyCheeto.Visible = false;
        picEnemyDorittoMan.Visible = false;
        picEnemyKnife.Visible = false;
        picEnemyGrapeKoolAid.Visible = false;
      }

      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
      
      offScreenEnemy = new Enemy(CreatePosition(picOffScreen), CreateCollider(picOffScreen, 0));
      offScreenPlayer = new Player(CreatePosition(picOffScreenPlayer), CreateCollider(picOffScreenPlayer, 0));
      Doritto = new Enemy(CreatePosition(picEnemyDorittoMan), CreateCollider(picEnemyDorittoMan, PADDING));
      Knife = new Enemy(CreatePosition(picEnemyKnife), CreateCollider(picEnemyKnife, PADDING));
      GrapeKoolAid = new Enemy(CreatePosition(picEnemyGrapeKoolAid), CreateCollider(picEnemyGrapeKoolAid, PADDING));
      health0 = new Item("Health", CreatePosition(picHeartContainer0), CreateCollider(picHeartContainer0, PADDING));
      health1 = new Item("Health", CreatePosition(picHeartContainer1), CreateCollider(picHeartContainer1, PADDING));
      offScreenItem = new Item("off_screen", CreatePosition(picOffScreen), CreateCollider(picOffScreen, 1));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
      Doritto.Img = picEnemyDorittoMan.BackgroundImage;
      Knife.Img = picEnemyKnife.BackgroundImage;
      GrapeKoolAid.Img = picEnemyGrapeKoolAid.BackgroundImage;
                
      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);
      Doritto.Color = Color.AliceBlue;
      Knife.Color = Color.Brown;
      GrapeKoolAid.Color = Color.Purple;

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++) {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;

      // Show health
      PlayerHealthBar();
    }
    
    private Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    public static FrmLevel GetInstance() {
      if (instance == null) {
        instance = new FrmLevel();
        instance.setup();
      }
      return instance;
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

      if (HitAnItem(player, health0)) {
        player.InventoryAdd(health0);

        // removes the image
        picHeartContainer0.Hide();

        // sets the item to an already made iteam
        health0 = offScreenItem;

        picHeartIndex0.Show(); // the inventory image starts off hidden

        // stackoverflow.com/a/20060498/16369768
        picInventory0.Controls.Add(picHeartIndex0); // adds picture to picturebox
        picHeartIndex0.Location = new Point(15, 15); // places the new picture in the frame
      }

      if (HitAnItem(player, health1)) {
        player.InventoryAdd(health1);

        // removes the image
        picHeartContainer1.Hide();

        // sets the item to an already made iteam
        health1 = offScreenItem;

        // show the item in inventory
        picHeartIndex1.Show();
        picInventory1.Controls.Add(picHeartIndex1);
        picHeartIndex1.Location = new Point(15, 15);
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket)) {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        Fight(enemyCheeto);
      }

      else if (HitAChar(player, Doritto)) {
        Fight(Doritto);
      }

      else if (HitAChar(player, Knife)) {
        Fight(Knife);
      }

      else if (HitAChar(player, GrapeKoolAid)) {
        Fight(GrapeKoolAid);
      }
      
      else if (HitAChar(player, bossKoolaid)) {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);

      // Remove dead player's image
      if (IsDead(player)) {
         picPlayer.Hide();
         player = offScreenPlayer;
         player.Die();
      }

      // Remove the dead enemies' images
      if (IsDead(enemyPoisonPacket)) {
        picEnemyPoisonPacket.Hide();
        enemyPoisonPacket = offScreenEnemy;
      }
      else if (IsDead(enemyCheeto)) {
        picEnemyCheeto.Hide();
        enemyCheeto = offScreenEnemy;
      }
      else if (IsDead(bossKoolaid)) {
        picBossKoolAid.Hide();
        bossKoolaid = offScreenEnemy;
      }
      else if (IsDead(Doritto)) {
        picEnemyDorittoMan.Hide();
        Doritto = offScreenEnemy;
      }
      else if (IsDead(GrapeKoolAid)) {
        picEnemyGrapeKoolAid.Hide();
        GrapeKoolAid = offScreenEnemy;
      }
      else if (IsDead(Knife)) {
        picEnemyKnife.Hide();
        Knife = offScreenEnemy; 
      }

     // Update health
     PlayerHealthBar();
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

    private bool HitAnItem(Character you, Item other) { 
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
        case Keys.D1:
          if (picHeartIndex0.Visible == true) 
          { 
            player.AlterHealth(10);
            PlayerHealthBar();
            player.Inventory.Remove(health0);
            picHeartIndex0.Hide();
          }
          break;
        case Keys.D2:
          if (picHeartIndex1.Visible == true)
          {
            player.AlterHealth(10);
            PlayerHealthBar();
            player.Inventory.Remove(health1);
            picHeartIndex1.Hide();
          }
          break;
        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {
    }
    
    // Function for update the player's health bar on the main map
    public void PlayerHealthBar() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      
      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
    }

    // check if enemy is dead
    public bool IsDead(BattleCharacter character) {
      bool isDead = false;
      if (character.Health <= 0) {
          isDead = true;
      }
      return isDead;
    }
        
    private int [] Generate_RandomNumbers() {
      int max = 5;
      int number1 = random.Next(max);
      int number2 = random.Next(max);
      int number3 = random.Next(max);
      int number4 = random.Next(max);

      while((number1 == number2) || (number1 == number3) || (number1 == number4)) {
          number1 = random.Next(max);
      }
      while((number2 == number3) || (number2 == number4)) {
          number2 = random.Next(max);
      }
      while(number3 == number4) {
          number3 = random.Next(max);
      }
      int[] RandomNumbers = { number1, number2, number3, number4 };
      return RandomNumbers;
    }
        
    private void RandomEnemies() {
      int[] RandomPosition = Generate_RandomNumbers();
      picEnemyPoisonPacket.Visible = false;
      picEnemyCheeto.Visible = false;
      picEnemyDorittoMan.Visible = false;
      picEnemyKnife.Visible = false;
      picEnemyGrapeKoolAid.Visible = false;

      foreach (int i in RandomPosition) {
          if (i == 0)
              picEnemyPoisonPacket.Visible = true;
          else if (i == 1)
              picEnemyCheeto.Visible = true;
          else if (i == 2)
              picEnemyDorittoMan.Visible = true;
          else if (i == 3)
              picEnemyKnife.Visible = true;
          else if (i == 4)
              picEnemyGrapeKoolAid.Visible = true;
      }
    }

    private void pictureBox2_Click(object sender, EventArgs e) {
    }

    private void pictureBox1_Click(object sender, EventArgs e) {
    }

    private void picEnemyCheeto_Click(object sender, EventArgs e) {

    }

    private void Exit_MouseClick(object sender, MouseEventArgs e) {
       System.Windows.Forms.Application.Exit();
    }

    private void panel1_Paint(object sender, PaintEventArgs e) {

    }
  }
}
