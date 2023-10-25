﻿using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Drawing.Text;
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
      this.FormClosed += (s, args) =>
      {
        instance = null;
        enemy.AttackEvent -= PlayerDamage;
        player.AttackEvent -= EnemyDamage;
        player.HealEvent -= PlayerHeal;
      };

    }
    
    public void Setup() {
      // update for this enemy
      battleTheme.PlayLooping();
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;
      player.HealEvent += PlayerHeal;

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;
      //SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      //simpleSound.Play();
      battleTheme.PlayLooping();

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
        PlayerScore(10);
      }

      UpdateHealthBars();
      if (enemy.Health <= 0) {
        instance = null;
        Close();
      } else if (player.Health == 0)
            {
                instance = null;
                Close();
                Application.Exit();
            }
    }

    private void btnHeal_Click(object sender, EventArgs e)
    {
        if (player.Health <= 0 || enemy.Health <= 0)
        {
            instance = null;
            Close();
        }
        else
        {

            if ((player.Health + 8) > 20)
            {
                player.OnHeal(20 - player.Health);
            }
            else
            {
                player.OnHeal(8);
            }


            if (enemy.Health > 0)
            {
                enemy.OnAttack(-2);
            }

            UpdateHealthBars();
        }
    }

    private void btnFlee_Click(object sender, EventArgs e)
        {
            //observers have to be cleared, otherwise other instances will do n*damage
            enemy.AttackEvent -= PlayerDamage;
            player.AttackEvent -= EnemyDamage;
            player.HealEvent -= PlayerHeal;
            instance = null;
            Close();

        }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void PlayerScore(int amount)
    {
        player.AlterScore(amount);
        lblPlayerScore.Text = "Score: " + player.Score.ToString();
        }

        private void PlayerHeal(int amount)
        {
            player.AlterHealth(amount);
        }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
