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

      // show health
      UpdateHealthBars();
    }
    
    
    

        
    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;
      {
      if (Properties.Resources.enemy_cheetos==Properties.Resources.Villain_Invisible_Man)
      {

          if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_1)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Dracula__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_2)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Dracula__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_3)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Minotaur_versus_Dracula__mp3cut_net_;
                this.Close();
          }
          if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_4)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Amazo_versus_Dracula__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_5)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Mad_Hatter_versus_Dracula__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_6)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Corn_versus_Dracula__mp3cut_net_;
                this.Close();
          }
       }

      else if (Properties.Resources.enemy_cheetos==Properties.Resources.Villain_Mondasian_Cyberman)
      {

          if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_1)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Dalek__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_2)
          {
                Properties.Resources.final_battle =  global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Dalek__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_3)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Minotaur_versus_Dalek__mp3cut_net_;
                this.Close();
          }
          if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_4)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Amazo_versus_Dalek__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_5)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Mad_Hatter_versus_Dalek__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_6)
          {
                Properties.Resources.final_battle = Properties.Resources.Final_Battle_Corn_versus_Dalek__mp3cut_net_;
                this.Close();
          }
       }

      else if (Properties.Resources.enemy_cheetos==Properties.Resources.Villain_German_Mechanic)
      {

          if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_1)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Sherlock_Holmes_versus_Belloq__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_2)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Winnie_the_Pooh_versus_Belloq__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_3)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Minotaur_versus_Belloq__mp3cut_net_;
                this.Close();
          }
          if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_4)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Amazo_versus_Belloq__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_5)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Mad_Hatter_versus_Belloq__mp3cut_net_;
                this.Close();
          }
          else if (Properties.Resources.PickedPlayer == Properties.Resources.Player_Choice_6)
          {
                Properties.Resources.final_battle = global::Fall2020_CSC403_Project.Properties.Resources.Final_Battle_Corn_versus_Belloq__mp3cut_net___1_;
                this.Close();
          }
       }
       }
      SoundPlayer simpleSound = new SoundPlayer(global::Fall2020_CSC403_Project.Properties.Resources.final_battle);
      simpleSound.Play();

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
    
      // Make sure health does not go over max
      if (player.Health > 20)
      {
          int offset = player.MaxHealth - player.Health;
          player.AlterHealth(offset);
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
            int DamageDealtByPlayer = _random.Next(MinDamagePossible, MaxDamagePossible) + WeaponDamage;
            int DamageDealtByEnemy = _random.Next(MinDamagePossible, MaxDamagePossible) - ArmorProtection;

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
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
