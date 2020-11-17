using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System.Collections.Generic; 
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    private bool enemyDied = false;
    private FrmBattle()
    { InitializeComponent();
	    player = Game.player;
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;
			// Show enemies experience given on kill
			lblEnemyXP.Text = enemy.ExperienceOnDeath.ToString() + " xp";

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
			// Show Current XP Status. 0 Is passed because no enemy defeated.
			UpdateExperienceBar(0);
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
				instance = new FrmBattle {
					enemy = enemy
				};
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

		private void UpdateExperienceBar(int xpGain) {
			const int MAX_EXPERIENCEBAR_WIDTH = 675;
			int totalXP = player.ExperienceToLevel - xpGain;

			// Check for level up
			if (totalXP <= 0) {
				player.ExperienceToLevel = 100 + totalXP;
				player.CurrentLevel += 1;
			}
			// Otherwise adjust Experience to level
			else {
				player.ExperienceToLevel = totalXP;
			}
			int currentXP = 100 - player.ExperienceToLevel;

			// Ensure the Background Bar is the same width as the ExperienceBar
			lblExperienceBarBackground.Width = MAX_EXPERIENCEBAR_WIDTH;
			// Width of experience is adjusted by the % to next level
			lblExperienceBar.Width = (int)(MAX_EXPERIENCEBAR_WIDTH * ((float)currentXP / 100));
			// Display Stats
			lblExperienceBar.Text = (currentXP).ToString() + " / 100 xp";
			lblCurrentLevel.Text = "Level: " + player.CurrentLevel.ToString();
		}

    private void btnAttack_Click(object sender, EventArgs e) {
            player.OnAttack(-4);
            this.Controls.Remove(this.Dialogue1);  //removes previous dialogue label to allow updated one (based on the enemy's health).
            this.Controls.Remove(this.Dialogue2);
            this.Controls.Remove(this.Dialogue3);
            if (enemy.Health > 0) 
            {
                enemy.OnAttack(-2);

            }

            if (enemy.Health > 15)
            {
                this.Controls.Add(this.Dialogue1);
            }

            else if (enemy.Health <= 15 && enemy.Health > 10)
            {
              
                this.Controls.Add(this.Dialogue2);
            }
            else if (enemy.Health < 10)
            {
            
                this.Controls.Add(this.Dialogue3);
            }


            if (player.Health > 0 && enemy.Health <= 0) {
				// Update the ExperienceBar sending the enemies Experience at death.
				UpdateExperienceBar(enemy.ExperienceOnDeath);
				this.enemy.Collider.Hide();
				enemyDied = true;
            }

      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
	      instance = null;
	      Close();
      }
    }

    public bool EnemyDied()
    {
	    return (enemyDied);
    }

    public Enemy CurrentEnemy()
    {
	    return (enemy);
    }
    private void btnRun_Click(object sender, EventArgs e)
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

		private void FrmBattle_Load(object sender, EventArgs e) {

		}


    private string randomText1()
    {
        Random r = new Random();
        List<string> samples = new List<string>();
        samples.Add("Do you know who I am kid ?");
        samples.Add("Let me teach you a lesson kid");
        samples.Add("You think you can beat me?");

        int index = r.Next(samples.Count);

        return samples[index];
    }
    
        
        //Made for dialogues display during fights
        private string randomText2()
    {
        Random r = new Random();
        List<string> samples = new List<string>();
        samples.Add("This is getting interesting");
        samples.Add("Hold on...I'm bleeding !? me!?");
        samples.Add("It's over for you!!!");
        samples.Add("hmmm...this kinda hurt");

        int index = r.Next(samples.Count);

        return samples[index];
    }
    private string randomText3()
    {
        Random r = new Random();
        List<string> samples = new List<string>();
        samples.Add("This is not looking good...");
        samples.Add("Am I going to...? impossibe!!!");
        samples.Add("This ends here and now!!!");

        int index = r.Next(samples.Count);

        return samples[index];
    }

    }


}
