using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : Form {
    public static FrmBattle instance = null;
    public SoundPlayer bossBattle = new SoundPlayer(@"..\..\data\BossBattleAudio.wav");
    public SoundPlayer winGame = new SoundPlayer(@"..\..\data\WinGameAudio.wav");
    public SoundPlayer loseGame = new SoundPlayer(@"..\..\data\LoseGameAudio.wav");
    private Enemy enemy;
    private Player player;
    private FrmLevel game;
    private FrmDeath death;

    private FrmBattle() {
      InitializeComponent();
      player = Game.player;
      game = FrmLevel.GetInstance(0);
    }

    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      for (int c = 1; c <= player.charges; c++)
      {
          PictureBox pic = Controls.Find("charge" + c.ToString(), true)[0] as PictureBox;
          pic.BackgroundImage = Image.FromFile(@"..\..\data\nutt.png");
      }
      if (player.character == "mr")
      {
          specialAttack.Text = "Wack";
          charge3.BackgroundImage = null;
      }
      else if(player.character == "mrs")
      {
          specialAttack.Text = "Karen Mode";
      }
      else
      {
          specialAttack.Text = "Bite";
      }
     picPlayer.BackgroundImage = player.img;
    player.BiteTurns[0] = 0;
    player.BiteTurns[1] = 0;
    player.BiteTurns[2] = 0;

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

      bossBattle.PlayLooping();

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
      if(player.character == "mr")
      {
            player.OnAttack(-5);
      }
      else if(player.character == "baby"){
            player.OnAttack(-3);
            for(int i =  0; i<3; i++)
            {
                    if (player.BiteTurns[i] > 0)
                    {
                        player.OnAttack(-2);
                        player.BiteTurns[i] -= 1;
                    }
            }
      }
      else
      {
            player.OnAttack(-4);
      }
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
      if (enemy.Health <= 0) {
        instance = null;
        bossBattle.Stop();
        game.StartMusic();
        //winGame.PlayLooping();
        Close();
      }
      if (player.Health <= 0){
        instance = null;
        bossBattle.Stop();
        game.Close();
        game = FrmLevel.GetInstance(1);
        death = new FrmDeath();
        loseGame.PlayLooping();
        death.Show();
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

        private void specialAttack_Click(object sender, EventArgs e)
        {
            if (player.charges == 0)
            {
                return;
            }
            player.charges -= 1;
            if(player.charges == 2)
            {
                charge3.BackgroundImage = Image.FromFile(@"..\..\data\cracked.png");
            }
            else if(player.charges == 1)
            {
                charge2.BackgroundImage = Image.FromFile(@"..\..\data\cracked.png");
            }
            else if(player.charges == 0)
            {
                charge1.BackgroundImage = Image.FromFile(@"..\..\data\cracked.png");
            }
            if(player.character == "mr")
            {
                player.OnAttack(-6);
                if (enemy.Health > 0)
                {
                    enemy.OnAttack(-2);
                }
            }
            else if(player.character == "mrs")
            {
                player.OnAttack(-3);
                player.Health += 6;
                if (player.Health >= player.MaxHealth)
                {
                    player.Health = player.MaxHealth;
                }
            }
            else
            {
                player.OnAttack(-3);
                for(int i=0; i < 3; i++)
                {
                    if (player.BiteTurns[i] == 0)
                    {
                        player.BiteTurns[i] = 3;
                        break;
                    }
                    else if (player.BiteTurns[i] > 0)
                    {
                        player.OnAttack(-2);
                        player.BiteTurns[i] -= 1;
                    }
                }
                if (enemy.Health > 0)
                {
                    enemy.OnAttack(-2);
                }
            }
            UpdateHealthBars();
            deathCheck();
        }
    }
}
