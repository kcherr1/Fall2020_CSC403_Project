using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;
        const int PADDING = 7;

        private Enemy enemyPoisonPacket;
    private Boss bossKoolaid;
    private Enemy enemyCheeto;
    private Projectile arrow;
    private Character[] walls;
    public string playerDirection = "right";
    private DateTime timeBegin;
    private FrmBattle frmBattle;
        private List<HealthItem> itemsListHealth;
        private List<Enemy> enemyList;
        private int rng;


        public FrmLevel()
        {
            InitializeComponent();
        }


    private void FrmLevel_Load(object sender, EventArgs e) {
            //const int PADDING = 7;
            const int ARROW_PADDING = 2;
            const int NUM_WALLS = 13;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING), 1.0f);
            bossKoolaid = new Boss(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING), 0.25f);
            enemyList = new List<Enemy>();
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING), 0.5f);
            enemyList.Add(enemyPoisonPacket);
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING), 0.5f);
            enemyList.Add(enemyCheeto);

            // character projectile attack
            arrow = new Projectile(CreatePosition(picPlayer), CreateCollider(picArrow, ARROW_PADDING));
            picArrow.Hide();
            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            picBossKoolAid.Hide();
            bossHealthBar.Hide();
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            player.inventory.image = inventoryboard.BackgroundImage;
            inventoryboard.Hide();
            selector.Parent = inventoryboard;
            selector.Hide();

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING), 0.0f);
            }

            itemsListHealth = new List<HealthItem>();
            try
            {
                int w = 0;
                while (true)
                {
                    string itemname = "LVL1potion" + w.ToString();
                    PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                    itemsListHealth.Add(new HealthItem(CreatePosition(item), CreateCollider(item, PADDING), itemname));
                    w = w + 1;
                }
            }
            catch (Exception ex)
            { }

            foreach (string itemname in player.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
                // Sets inventory Item as child to always display item images on top of the inventory board.
                inventoryItem.Parent = this.inventoryboard;
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }

    private Vector2 CreatePosition(PictureBox pic)
    {
        return new Vector2(pic.Location.X, pic.Location.Y);
    }

    /// <summary>
    /// runs arrow picturebox on its own
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tmrArrowMove_Tick(object sender, EventArgs e)
    {
            // check if projectile hits a wall
            if (ArrowHitAWall(arrow))
            {
                arrow.inFlight = false;
                arrow.impact(player);
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                picArrow.Hide();
            }

            //check if projectile hits an enemy
            if (ProjHitAEnemy(arrow, enemyPoisonPacket))
            {
                arrow.inFlight = false;
                enemyPoisonPacket.AlterHealth(arrow.Damage);
                arrow.impact(player);
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                picArrow.Hide();
                if (enemyPoisonPacket.Health <= 0)
                {
                    enemyList.Remove(enemyPoisonPacket);
                    if (enemyList.Count == 0)
                    {
                        bossKoolaid.setupBoss();
                        picBossKoolAid.Show();
                        bossHealthBar.Show();
                    }
                }
            }
            else if (ProjHitAEnemy(arrow, enemyCheeto))
            {
                arrow.inFlight = false;
                enemyCheeto.AlterHealth(arrow.Damage);
                arrow.impact(player);
                picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                picArrow.Hide();
                if (enemyCheeto.Health <= 0)
                {
                    enemyList.Remove(enemyCheeto);
                    if(enemyList.Count == 0)
                    {
                        bossKoolaid.setupBoss();
                        picBossKoolAid.Show();
                        bossHealthBar.Show();
                    }
                }
            }
            else if (bossKoolaid.showBoss)
            {
                if (ProjHitAEnemy(arrow, bossKoolaid))
                {
                    arrow.inFlight = false;
                    bossKoolaid.AlterHealth(arrow.Damage);
                    arrow.impact(player);
                    picArrow.Location = new Point((int)player.Position.x, (int)player.Position.y);
                    picArrow.Hide();
                }
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
        // enemyPoisonPacket.ResetMoveSpeed();
        // enemyPoisonPacket.MoveBack();
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto)) {
        // enemyCheeto.ResetMoveSpeed();
        // enemyCheeto.MoveBack();
        Fight(enemyCheeto);
      }
      //if (HitAChar(player, bossKoolaid)) {
      //  Fight(bossKoolaid);
      //}

      // update player's picture box, health bar, and health
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y + 15);
      playerHealthBar.Location = new Point((int)player.Position.x, (int)player.Position.y);
      UpdatePlayerHealthBars(player);
        }

    private Collider CreateCollider(PictureBox pic, int padding)
    {
        Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
        return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
    {
        player.ResetMoveSpeed();
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

        private bool HitAnItem(Character c)
        {
            bool hitAnItem = false;
            for (int w = 0; w < itemsListHealth.Count; w++)
            {
                if (c.Collider.Intersects(itemsListHealth[w].Collider))
                {
                    hitAnItem = true;
                    break;
                }
            }
            return hitAnItem;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }

        private bool ProjHitAEnemy(Projectile p, Character other)
        {
            return p.Collider.Intersects(other.Collider);
        }


        private void Fight(Enemy enemy)
        {
            /*
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();
            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
            */
            player.AlterHealth(-1);
        }         

        private void StoreItem(HealthItem item)
        {
            player.inventory.addHealthItem(item);
            PictureBox pic = Controls.Find(item.NAME, true)[0] as PictureBox;
            pic.Hide();
            pic.Parent = this.inventoryboard;
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (player.inventory.visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                    case Keys.A:
                        if(player.inventory.selectedItem > 0)
                        {
                            player.inventory.selectedItem -= 1;
                            selectedItem();
                        }
                        break;

                    case Keys.Right:
                    case Keys.D:
                        if(player.inventory.selectedItem < player.inventory.itemstorage.Count - 1)
                        {
                            player.inventory.selectedItem += 1;
                            selectedItem();
                        }
                        break;

                    case Keys.P:
                        InGameSettingsPage inGameSettingsPage = new InGameSettingsPage();
                        inGameSettingsPage.Show();
                        break;                  

                    case Keys.I:
                         Inventory_Close();
                         break;

                    case Keys.U:
                        string itemToUseName = player.inventory.itemstorage[player.inventory.selectedItem];
                        PictureBox itempic = Controls.Find(itemToUseName, true)[0] as PictureBox;

                        player.inventory.itemDictionary[itemToUseName].useItem(player);
                        player.inventory.itemstorage.Remove(itemToUseName);
                        itempic.Dispose();

                        if (player.inventory.selectedItem > 0)
                        {
                            player.inventory.selectedItem -= 1;
                            selectedItem();
                        }
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
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
                    case Keys.A:
                        player.GoLeft();
                        if (!arrow.inFlight)
                          playerDirection = "left";
                        break;

                    case Keys.Right:
                    case Keys.D:
                        player.GoRight();
                        if (!arrow.inFlight)
                          playerDirection = "right";
                        break;

                    case Keys.Up:
                    case Keys.W:
                        player.GoUp();
                        if (!arrow.inFlight)
                          playerDirection = "up";
                        break;

                    case Keys.Down:
                    case Keys.S:
                        player.GoDown();
                        if (!arrow.inFlight)
                          playerDirection = "down";
                        break;

                    case Keys.P:
                        InGameSettingsPage inGameSettingsPage = new InGameSettingsPage();
                        inGameSettingsPage.Show();
                        break;

                    case Keys.I:
                        Inventory_Open();
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
                // check collision with item(s)
            if (HitAnItem(player))
            {
                HealthItem itemHit = null;
                for (int w = 0; w < itemsListHealth.Count; w++)
                {
                    if (player.Collider.Intersects(itemsListHealth[w].Collider))
                    {
                        itemHit = itemsListHealth[w];
                        itemsListHealth.Remove(itemHit);
                        break;
                    }
                }
                StoreItem(itemHit);
            }
            }
            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y + 15);
            playerHealthBar.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        public void Inventory_Close()
        {
            this.inventoryboard.Hide();
            selector.Hide();
            foreach (string itemname in player.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
            }

            player.inventory.setVisible(!player.inventory.visible);

        }

        public void Inventory_Open()
        {
            this.inventoryboard.Show();

            int x_pos = player.inventory.PADDING;
            int y_pos = player.inventory.PADDING;
            foreach (string itemname in player.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                if ((inventoryItem.Width + x_pos) > (inventoryboard.Location.X + inventoryboard.Width - player.inventory.PADDING))
                {
                    x_pos = player.inventory.PADDING;
                    y_pos = y_pos + (inventoryboard.Height * (1 / 3));
                }
                inventoryItem.Location = new Point(x_pos, y_pos);
                inventoryItem.Show();

                x_pos = x_pos + player.inventory.PADDING + inventoryItem.Width;
            }

            player.inventory.setVisible(!player.inventory.visible);
            player.inventory.selectedItem = 0;
            selectedItem();
        }

        public void selectedItem()
        {
            if(player.inventory.itemstorage.Count > 0)
            {
                selector.Show();
                string itemname = player.inventory.itemstorage[player.inventory.selectedItem];
                PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                selector.Location = new Point(item.Location.X, item.Location.Y + item.Height);
                selector.Width = item.Width;
                selector.Height = player.inventory.PADDING / 2;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Closes the application when FrmLevel is closed 
        /// </summary>
        public void onFormClosed(object sender, FormClosedEventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void tmrCheetoMove_Tick(object sender, EventArgs e)
        {
            /*
            if (enemyCheeto.Health > 0)
            {
                enemyCheeto.Move();

                if (HitAWall(enemyCheeto))
                {
                    enemyCheeto.MoveBack();
                }
                else
                {
                    Random rnd = new Random();
                    rng = rnd.Next(4);

                    switch (rng)
                    {
                        case 0:
                            enemyCheeto.GoLeft();
                            break;

                        case 1:
                            enemyCheeto.GoRight();
                            break;

                        case 2:
                            enemyCheeto.GoUp();
                            break;

                        case 3:
                            enemyCheeto.GoDown();
                            break;

                    }

                }
            */
                picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
                cheetoHealthBar.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y - 15);
                UpdateCheetoHealthBars(enemyCheeto);
            //}
        }

        private void tmrPoisonMove_Tick(object sender, EventArgs e)
        {
            /*
            if (enemyPoisonPacket.Health > 0)
            {
                enemyPoisonPacket.Move();

                if (HitAWall(enemyPoisonPacket))
                {
                    enemyPoisonPacket.MoveBack();
                }
                else
                {
                    Random rnd = new Random();
                    rng = rnd.Next(4);

                    switch (rng)
                    {
                        case 0:
                            enemyPoisonPacket.GoLeft();
                            break;

                        case 1:
                            enemyPoisonPacket.GoRight();
                            break;

                        case 2:
                            enemyPoisonPacket.GoUp();
                            break;

                        case 3:
                            enemyPoisonPacket.GoDown();
                            break;

                    }

                }
            */
                picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
                poisonHealthBar.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y - 18);
                UpdatePoisonHealthBars(enemyPoisonPacket);
            //}
        }

        private void tmrBoss_Tick(object sender, EventArgs e)
        {
            UpdateBossHealthBars(bossKoolaid);
        }

        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdatePoisonHealthBars(Enemy enemy)
        {
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 65;
            poisonHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        }
        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdatePlayerHealthBars(Player p)
        {
            float playerHealthPer = p.Health / (float)p.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 55;
            playerHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
        }
        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdateCheetoHealthBars(Enemy enemy)
        {
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 68;
            cheetoHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        }
        /// <summary>
        /// Update label size relative to remaining enemy health
        /// </summary>
        /// <param name="enemy"></param>
        private void UpdateBossHealthBars(Enemy enemy)
        {
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            const int MAX_HEALTHBAR_WIDTH = 196;
            bossHealthBar.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
        }

    }
}
