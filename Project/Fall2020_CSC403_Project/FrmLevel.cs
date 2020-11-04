using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private List<Enemy> enemies = new List<Enemy>();

        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        private bool holdLeft, holdRight, holdUp, holdDown;

        public FrmLevel()
        {
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            // initialize enemies on this form
            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            Enemy bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING))
            {
                Img = picBossKoolAid.BackgroundImage,
                Color = Color.Red,
                IsBoss = true
            };
            enemies.Add(bossKoolaid);

            Enemy enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING))
            {
                Img = picEnemyPoisonPacket.BackgroundImage,
                Color = Color.Green,
                IsBoss = false
            };
            enemies.Add(enemyPoisonPacket);

            Enemy enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING))
            {
                Img = picEnemyCheeto.BackgroundImage,
                Color = Color.FromArgb(255, 245, 161),
                IsBoss = false
            };
            enemies.Add(enemyCheeto);


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
            enemies.ForEach((enemy) =>
            {
                if (HitAChar(player, enemy))
                    Fight(enemy);
            });

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

            if (enemy.IsBoss)
            {
                frmBattle.SetupForBossBattle();
            }
        }

        protected override void OnDeactivate(EventArgs e)
        {
            // when form loses focus, stop movement
            holdLeft = false;
            holdRight = false;
            holdUp = false;
            holdDown = false;
            player.ResetMoveSpeed();
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!holdLeft)
                    {
                        player.UpdateMoveSpeed(Vector2.Left);
                        holdLeft = true;
                    }
                    break;

                case Keys.Right:
                    if (!holdRight)
                    {
                        player.UpdateMoveSpeed(Vector2.Right);
                        holdRight = true;
                    }
                    break;

                case Keys.Up:
                    if (!holdUp)
                    {
                        player.UpdateMoveSpeed(Vector2.Down);
                        holdUp = true;
                    }
                    break;

                case Keys.Down:
                    if (!holdDown)
                    {
                        player.UpdateMoveSpeed(Vector2.Up);
                        holdDown = true;
                    }
                    break;

                default:
                    break;
            }
        }

        private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    player.UpdateMoveSpeed(-Vector2.Left);
                    holdLeft = false;
                    break;

                case Keys.Right:
                    player.UpdateMoveSpeed(-Vector2.Right);
                    holdRight = false;
                    break;

                case Keys.Up:
                    player.UpdateMoveSpeed(-Vector2.Down); // down is up because form is top-left origin coordinate system
                    holdUp = false;
                    break;

                case Keys.Down:
                    player.UpdateMoveSpeed(-Vector2.Up); // up is down because form is top-left origin coordinate system
                    holdDown = false;
                    break;
            }
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
    }
}
