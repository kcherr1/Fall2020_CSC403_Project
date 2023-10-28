using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
//using RSG;


//using System.Timers;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private int start_time;
    private System.Windows.Forms.Timer tmrbattle_timer;
   

        private FrmBattle() {
      start_time = 15;
      InitializeComponent();
      this.tmrbattle_timer = new System.Windows.Forms.Timer(this.components);
      player = Game.player;
    }

    

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern

      //enemy.AttackEvent += PlayerDamage;
      enemy.AttackEvent += ArmorDamage;
      player.AttackEvent += EnemyDamage;

            // show health
      UpdateArmor();
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

            SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Play();
            //tmrbattle_timer.Enabled = true;
            tmrFinalBattle.Enabled = true;
            
        }

        public void SetupForVictoryScreen()
        {
            frmVictory victory = new frmVictory();
            victory.Show();
            this.Hide();
           /* picVictory.Location = Point.Empty;
            picVictory.Size = ClientSize;
            picVictory.Visible = true;*/
        }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

   private void battle_time_Tick(object sender,EventArgs e)
        {
            //lblbattletime.Text = start_time--.ToString();
            if (start_time < 0)
            {
                tmrbattle_time.Stop();
                instance = null;
                if (player.Health > enemy.Health)
                {
                    SetupForVictoryScreen();
                }
                else if (player.Health == enemy.Health)
                {
                    Close();
                }
                else
                {
                    Close();
                }
            }
            else
            {
                lblbattletime.Text = start_time--.ToString();
            }

                  
        }
        
		

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

     public void UpdateArmor()
     {
            float armorHealthPer= player.Armor/ (float)player.MaxArmor;
            //float playerHealthPer = player.Health / (float)player.MaxHealth;
            //float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_ARMORBAR_WIDTH = 226;
            //const int MAX_HEALTHBAR_WIDTH = 226;
            label3.Width = (int)(MAX_ARMORBAR_WIDTH * armorHealthPer);
           // lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            //lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            label3.Text = player.Armor.ToString();
            //lblEnemyHealthFull.Text = enemy.Health.ToString();
        }


        private void btnAttack_Click(object sender, EventArgs e)
        {
            player.OnAttack(-4);
            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateArmor();
            UpdateHealthBars();
            if (player.Health <= 0)
            {
                instance = null;
                Close();
                player.Collider.DeleteCollider();
            }
            if (enemy.Health <= 0)
            {
                instance = null;
                Close();
                enemy.Collider.DeleteCollider();
                FrmLevel.IsPaused = false;
                SetupForVictoryScreen();
            }
        }

        private void EnemyDamage(int amount) {
            ArmorAdjust(amount);
            enemy.AlterHealth(amount);
    }
        private void ArmorDamage(int amount)
        {
            player.AlterShield(amount);
        }

        private void ArmorAdjust(int armor)
        {
            if (player.Armor <= 0)
            {
                enemy.AttackEvent += PlayerDamage;
            }
        }


        private void PlayerDamage(int amount) {
            player.AlterHealth(amount);
      
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      tmrFinalBattle.Enabled = false;
    }
  }
    }

