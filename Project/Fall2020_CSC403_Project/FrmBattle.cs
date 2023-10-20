﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Reflection;
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
      if (player.WeaponEquiped){
        weapon.Visible = true;
      }

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health and health packs
      UpdateHealthBars();
      HealthPackCountLabel.Text = player.HealthPackCount.ToString();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;
      picBossBattle.BringToFront();

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
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      if (player.WeaponEquiped){
        gunfireBlast.Visible = true;
        wait(100);
        gunfireBlast.Visible = false;
        wait(100);
        gunfireBlast.Visible = true;
        wait(100);
        gunfireBlast.Visible = false;
        wait(100);
        gunfireBlast.Visible = true;
        wait(100);
        gunfireBlast.Visible = false;
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

     private void Heal_Click(object sender, EventArgs e){
         if (player.HealthPackCount > 0 && player.Health != player.MaxHealth) {
            player.UseHealthPack();
            if (player.Health + 10 > player.MaxHealth) {
                player.AlterHealth(player.MaxHealth - player.Health);
            }
            else {
                player.AlterHealth(10);
            }
            UpdateHealthBars();
            HealthPackCountLabel.Text = player.HealthPackCount.ToString();
        }
     }

    // Found this code at: https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program
    public void wait(int milliseconds)
    {
      var timer1 = new System.Windows.Forms.Timer();
      if (milliseconds == 0 || milliseconds < 0) return;

      // Console.WriteLine("start wait timer");
      timer1.Interval = milliseconds;
      timer1.Enabled = true;
      timer1.Start();

      timer1.Tick += (s, e) =>
      {
        timer1.Enabled = false;
        timer1.Stop();
        // Console.WriteLine("stop wait timer");
      };

      while (timer1.Enabled)
      {
        Application.DoEvents();
      }
    }
  }
}
