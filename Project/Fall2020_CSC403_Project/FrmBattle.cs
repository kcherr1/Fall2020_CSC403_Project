using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
        public FrmLevelUp lvlUpMenu = FrmLevelUp.getInstance();

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

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
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
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;
            float playerExperience = 100 / (float)player.Experience;
    
      const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);
     
            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
            // experience bar to match the health bars
      const int MAX_EXPERIENCE_WIDTH = 226;
            lblPlayerExperienceFull.Width = (int)(MAX_EXPERIENCE_WIDTH / playerExperience);
            lblPlayerExperienceFull.Text = player.Experience.ToString();
    
        }
        // Creates turns in combat, and handles post-combat responsibilities such as levelling up the player
    private void btnAttack_Click(object sender, EventArgs e) {
            if (player.playerSpeed >= enemy.enemySpeed)
            {
                player.PlayerAttack(-1);
                if (enemy.Health > 0)
                {
                    enemy.EnemyAttack(-1);
                }
                else
                {
                    player.RewardExperience(50);
                        if (player.Experience >= 100)
                        {
                            player.RewardExperience(-100);
                        player.skillPoints += 5;
                        player.level += 1;
                        lvlUpMenu = FrmLevelUp.getInstance();
                        lvlUpMenu.Show();
                        player.AlterHealth(player.MaxHealth - player.Health);
                        UpdateHealthBars();
                        }

                }
            }
            else
            {
                enemy.EnemyAttack(-1);
                if (player.Health > 0)
                {
                    player.PlayerAttack(-1);
                    if (enemy.Health <= 0)
                    {   
                        
                        player.RewardExperience(50);
                        if (player.Experience >= 100)
                        {
                            player.RewardExperience(-100);
                            player.level += 1;
                            player.skillPoints += 5;
                            lvlUpMenu = FrmLevelUp.getInstance();
                            lvlUpMenu.Show();
                            player.AlterHealth(player.MaxHealth - player.Health);
                            UpdateHealthBars();
                        }
                    }

                }
               
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEnemyHealthFull_Click(object sender, EventArgs e)
        {

        }
    }
}
