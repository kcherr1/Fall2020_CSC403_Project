using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project 
{
    public partial class FrmBattle : Form 
    {
        // This is the variable that controls our instance of the class FrmBattle. The active/inactive elements are tied to it.
        public static FrmBattle instance = null;
        public static SoundPlayer simpleSound;

        private Enemy enemy;
        private Player player;
        

        public FrmBattle() 
        {
            InitializeComponent();
            player = Game.player;
            
        }

        public void FormBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If the player closes the battle before it ends. Release the instance
            //  so it does not lead to disposed exception.
            instance = null;
            // Better yet, make it so when the user closes the battle the game closes.
            // You cannot run from battle by closing it!
            Application.Exit();
        }
        public void Setup() 
        {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.Color;
            //picBossBattle.Visible = false;
            picEpicBossBattle.Visible = false;
            label3.Visible = false;

            // Observer pattern
            enemy.AttackEvent += PlayerDamage;
            enemy.HealEvent += EnemyDamage;
            player.AttackEvent += EnemyDamage;

            // show health
            UpdateHealthBars();
            label3.Text = "ChatGPT: \r\nYou'll never win human!";

        }

        public void SetupForBossBattle() 
        {
            //picBossBattle.Location = Point.Empty;
            //picBossBattle.Size = ClientSize;
            //picBossBattle.Visible = true;
            picEpicBossBattle.Location = Point.Empty;
            picEpicBossBattle.Size = ClientSize;

            picEpicBossBattle.Visible = true;
            label3.Visible = true;

            //SoundPlayer simpleSound = new SoundPlayer(Resources.final_battle);
            simpleSound.Stop();
            simpleSound = new SoundPlayer(Resources.cgptBossRapTakeoverwav);
            //simpleSound.Play();
            simpleSound.PlayLooping();

            tmrFinalBattle.Enabled = true;
        }

        // In order to make the instance nonnull, we use this. if its already non null, we can just use FrmBattle.instance to access it. 
        // Or FrmBattle.attribute to access tha attribute if its public.
        // Although, the instance of FrmBattle is tied to the enemy thats fighting the player in the said frmbattle.
        // and everytime the instance is called, the frmbattle map is setup.
        // I may need to go back and turn all the "this" stuff back on for label3 which is tied to instance.
        public static FrmBattle GetInstance(Enemy enemy) 
        {

            if (instance == null) 
            {
                instance = new FrmBattle();
                instance.enemy = enemy;
                instance.Setup();
            }
            return instance;
        }

        private void UpdateHealthBars() 
        {
            float playerHealthPer = player.Health / (float)player.MaxHealth;
            float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

            const int MAX_HEALTHBAR_WIDTH = 226;
            lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
            lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

            lblPlayerHealthFull.Text = player.Health.ToString();
            lblEnemyHealthFull.Text = enemy.Health.ToString();
        }

        private async void btnAttack_Click(object sender, EventArgs e) 
        {
            player.OnAttack(-3);
            SoundPlayer simpleSFX = new SoundPlayer(Resources.attack1SFX);
            simpleSFX.Play();
      
            if (enemy.Health > 0) 
            {

                if (enemy.Name == "boss") 
                {
                    // Create the constructor
                    CGPT cgpt = new CGPT();
                    // use CGPT to get the boss's attack or heal decision!
                    var result = await cgpt.GetBossDecision(player.Health, enemy.Health, -4, -2, 3);
                    if (result.ToString() == "attack")
                    {
                        enemy.OnAttack(-2);
                        label3.Text = $"You do 3 damage, and CGPT Attacks for 2 damage";
                    }
                    if (result.ToString() == "heal")
                    {
                        enemy.OnHeal(4);
                        label3.Text = $"You do 3 damage, but CGPT Heals 4 health back!";
                    }
                }
                else
                {
                    enemy.OnAttack(-2);
                }


            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0) 
            {
                if (enemy.Name == "boss")
                {
                    simpleSound.Stop();
                    simpleSound = new SoundPlayer(Resources.congrats);
                    simpleSound.Play();
                }
                else
                {
                    // for all other enemies, after battle play another sound
                }
                // for all enemies, after battle close instance
                instance = null;
                Close();
            }
            if (player.Health <= player.MaxHealth/2 || enemy.Health <= enemy.MaxHealth / 2) 
            {
                CGPT cgpt = new CGPT();
                label3.Text = await cgpt.GetBossMidBattleCommentDying();
                //label3.Text = "Someone's health is below half, oh no!";
            }
        }

        private void EnemyDamage(int amount) 
        {
            enemy.AlterHealth(amount);
        }

        private void PlayerDamage(int amount) 
        {

            player.AlterHealth(amount);
        }

        private void tmrFinalBattle_Tick(object sender, EventArgs e) 
        {
            //picBossBattle.Visible = false;
            picEpicBossBattle.Visible = false;
            tmrFinalBattle.Enabled = false;
        }

    }
}
