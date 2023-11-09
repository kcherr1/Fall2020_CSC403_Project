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

        private void btnAttack_Click(object sender, EventArgs e) {
            SoundPlayer simpleSound = new SoundPlayer(Resources.attack);
            simpleSound.Play();
            player.OnAttack(-4);
            if (enemy.Health > 0) {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
            if (player.Health <= 0)
            {
                instance = null;
                DialogResult gotoHomeDialogue = MessageBox.Show("You lose!!! Want to play again?", "YOU LOSE!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (gotoHomeDialogue == DialogResult.Yes)
                {
                    FrmHome.gameplayForm.Close();
                    FrmHome homeForm = new FrmHome();
                    homeForm.Show();
                    this.Close();
                }
                else
                {
                    Application.Exit();
                }
            }
            if (enemy.Health <= 0)
            {
                simpleSound = new SoundPlayer(Resources.success);
                simpleSound.Play();
                instance = null;
                if(enemy == FrmHome.gameplayForm.bossKoolaid)
                {
                    DialogResult gotoHomeDialogue = MessageBox.Show("You win!!! Want to play again?", "YOU WIN!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (gotoHomeDialogue == DialogResult.Yes)
                    {
                        FrmHome.gameplayForm.Close();
                        FrmHome homeForm = new FrmHome();
                        homeForm.Show();
                        this.Close();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Close();
                }

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

        private void btnFlee_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(Resources.flee);
            simpleSound.Play();
            this.Hide();
    
        }

        public void playerImgChange()
        {
            picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.peanut;
        }
    }
}
