using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using WMPLib;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;

    private SoundPlayer music;

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

      //play music 
      music = new SoundPlayer(Resources.nonBossTheme);
      music.PlayLooping();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      music = new SoundPlayer(Resources.newFinalTheme);
      music.PlayLooping();

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

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-2);
      if (enemy.Health > 0) {
        enemy.OnAttack(-1);
      }



      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        music.Stop(); //stop any music playing
        Close();
      }
    }

    // Retreat button
    private void btnRetreat_Click(object sender, EventArgs e)
    {
        if (player.Health > 0 && enemy.Health > 0)
        {
            UpdateHealthBars();
            instance = null;
            Close();
        }
    }
    // Counter button
    private void btnCounter_Click(object sender, EventArgs e) 
    {   enemy.OnAttack(-1);
        if(player.Health > 0)
        {
            player.OnAttack(-1);
        }
        UpdateHealthBars();
        if(player.Health <= 0 || enemy.Health <= 0) 
        { 
            instance = null;
            Close();
        }
    }

    // Finisher button
    private void btnFinisher_Click(object sender, EventArgs e)
    {
        if(enemy.Health < 10 && player.Health > enemy.Health) 
        {
            player.OnAttack(-6);
        }
        UpdateHealthBars();
        if(player.Health <= 0 || enemy.Health <= 0) 
        { 
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

        private void FrmBattle_Load(object sender, EventArgs e)
        {

        }
    }
}
