using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.CodeDom;

namespace Fall2020_CSC403_Project {
    public partial class FrmLevel : Form{
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public FrmLevel()
        {
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int LEVEL_SIZE = 8;
            const int PADDING = 7;

            int rownumber = 0;
            int numwalls = 0;
            char[][] level = new char[LEVEL_SIZE][];
            string s = Properties.Resources.TestMap1;
            foreach (string row in s.Split('\n'))
            {
                level[rownumber] = row.ToCharArray();
                numwalls += row.Count(f => (f == '1'));
                rownumber++;
            }

            walls = new Character[numwalls];
            int count = 0;
            for (int index = 1; index <= LEVEL_SIZE * LEVEL_SIZE; index++)
            {
                PictureBox tile = Controls.Find("tile" + index.ToString(), true)[0] as PictureBox;
                switch ((level[(index - 1) / LEVEL_SIZE][(index - 1) % LEVEL_SIZE])){
                    case '0':
                        tile.BackgroundImage = Properties.Resources.wall;
                        walls[count] = new Character(CreatePosition(tile), CreateCollider(tile, PADDING, true));
                        count++;
                        break;
                    case '1':
                        tile.BackgroundImage = Properties.Resources.Grass_Texture;
                        break;
                    case '2':
                        tile.BackgroundImage = Properties.Resources.Sand_Texture;
                        break;
                    case '3':
                        tile.BackgroundImage = Properties.Resources.Lava_Texture;
                        break;
                    case '4':
                        tile.BackgroundImage = Properties.Resources.Ice_Texture;
                        break;
                    case '5':
                        tile.BackgroundImage = Properties.Resources.Snow_Texture;
                        break;
                }
            }

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING, true));
            Game.player = player;
            this.picPlayer.BringToFront();
            this.lblInGameTime.BringToFront();
            timeBegin = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding, Boolean canBeCollidedWith = false)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect, canBeCollidedWith);
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
    }
}
