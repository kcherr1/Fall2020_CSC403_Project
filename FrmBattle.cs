﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;


//Testing change with comment
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
      // check if Mr.Peanut is baby
      isBaby();
      // show level
      UpdateLevel();
    }

    public void SetupForBossBattle() {
      p1level.Visible = false;
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

    private void UpdateLevel() {
      p1level.Text = "Level " + player.level.ToString();
    } 

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      isBaby();
      if (player.Health > 0 && enemy.Health <= 0) {
        player.GainExperience(5);
        instance = null;
        Close();
      }
      UpdateLevel();
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
      p1level.Visible = true;
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }

    // isBaby checks the player's health to determine whether Mr.Peanut should be baby
    // should be called right after the health bar is updated
    private void isBaby() {
       if (player.Health <= 0.3 * player.MaxHealth) {
                picPlayer.BackgroundImage = Resources.playersmall;
                picPlayer.Refresh();
       }
       else {
                picPlayer.BackgroundImage = Resources.player;
                picPlayer.Refresh();
       }
    }
  }
}
