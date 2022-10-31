using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Weapon weapon;
        private Character[] walls;
        
        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public FrmLevel()
        {
            InitializeComponent();
        }
        //var for weapon iteration
        int index;
        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;


            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            weapon = new Weapon(CreatePosition(picGun), CreateCollider(picGun, PADDING));

            //Randomizes the weapons that are on the Map
            Random rand = new Random(DateTime.Now.ToString().GetHashCode());
            var list = new List<string> { "one", "two", "three" };
             index = rand.Next(0,list.Count);

            if (index == 0)
            {
                this.picGun.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.ak47;
            
            }
            if (index == 1)
            {
                this.picGun.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.m16;

            }
            if (index == 2)
            {
                this.picGun.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.sniper;

            }

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;


            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            Game.player = player;
            timeBegin = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            player.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player.Move();

            // check collision with walls
            if (HitAWall(player))
            {
                player.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player, enemyPoisonPacket))
            {
                Fight(enemyPoisonPacket);
            }
            else if (HitAChar(player, enemyCheeto))
            {
                Fight(enemyCheeto);
            }
            if (HitAChar(player, bossKoolaid))
            {
                Fight(bossKoolaid);
            }


            //Picks up weapon if collided with!
            if ((HitAChar(player, weapon) && index == 0))
            {
                picGun.Visible = false;
                this.picGun.Location = new System.Drawing.Point(-500,-500);
                this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player_ak47;
            }

            if ((HitAChar(player, weapon) && index == 1))
            {
                picGun.Visible = false;
                this.picGun.Size = new System.Drawing.Size(200, 75);
                this.picGun.Location = new System.Drawing.Point(-500, -500);
                this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player_m16;
            }

            if ((HitAChar(player, weapon) && index == 2))
            {
                picGun.Visible = false;
                this.picGun.Location = new System.Drawing.Point(-500, -500);
                this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player_sniper;
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls.Length; w++)
            {
                if (c.Collider.Intersects(walls[w].Collider))
                {
                    hitAWall = true;
                    break;
                }
            }
            return hitAWall;
        }

        private bool HitAChar(Character you, Character other)
        {
            return you.Collider.Intersects(other.Collider);
        }


        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            frmBattle.Show();

            if (enemy == bossKoolaid)
            {
                frmBattle.SetupForBossBattle();
            }
            //Calls the BoostAttack while in Fight!
            if (picGun.Visible == false)
            {
                BoostAttack(player);
                picGun.Visible = false;
            }
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.GoLeft();
                    break;

                case Keys.Right:
                    player.GoRight();
                    break;

                case Keys.Up:
                    player.GoUp();
                    break;

                case Keys.Down:
                    player.GoDown();
                    break;

                default:
                    player.ResetMoveSpeed();
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
        //Boosts attack when the Player has picked up weapon
        //Weapon is a one time use Instant Kill
        private void BoostAttack(Player player)
        {
            player.OnAttack(-8);
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
        }

    }

}
