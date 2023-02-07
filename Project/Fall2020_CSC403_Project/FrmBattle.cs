﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
        public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    public static FrmLevelUp lvlUpMenu = FrmLevelUp.getInstance();
    SoundPlayer battleMusic = new SoundPlayer(stream: Resources.battle_music);
    SoundPlayer levelMusic = new SoundPlayer(stream: Resources.level_music);

        public bool buttonEnabled = true;
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
            peanutAttack.Visible = false;
            enemyAttackimg.Visible = false;
            starPlatinum.Visible = false;
            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();

      // play music
      battleMusic.PlayLooping();
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
        // Creates turns in combat, and handles post-combat responsibilities such as leveling up the player
        async Task PutTaskDelay()
        {
            await Task.Delay(750);
        }
        async Task BetweenTurns()
        {
            await Task.Delay(250);
        }
        private async void btnAttack_Click(object sender, EventArgs e) {
            if (buttonEnabled == true){
                buttonEnabled = false;
            if (player.playerSpeed >= enemy.enemySpeed)
            {
                picPlayer.Left = 60;
                peanutAttack.Visible = true;
                await PutTaskDelay();
                player.PlayerAttack(-1);
                peanutAttack.Visible = false;
                picPlayer.Left = 49;
                UpdateHealthBars();
                await BetweenTurns();
                if (enemy.Health > 0)
                    
                {
                    picEnemy.Left = 540;
                    enemyAttackimg.Visible = true;
                    starPlatinum.Visible = true;
                    await PutTaskDelay();
                    enemy.EnemyAttack(-1);
                    enemyAttackimg.Visible = false;
                    starPlatinum.Visible = false;
                    picEnemy.Left = 551;
                    UpdateHealthBars();
                    await BetweenTurns();

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
                picEnemy.Left = 540;
                enemyAttackimg.Visible = true;
                starPlatinum.Visible = true;
                await PutTaskDelay();
                enemy.EnemyAttack(-1);
                enemyAttackimg.Visible = false;
                starPlatinum.Visible = false;
                picEnemy.Left = 551;
                UpdateHealthBars();
                await BetweenTurns();
                if (player.Health > 0)
                {
                    picPlayer.Left = 60;
                    peanutAttack.Visible = true;
                    await PutTaskDelay();
                    player.PlayerAttack(-1);
                    peanutAttack.Visible = false;
                    picPlayer.Left = 49;
                    UpdateHealthBars();
                    await BetweenTurns();
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
                buttonEnabled = true;
            }
      UpdateHealthBars();
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        battleMusic.Stop();
        levelMusic.PlayLooping();

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

        private void btnFlee_Click(object sender, EventArgs e)
        {
            Flee();
        }

        //try to flee from battle
        private void Flee()
        {
            //generate random int
            Random rand = new Random();
            float num = rand.Next(0, 11);

            //if int less than 10 - player speed, player fails to flee and takes damage
            if(num < (10-player.playerSpeed))
            {
                enemy.EnemyAttack(-1);
                UpdateHealthBars();
            }
            else
            {
                instance = null;
                enemy.AlterHealth(enemy.MaxHealth - enemy.Health);
                UpdateHealthBars();
                battleMusic.Stop();
                levelMusic.PlayLooping();
                Close();
            }
        }
    }
}
