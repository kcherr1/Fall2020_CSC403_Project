using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private FrmDeath death_window;
    private Enemy enemy;
    private Player player;
    private SoundPlayer battleSound;
    private SoundPlayer worldSound;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
      lblFleeStatus.Text = "";
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

      battleSound = new SoundPlayer(Resources.battle_music);
      battleSound.PlayLooping();

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

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }


    private void btnAttack_Click(object sender, EventArgs e) {
      lblFleeStatus.Text = "";

      player.OnAttack(-4);
      //SoundPlayer attackSound = new SoundPlayer(Resources.attack_sound1);
      //attackSound.Play();
      if (enemy.Health > 0)
      {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      if (player.Health <= 0)
      {
        SoundPlayer deathSound = new SoundPlayer(Resources.death_music);
        battleSound.Stop();
        death_window = FrmDeath.GetInstance();
        death_window.ShowDialog();
        deathSound.Play();
        instance = null;
        Close();
      }

      if (enemy.Health <= 0)
      {
        //SoundPlayer winSound = new SoundPlayer(Resources.win_music);
        battleSound.Stop();
        worldSound = new SoundPlayer(Resources.world_music);
        worldSound.PlayLooping();
        //winSound.Play();
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

    private void button1_Click(object sender, EventArgs e) {
      double fleeChance = 0.5f;
      Random random = new Random();

      if (random.NextDouble() < fleeChance) {
        // flee!
        lblFleeStatus.Text = "Flee successful!";
        instance = null;
        Close();
      } else {
        // Flee failed.
        lblFleeStatus.Text = "Failed to flee!";

        if (enemy.Health > 0) {
          enemy.OnAttack(-2);
        }

        UpdateHealthBars();
        // We don't need to check for enemy health because the enemy cannot
        // be damaged if we are fleeing.
        if (player.Health <= 0) {
          instance = null;
          Close();
        }
      }
    }
  }
}
