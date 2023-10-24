using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private Player player;

        private Enemy enemyPoisonPacket;
        private Enemy bossKoolaid;
        private Enemy enemyCheeto;
        private Character[] walls;
        private Item[] itemsList;

        private DateTime timeBegin;
        private FrmBattle frmBattle;

        public FrmLevel()
        {
            InitializeComponent();
        }

        private void FrmLevel_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;
            const int NUM_ITEMS = 1;

            player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;
            player.inventory.image = inventoryboard.BackgroundImage;
            inventoryboard.Hide();

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            itemsList = new Item[NUM_ITEMS];
            for (int i = 0; i < NUM_ITEMS; i++)
            {
                string itemname = "LVL1potion" + i.ToString();
                PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                itemsList[i] = new HealthItem(CreatePosition(item), CreateCollider(item, PADDING), itemname);
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


            
            if (HitAnItem(player))
            {
                Item itemHit = null;
                for (int w = 0; w < itemsList.Length; w++)
                {
                    if (player.Collider.Intersects(itemsList[w].Collider))
                    {
                        itemHit = itemsList[w];
                        break;
                    }
                }
                StoreItem(itemHit);
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

        private bool HitAnItem(Character c)
        {
            bool hitAnItem = false;
            for (int w = 0; w < itemsList.Length; w++)
            {
                if (c.Collider.Intersects(itemsList[w].Collider))
                {
                    hitAnItem = true;
                    break;
                }
            }
            return hitAnItem;
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

        private void StoreItem(Item item)
        {
            player.inventory.addItem(item);
            PictureBox pic = Controls.Find(item.NAME, true)[0] as PictureBox;
            pic.Hide();
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (player.inventory.visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.I:
                        Inventory_Load();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                    case Keys.A:
                        player.GoLeft();
                        break;

                    case Keys.Right:
                    case Keys.D:
                        player.GoRight();
                        break;

                    case Keys.Up:
                    case Keys.W:
                        player.GoUp();
                        break;

                    case Keys.Down:
                    case Keys.S:
                        player.GoDown();
                        break;

                    case Keys.I:
                        Inventory_Load();
                        break;

                    default:
                        player.ResetMoveSpeed();
                        break;
                }
            }
        }

        public void Inventory_Load()
        {
            if (player.inventory.visible)
            {
                this.inventoryboard.Hide();
                foreach (string itemname in player.inventory.itemstorage)
                {
                    PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                    inventoryItem.Hide();
                }
            }
            else
            {
                this.inventoryboard.Show();

                int x_pos = inventoryboard.Location.X  + player.inventory.LEFTPAD;
                int y_pos = inventoryboard.Location.Y + player.inventory.LEFTPAD;
                foreach (string itemname in player.inventory.itemstorage)
                {
                    PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                    if ((inventoryItem.Width + x_pos) > (inventoryboard.Location.X + inventoryboard.Width - player.inventory.RIGHTPAD))
                    {
                        x_pos = player.inventory.LEFTPAD;
                        y_pos = y_pos + (inventoryboard.Height * (1 / 3));
                    }
                    inventoryItem.Location = new Point(x_pos, y_pos);
                    inventoryItem.Show();
                }
            }
            player.inventory.setVisible(!player.inventory.visible);
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }
    }
}
