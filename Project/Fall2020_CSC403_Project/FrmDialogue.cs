using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmDialogue : Form
    {
        public static FrmDialogue player_instance = null;
        public static FrmDialogue enemy_instance = null;
        private Enemy enemy;
        private Player player;

        public FrmDialogue()
        {
            InitializeComponent();
            player = Game.player;
        }

        public void Setup()
        {
            // update for this enemy
            //picEnemy.BackgroundImage = enemy.Img;
            //picEnemy.Refresh();
            //BackColor = enemy.Color;
            //picBossBattle.Visible = false;

            // Observer pattern
            //enemy.AttackEvent += PlayerDamage;
            //player.AttackEvent += EnemyDamage;

            // show health
            //UpdateHealthBars();
        }

        public static FrmDialogue GetInstance(Enemy enemy)
        {
            if (player_instance == null)
            {
                player_instance = new FrmDialogue();
                player_instance.enemy = enemy;
                player_instance.Setup();
            }
            return player_instance;
        }
        public static FrmDialogue GetInstance(Player player)
        {
            if (player_instance == null)
            {
                player_instance = new FrmDialogue();
                player_instance.player = player;
                player_instance.Setup();
            }
            return player_instance;
        }
        public static void FrmDialogue_Load()
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
