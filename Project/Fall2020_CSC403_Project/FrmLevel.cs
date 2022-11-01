using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmLevel : Form {
    private Player player;
    private PlayerInventory inventory;
    private Weapon sword;
    private Armor shield;
    private Potion healthPotion;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;

    private DateTime timeBegin;
    private FrmBattle frmBattle;

    public FrmLevel() {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e) {
      const int PADDING = 7;
      const int NUM_WALLS = 13;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      inventory = new PlayerInventory();
      sword = new Weapon("Sword", 2);
      healthPotion = new Potion("Health Potion", 10);
      shield = new Armor("Shield", 2);
      //inventory.Add(sword);
      inventory.Add(healthPotion);
      //inventory.Add(shield);

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

      // Edited by Buddy
      //if (enemyPoisonPacket.Health <=0) { enemyPoisonPacket = null; }
      if (enemyPoisonPacket != null) { if (enemyPoisonPacket.Health <= 0)
                {
                    enemyPoisonPacket = null;
                    picEnemyPoisonPacket.Dispose();
                    inventory.Add(sword);
                    MessageBox.Show("You have obtained a " + sword.Name + "!", "Loot");
                } 
            }
        if (enemyCheeto != null)
        {
            if (enemyCheeto.Health <= 0)
            {
                    enemyCheeto = null;
                    picEnemyCheeto.Dispose();
                    inventory.Add(shield);
                    MessageBox.Show("You have obtained a " + shield.Name + "!", "Loot");
                }
        }
        if (bossKoolaid != null)
        {
            if (bossKoolaid.Health <= 0)
            {
                    bossKoolaid = null;
                    picBossKoolAid.Dispose();

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
            if (other != null)
            {
                return you.Collider.Intersects(other.Collider);
            }
            else { return false; }
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

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e) {

    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Application.MessageLoop == true) {
            Application.Exit();
        }
        else
        { 
            Environment.Exit(1);
        }
    }

    private void editBattleDamageOptionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmRandomBattleDamageInput Form2 = new frmRandomBattleDamageInput();
        Form2.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            foreach (Item item in inventory.Inventory)
            {
                toolStripComboBox1.Items.Add(item.Name);
            }
        }

        private void toolStripComboBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = toolStripComboBox1.SelectedIndex;
            Item item = inventory.Inventory[index];

            if (item is Potion)
            {
                int amtHealing = item.Use();
                inventory.Remove(item);
                player.AlterHealth(amtHealing);
            }
            else if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;

                weapon.Use();
                
                if (weapon.IsEquiped)
                {
                    Properties.Settings.Default.WeaponDamage = weapon.Damage;
                }
                else
                {
                    // Set back to the default damage
                    Properties.Settings.Default.WeaponDamage = 0;
                }
            }
            else if (item is Armor)
            {
                Armor armor = (Armor)item;

                armor.Use();

                if (armor.IsEquiped)
                {
                    Properties.Settings.Default.ArmorProtection = armor.Protection;
                }
                else
                {
                    Properties.Settings.Default.ArmorProtection = 0;
                }
            }
            toolStripComboBox1.Items.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            foreach (Item item in inventory.Inventory)
            {
                toolStripComboBox1.Items.Add(item.Name);
            }
        }
    }

}
