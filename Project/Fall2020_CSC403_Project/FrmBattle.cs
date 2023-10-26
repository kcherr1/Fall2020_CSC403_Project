using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using MyGameLibrary;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;

    //this helps keep track of whether or not this is a boss battle and if the boss is defeated
    public BossDefeatedWrapper bossIsDefeatedReference;
    private bool isBossBattle = false;

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

      isBossBattle = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      instance = new FrmBattle();
      instance.enemy = enemy;
      instance.Setup();
      return instance;
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

    private void btnAttack_Click(object sender, EventArgs e) {

      player.OnAttack(0); // CHANGE BACK TO -4 !!!!!!!!!!!!

      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        
        //Didn't rearrange this code much, this was just a convenient
        //way to add this experience gain;
        //if the player dies, then the experience gain doesn't matter
        if (enemy.Health <= 0)
        {
            player.EarnExperience(enemy.experience);
        }

        instance = null;
        

        //added this check to change the value in FrmLevel to true
        if (isBossBattle) {
            bossIsDefeatedReference.bossIsDefeated = true;
                    //added this to display the win screen for this level
                    //FrmWinLevel win_instance = FrmWinLevel.GetInstance();
                    if (player.Health > 0)
                    {
                        FrmWinLevel win_instance = new FrmWinLevel();
                        win_instance.Show();
                    }
                }
        if (enemy.Health <= 0)
        {
          enemy.AlterIsAlive(false);
        }
        if (player.Health <= 0)
        {
          player.AlterIsAlive(false);
        }
        if (!player.IsAlive)
        {
          FrmPlayerDeath playerDeathInstance = new FrmPlayerDeath();
          playerDeathInstance.Show();
        }
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
