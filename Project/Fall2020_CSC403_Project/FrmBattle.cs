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
        private GameOver gameover;

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

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }
        public static bool Death = false;
        public static int KillEnemy = 0;
        private void btnAttack_Click(object sender, EventArgs e) {
            SoundPlayer attack_audio = new SoundPlayer(Resources.boom);
            bool checkweapon = FrmLevel.haveAWeapon;
            if (checkweapon)
            {
                player.OnAttack(-8);
            }
            else
            {
                player.OnAttack(-4);
            }
            if (enemy.Health > 0) {
                attack_audio.Play();
                enemy.OnAttack(-2);
      }

      UpdateHealthBars();
            Death = false;
      if (enemy.Health <= 0)
      {
        instance = null;
                KillEnemy++;
        Death = true;
        Close();
                if (KillEnemy == 3)
                {
                    gameover = GameOver.GetInstance();
                    gameover.Show();
                }
      }
      if (player.Health <= 0)
            {
                instance = null;
                Close();
                gameover = GameOver.GetInstance();
                gameover.Show();
            }
    }
        private void btnEscape_Click(object sender, EventArgs e)
        {
            instance = null;
            Close();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string documentationUrl = "https://docs.google.com/document/d/158qKBqjiTSbWiRfbgNZ-8zu_gsyhuzam8IXES70mpeU/edit"; // link to google docs FAQ
            System.Diagnostics.Process.Start(documentationUrl);
        }

        private void FrmBattle_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmLevel.frmlevel.CheckResult(enemy);
        }
    }
}
