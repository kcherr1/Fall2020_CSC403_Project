using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            Console.WriteLine(picEnemy);
            Console.WriteLine(picEnemy.BackgroundImage);
            Console.WriteLine(enemy.Img.Width);
            pictureBox1.Image = enemy.Img;
            pictureBox1.Refresh();
            Console.WriteLine(picEnemy?.BackgroundImage?.Width);
            picEnemy.Visible = true;

            // Observer pattern
            //enemy.AttackEvent += PlayerDamage;
            //player.AttackEvent += EnemyDamage;

            // show health
            //UpdateHealthBars();
        }

        public static FrmDialogue GetInstance(Enemy enemy)
        {
            Console.WriteLine(enemy.Img.Width);

            if (player_instance != null && player_instance.IsDisposed)
            {
                player_instance = null;
            }
            if (player_instance == null)
            {
                player_instance = new FrmDialogue();
                player_instance.enemy = enemy;
                player_instance.Setup();
            }
            return player_instance;
        }

        public static void FrmDialogue_Load()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
