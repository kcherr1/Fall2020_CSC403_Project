using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
        private readonly Random _random = new Random();
        private FrmBattle() {
      InitializeComponent();
      player = Game.player;
      
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

            

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;


      
      if (enemy.Health == enemy.MaxHealth)
      { 
        decimal modifier = Properties.Settings.Default.Difficulty;
        int newHealth = (int)Math.Floor(Decimal.Multiply(Convert.ToDecimal(enemy.Health), modifier));
        int offsetHealth = newHealth - enemy.Health;
        enemy.AlterHealth(offsetHealth);
      }

      // show health
      UpdateHealthBars();
    }
    
    
    

        
    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;
      SoundPlayer simpleSound = new SoundPlayer();
      {
          if (Properties.Settings.Default.Rogue == 0 & Properties.Settings.Default.PlayerChoice == 1)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Belloq__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 0 & Properties.Settings.Default.PlayerChoice == 2)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Belloq__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 0 & Properties.Settings.Default.PlayerChoice == 3)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Minotaur_versus_Belloq__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 0 & Properties.Settings.Default.PlayerChoice == 4)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Amazo_versus_Belloq__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 0 & Properties.Settings.Default.PlayerChoice == 5)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Mad_Hatter_versus_Belloq__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 0 & Properties.Settings.Default.PlayerChoice == 6)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Corn_versus_Belloq__mp3cut_net___1_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 1 & Properties.Settings.Default.PlayerChoice == 1)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Dracula__mp3cut_net_;
            simpleSound.Play();
          }
          if (Properties.Settings.Default.Rogue == 1 & Properties.Settings.Default.PlayerChoice == 2)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Dracula__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 1 & Properties.Settings.Default.PlayerChoice == 3)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Minotaur_versus_Dracula__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 1 & Properties.Settings.Default.PlayerChoice == 4)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Amazo_versus_Dracula__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 1 & Properties.Settings.Default.PlayerChoice == 5)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Mad_Hatter_versus_Dracula__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 1 & Properties.Settings.Default.PlayerChoice == 6)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Corn_versus_Dracula__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 2 & Properties.Settings.Default.PlayerChoice == 1)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Dalek__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 2 & Properties.Settings.Default.PlayerChoice == 2)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Dalek__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 2 & Properties.Settings.Default.PlayerChoice == 3)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Minotaur_versus_Dalek__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 2 & Properties.Settings.Default.PlayerChoice == 4)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Amazo_versus_Dalek__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 2 & Properties.Settings.Default.PlayerChoice == 5)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Mad_Hatter_versus_Dalek__mp3cut_net_;
            simpleSound.Play();
          }
          else if (Properties.Settings.Default.Rogue == 2 & Properties.Settings.Default.PlayerChoice == 6)
          {
            simpleSound.Stream = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Corn_versus_Dalek__mp3cut_net_;
            simpleSound.Play();
          }
      }

      tmrFinalBattle.Enabled = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      MessageBox.Show(enemy.Health.ToString());
      // Make sure health does not go over max
      if (player.Health > player.MaxHealth)
      {
          int offset = player.MaxHealth - player.Health;
          player.AlterHealth(offset);
          Properties.Settings.Default.Health = player.Health;
      }

      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
            int MinDamagePossible = Properties.Settings.Default.MinRandomBattleDamage;
            int MaxDamagePossible = Properties.Settings.Default.MaxRandomBattleDamage;
            int WeaponDamage = Properties.Settings.Default.WeaponDamage;
            int ArmorProtection = Properties.Settings.Default.ArmorProtection;
            decimal modifier = Properties.Settings.Default.Difficulty;
            MessageBox.Show("The modifier is " + modifier.ToString());
            int DamageDealtByPlayer = (int)Math.Floor(Decimal.Divide(Convert.ToDecimal(_random.Next(MinDamagePossible, MaxDamagePossible)), modifier)) + WeaponDamage;
            int DamageDealtByEnemy = (int)Math.Floor(Decimal.Multiply(Convert.ToDecimal(_random.Next(MinDamagePossible, MaxDamagePossible)), modifier)) - ArmorProtection;

            // Ensure negative damage does not heal player or enemy
            if (DamageDealtByEnemy < 0)
            {
                DamageDealtByEnemy = 0;
            }
            if (DamageDealtByPlayer < 0)
            {
                DamageDealtByPlayer = 0;
            }

            //MessageBox.Show("Player Hits for " + DamageDealtByPlayer.ToString() + " points of damage.");
            //MessageBox.Show(DamageDealtByEnemy.ToString());

            //player.OnAttack(-4);
            player.OnAttack(DamageDealtByPlayer*-3);  
            if (enemy.Health > 0) {
                //enemy.OnAttack(-2);
                enemy.OnAttack(DamageDealtByEnemy*-1); 
            }
     
      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        Close();
      }
    }

    private void EnemyDamage(int amount) {
      MessageBox.Show("Player does " + amount.ToString());
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      
      player.AlterHealth(amount);
      MessageBox.Show("Enemy does " + amount.ToString());
      Properties.Settings.Default.Health = player.Health;
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
