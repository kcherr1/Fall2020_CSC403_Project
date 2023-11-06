using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public partial class Level2 : Form
    {
        private Player player2;

        private Enemy enemyPoisonPacket2;
        private Enemy bossKoolaid2;
        private Enemy enemyCheeto2;
        private Character[] walls2;
        private List<Item> itemsList2;

        private DateTime timeBegin2;
        private FrmBattle frmBattle2;

        public Level2()
        {
            //InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            const int PADDING = 7;
            const int NUM_WALLS = 13;

            player2 = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            bossKoolaid2 = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket2 = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto2 = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

            bossKoolaid2.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket2.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto2.Img = picEnemyCheeto.BackgroundImage;
            player2.inventory.image = inventoryboard.BackgroundImage;
            inventoryboard.Hide();

            bossKoolaid2.Color = Color.Red;
            enemyPoisonPacket2.Color = Color.Green;
            enemyCheeto2.Color = Color.FromArgb(255, 245, 161);

            walls2 = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls2[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }

            itemsList2 = new List<Item>();
            try
            {
                int w = 0;
                while (true)
                {
                    string itemname = "LVL2potion" + w.ToString();
                    PictureBox item = Controls.Find(itemname, true)[0] as PictureBox;
                    itemsList2.Add(new HealthItem(CreatePosition(item), CreateCollider(item, PADDING), itemname));
                    w = w + 1;
                }
            }
            catch (Exception ex)
            { }

            foreach (string itemname in player2.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
                // Sets inventory Item as child to always display item images on top of the inventory board.S
                inventoryItem.Parent = this.inventoryboard;
            }

            Game.player = player2;
            timeBegin2 = DateTime.Now;
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
            player2.ResetMoveSpeed();
        }

        private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan span = DateTime.Now - timeBegin2;
            string time = span.ToString(@"hh\:mm\:ss");
            lblInGameTime.Text = "Time: " + time.ToString();
        }

        private void tmrPlayerMove_Tick(object sender, EventArgs e)
        {
            // move player
            player2.Move();

            // check collision with walls
            if (HitAWall(player2))
            {
                player2.MoveBack();
            }

            // check collision with enemies
            if (HitAChar(player2, enemyPoisonPacket2))
            {
                Fight(enemyPoisonPacket2);
            }
            else if (HitAChar(player2, enemyCheeto2))
            {
                Fight(enemyCheeto2);
            }
            if (HitAChar(player2, bossKoolaid2))
            {
                Fight(bossKoolaid2);
            }

            // check collision with item(s)
            if (HitAnItem(player2))
            {
                Item itemHit = null;
                for (int w = 0; w < itemsList2.Count; w++)
                {
                    if (player2.Collider.Intersects(itemsList2[w].Collider))
                    {
                        itemHit = itemsList2[w];
                        itemsList2.Remove(itemHit);
                        break;
                    }
                }
                StoreItem(itemHit);
            }

            // update player's picture box
            picPlayer.Location = new Point((int)player2.Position.x, (int)player2.Position.y);
        }

        private bool HitAWall(Character c)
        {
            bool hitAWall = false;
            for (int w = 0; w < walls2.Length; w++)
            {
                if (c.Collider.Intersects(walls2[w].Collider))
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
            for (int w = 0; w < itemsList2.Count; w++)
            {
                if (c.Collider.Intersects(itemsList2[w].Collider))
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
            player2.ResetMoveSpeed();
            player2.MoveBack();
            frmBattle2 = FrmBattle.GetInstance(enemy);
            frmBattle2.Show();

            if (enemy == bossKoolaid2)
            {
                frmBattle2.SetupForBossBattle();
            }
        }

        private void StoreItem(Item item)
        {
            player2.inventory.addItem(item);
            PictureBox pic = Controls.Find(item.NAME, true)[0] as PictureBox;
            pic.Hide();
            pic.Parent = this.inventoryboard;
        }

        private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (player2.inventory.visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.I:
                        Inventory_Close();
                        break;
                    case Keys.U:
                        // Determine selected item, use item, remove item from inventory
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
                        player2.GoLeft();
                        break;

                    case Keys.Right:
                    case Keys.D:
                        player2.GoRight();
                        break;

                    case Keys.Up:
                    case Keys.W:
                        player2.GoUp();
                        break;

                    case Keys.Down:
                    case Keys.S:
                        player2.GoDown();
                        break;

                    case Keys.I:
                        Inventory_Open();
                        break;

                    default:
                        player2.ResetMoveSpeed();
                        break;
                }
            }
        }

        public void Inventory_Close()
        {
            this.inventoryboard.Hide();
            foreach (string itemname in player2.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                inventoryItem.Hide();
            }

            player2.inventory.setVisible(!player2.inventory.visible);
        }

        public void Inventory_Open()
        {
            this.inventoryboard.Show();

            int x_pos = player2.inventory.PADDING;
            int y_pos = player2.inventory.PADDING;
            foreach (string itemname in player2.inventory.itemstorage)
            {
                PictureBox inventoryItem = Controls.Find(itemname, true)[0] as PictureBox;
                if ((inventoryItem.Width + x_pos) > (inventoryboard.Location.X + inventoryboard.Width - player2.inventory.PADDING))
                {
                    x_pos = player2.inventory.PADDING;
                    y_pos = y_pos + (inventoryboard.Height * (1 / 3));
                }
                inventoryItem.Location = new Point(x_pos, y_pos);
                inventoryItem.Show();

                x_pos = x_pos + player2.inventory.PADDING;
            }

            player2.inventory.setVisible(!player2.inventory.visible);
        }

        private void lblInGameTime_Click(object sender, EventArgs e)
        {

        }

        private void FrmLevel_Load_1(object sender, EventArgs e)
        {

        }

        private void picWall3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Closes the application when Level2 is closed 
        /// </summary>
        public void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

    

}

