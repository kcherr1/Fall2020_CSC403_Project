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
        int uses = new int();

        private FrmBattle() {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup() {
            // update for this enemy
            picEnemy.BackgroundImage = enemy.Img;
            picEnemy.Refresh();
            BackColor = enemy.BackgroundColor;
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

        //This is a button that makes the player and enemy both attack for random amounts of damage
        private void btnAttack_Click(object sender, EventArgs e) {
            var plyrChance = new Random();
            player.OnAttack(-(plyrChance.Next(2, 10)));

            if (enemy.Health > 0) {

                var nmyChance = new Random();
                enemy.OnAttack(-(nmyChance.Next(3, 9)));
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0) {
                instance = null;
                Close();
            }
        }

        //This is a button to heal for a random amount but can only be used a certain set number of times
        //It also stops the health at 20 if the heal would overflow
        private void btnHeal_Click(object sender, EventArgs e)
        {
            if (uses < 2 && player.Health != 20)
            {
                uses++;
                var plyrChance = new Random();
                player.AlterHealth(plyrChance.Next(5, 7));

                if (enemy.Health != 20)
                {
                    enemy.AlterHealth(1);

                    if (enemy.Health > 20)
                    {
                        enemy.SetHealth(20);
                    }
                }

                if (player.Health > 20)
                {
                    player.SetHealth(20);
                }
                UpdateHealthBars();
            }
        }

        //This is an infinite use button that has a chance to deflect the enemies attack back at them for damage
        private void btnDeflect_Click(object sender, EventArgs e)
        {
            var chance = new Random();
            var percent = chance.Next(0, 4);
            if (enemy.Health > 0 && percent > 1)
            {

                var nmyChance = new Random();
                enemy.OnAttack(-(nmyChance.Next(2, 6)));
            }

            if (enemy.Health > 0 && percent <= 1)
            {
                var plyrChance = new Random();
                player.OnAttack(-(plyrChance.Next(5, 8)));
            }

            UpdateHealthBars();
            if (player.Health <= 0 || enemy.Health <= 0)
            {
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


    }
}
