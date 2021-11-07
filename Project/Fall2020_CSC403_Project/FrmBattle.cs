using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Threading;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : ChildForm {
    private bool bossBattle = false;
    private int message = 0;
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    public SoundPlayer battleMusic = new SoundPlayer(Resources.battle_music);
    public SoundPlayer mapMusic = new SoundPlayer(Resources.map_music);

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
      BattleMusic();

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();

      //update visibility of enemy messages to zero
      message = 0;
      displayMessage(message);
    }

    public void BattleMusic()
        {

            battleMusic.PlayLooping();
        }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
      simpleSound.Play();

      tmrFinalBattle.Enabled = true;
      bossBattle = true;
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

    private void displayMessage(int message){
      if(message == 1){
         message1.Visible = true;
      }
      if(message == 2){
         message2.Visible = true;
      }
      if(message == 3){
         message3.Visible = true;
      }
      if(message == 4){
         message4.Visible = true;
      }
      if(message == 5){
         message5.Visible = true;
      }
      if (message == 6){
        message6.Visible = true;
      }

      if (message == 0){
        //default all set to invisible
        message1.Visible = false;
        message2.Visible = false;
        message3.Visible = false;
        message4.Visible = false;
        message5.Visible = false;
        message6.Visible = false;
      }
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
        
      if (bossBattle & enemy.Health <= 0)
      {
        FrmLevel.win = true;
      }
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        battleMusic.Stop();
        mapMusic.PlayLooping();
        CloseCleanly();
      }
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
      //randomize message # which corresponds to a specific enemy message to be displayed when damaged
      Random random = new Random();
      message = random.Next(1, 6);
      displayMessage(message);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
