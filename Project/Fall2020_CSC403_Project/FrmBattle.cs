using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;

    public FrmBattle() {
      this.ControlBox = false;
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

        private void AddWinOrLossControls(string message, Color backgroundColor, bool isDefeat)
        {
            // Create a panel to darken the background
            Panel darkenPanel = new Panel();
            darkenPanel.Size = this.ClientSize;
            darkenPanel.BackColor = Color.FromArgb(128, 0, 0, 0);  // Semi-transparent black
            this.Controls.Add(darkenPanel);
            darkenPanel.BringToFront();

            // Create a label to show the message
            Label lblMessage = new Label();
            lblMessage.Text = message;
            lblMessage.Size = new Size(300, 50);
            lblMessage.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 75);
            lblMessage.Font = new Font("Arial", 10, FontStyle.Bold);
            lblMessage.ForeColor = Color.White;
            lblMessage.BackColor = backgroundColor;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            darkenPanel.Controls.Add(lblMessage);

            if (isDefeat)
            {
                // Create "Retry" button
                Button btnRetry = new Button();
                btnRetry.Text = "Retry";
                btnRetry.Size = new Size(100, 50);
                btnRetry.Location = new Point(this.Width / 2 - 110, this.Height / 2);
                btnRetry.FlatStyle = FlatStyle.Flat;
                btnRetry.ForeColor = Color.White;
                btnRetry.BackColor = Color.Green;
                btnRetry.Click += btnRetry_Click;
                darkenPanel.Controls.Add(btnRetry);

                // Create "Quit" button
                Button btnQuit = new Button();
                btnQuit.Text = "Quit";
                btnQuit.Size = new Size(100, 50);
                btnQuit.Location = new Point(this.Width / 2 + 10, this.Height / 2);
                btnQuit.FlatStyle = FlatStyle.Flat;
                btnQuit.ForeColor = Color.White;
                btnQuit.BackColor = Color.Red;
                btnQuit.Click += btnQuit_Click;
                darkenPanel.Controls.Add(btnQuit);
            }
            else
            {
                // Create "Proceed" button
                Button btnProceed = new Button();
                btnProceed.Text = "Proceed";
                btnProceed.Size = new Size(100, 50);
                btnProceed.Location = new Point(this.Width / 2 - 50, this.Height / 2);
                btnProceed.FlatStyle = FlatStyle.Flat;
                btnProceed.ForeColor = Color.White;
                btnProceed.BackColor = Color.Green;
                btnProceed.Click += btnProceedForWin_Click;
                darkenPanel.Controls.Add(btnProceed);
            }
        }


        private void btnRetry_Click(object sender, EventArgs e)
        {
            // Code to restart the game (You'll have to implement this yourself)
            // RestartGame(); 
            Application.Restart();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnProceedForWin_Click(object sender, EventArgs e)
        {
            // Code to proceed after winning
            this.Close();
        }


        private void defeatEnemy()
        {
            AddWinOrLossControls("Congrats! You defeated this opponent.", Color.Green, false);
        }

        private void defeatPlayer()
        {
            AddWinOrLossControls("Mr. Peanut died. You suck!", Color.Red, true);
        }



        private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      if (player.Health <= 0) {
        defeatPlayer();
        instance = null;
        //Close();
      }
      else if(enemy.Health <= 0){
            defeatEnemy();
            instance = null;
            //Close();
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

    private void picEnemy_Click(object sender, EventArgs e) {}

    private void FrmBattle_FormClosing(object sender, FormClosingEventArgs e)
    {
        instance = null;
        Hide();
    }
  }
}
