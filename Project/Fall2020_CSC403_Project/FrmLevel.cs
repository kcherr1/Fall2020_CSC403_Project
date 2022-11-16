using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmLevel : Form
    {
        private readonly Random _random = new Random();
        private Player player;
        private PlayerInventory inventory;
        private Weapon sword;
        private Armor shield;
        private Potion healthPotion;

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
            const int PADDING = 1;
            //const int NUM_WALLS = 13;
            int NUM_WALLS = 0;
            Random random = new Random();

            /*
                Here is where I am adding my code to create a random layout of walls
            
            */
            int[,] Map = createMap();

            var rowCount = Map.GetLength(0);
            var colCount = Map.GetLength(1);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    if (i == 0 || i == rowCount - 1 || j == 0 || j == colCount - 1 || Map[i, j] == 1)
                    {
                        PictureBox picWallCreated = new PictureBox
                        {
                            //Name = "pictureWall" + "_" + i.ToString() + "_" + j.ToString(),
                            Name = "pictureWall_" + NUM_WALLS,
                            Image = picWallTemplate.Image,
                            InitialImage = picWallTemplate.InitialImage,
                            SizeMode = picWallTemplate.SizeMode,
                            Size = picWallTemplate.Size,
                            Location = new Point(j * 50, i * 50),
                            Visible = true,
                            Padding = picWallTemplate.Padding,
                        };
                        this.Controls.Add(picWallCreated);
                        picWallCreated.BringToFront();
                        NUM_WALLS++;
                    }
                }
            }
            this.ResumeLayout();
            lblInGameTime.BringToFront();
            menuStrip1.BringToFront();

            walls = new Character[NUM_WALLS];
            for (int w = 0; w < NUM_WALLS; w++)
            {
                //PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;

                //need to change this to look for the walls created
                PictureBox pic = Controls.Find("pictureWall_" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }


            /* Now to create the players & enemies, but need to ensure they are in an open area */
            /* Pick a random location on the map and see if it is open, if so place character there there */
            while (player == null)
            {
                int rndX = random.Next(rowCount);
                int rndY = random.Next(colCount);
                if (Map[rndX, rndY] == 0)
                {
                    picPlayer.Size = new Size(40, 40);
                    picPlayer.Location = new Point(rndY * 50 + 5, rndX *50 + 5);
                    player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
                }
            }
            while (bossKoolaid == null)
            {
                int rndX = random.Next(rowCount);
                int rndY = random.Next(colCount);
                if (Map[rndX, rndY] == 0)
                {
                    picBossKoolAid.Size = new Size(40, 40);
                    picBossKoolAid.Location = new Point(rndY * 50 + 5, rndX * 50 + 5);
                    bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
                }
            }
            while (enemyCheeto == null)
            {
                int rndX = random.Next(rowCount);
                int rndY = random.Next(colCount);
                if (Map[rndX, rndY] == 0)
                {
                    picEnemyCheeto.Size = new Size(40, 40);
                    picEnemyCheeto.Location = new Point(rndY * 50 + 5, rndX * 50 + 5);
                    enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
                }
            }
            while (enemyPoisonPacket == null)
            {
                int rndX = random.Next(rowCount);
                int rndY = random.Next(colCount);
                if (Map[rndX, rndY] == 0)
                {
                    picEnemyPoisonPacket.Size = new Size(40, 40);
                    picEnemyPoisonPacket.Location = new Point(rndY * 50 + 5, rndX * 50 + 5);
                    enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
                }
            }


            //player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
            inventory = new PlayerInventory();
            sword = new Weapon("Sword", 2);
            healthPotion = new Potion("Health Potion", 10);
            shield = new Armor("Shield", 2);
            //inventory.Add(sword);
            inventory.Add(healthPotion);
            //inventory.Add(shield);

            //bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
            enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
            enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));
            bossKoolaid.Name = "The Kool Aid Man";
            enemyCheeto.Name = "Cheeto Man";
            enemyPoisonPacket.Name = "Poison Packet Man";

            bossKoolaid.Img = picBossKoolAid.BackgroundImage;
            enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
            enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

            bossKoolaid.Color = Color.Red;
            enemyPoisonPacket.Color = Color.Green;
            enemyCheeto.Color = Color.FromArgb(255, 245, 161);


            picPlayer.Image = Properties.Resources.PickedPlayer;


            Game.player = player;
            timeBegin = DateTime.Now;
        }

        private Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        private Collider CreateCollider(PictureBox pic, int padding)
        {
            //Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width + padding, pic.Size.Height + padding));
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
            if (enemyCheeto == null && enemyPoisonPacket == null && bossKoolaid == null)
            {
                tmrUpdateInGameTime.Enabled = false;
                frmWinner Form3 = new frmWinner();
                Form3.ShowDialog();
            }
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
            // player.AlterHealth(50); // This is so that I always started with 20 healt.
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

            // Edited by Buddy
            //if (enemyPoisonPacket.Health <=0) { enemyPoisonPacket = null; }
            if (enemyPoisonPacket != null)
            {
                if (enemyPoisonPacket.Health <= 0)
                {
                    enemyPoisonPacket = null;
                    picEnemyPoisonPacket.Dispose();
                    inventory.Add(sword);
                    MessageBox.Show("You have obtained a " + sword.Name + "!", "Loot");
                }
            }
            if (enemyCheeto != null)
            {
                if (enemyCheeto.Health <= 0)
                {
                    enemyCheeto = null;
                    picEnemyCheeto.Dispose();
                    inventory.Add(shield);
                    MessageBox.Show("You have obtained a " + shield.Name + "!", "Loot");
                }
            }
            if (bossKoolaid != null)
            {
                if (bossKoolaid.Health <= 0)
                {

                    bossKoolaid = null;
                    picBossKoolAid.Dispose();

                }
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
            if (other != null && you != null)
            {
                return you.Collider.Intersects(other.Collider);
            }
            else { return false; }
        }

        private void Fight(Enemy enemy)
        {
            player.ResetMoveSpeed();
            player.MoveBack();
            frmBattle = FrmBattle.GetInstance(enemy);
            tmrEnemyMove.Stop();
            tmrPlayerMove.Stop();
            if (enemy.Name == "The Kool Aid Man")
            {
                frmBattle.SetupForBossBattle();
            }
            frmBattle.ShowDialog();

            if (player.Health <= 0)
            {
                MessageBox.Show("You Lose!");
                Application.Exit();
            }

            tmrEnemyMove.Start();
            tmrPlayerMove.Start();
            if (enemy == bossKoolaid)
            {

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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop == true)
            {
                Application.Exit();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void editBattleDamageOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRandomBattleDamageInput Form2 = new frmRandomBattleDamageInput();
            Form2.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            foreach (Item item in inventory.Inventory)
            {
                toolStripComboBox1.Items.Add(item.Name);
            }
        }

        private void toolStripComboBox1_SelectionChanged(object sender, EventArgs e)
        {
            int index = toolStripComboBox1.SelectedIndex;
            Item item = inventory.Inventory[index];

            if (item is Potion)
            {
                int amtHealing = item.Use();
                inventory.Remove(item);
                player.AlterHealth(amtHealing);
            }
            else if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;

                weapon.Use();

                if (weapon.IsEquiped)
                {
                    Properties.Settings.Default.WeaponDamage = weapon.Damage;
                }
                else
                {
                    // Set back to the default damage
                    Properties.Settings.Default.WeaponDamage = 0;
                }
            }
            else if (item is Armor)
            {
                Armor armor = (Armor)item;

                armor.Use();

                if (armor.IsEquiped)
                {
                    Properties.Settings.Default.ArmorProtection = armor.Protection;
                }
                else
                {
                    Properties.Settings.Default.ArmorProtection = 0;
                }
            }
            toolStripComboBox1.Items.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.Items.Clear();
            foreach (Item item in inventory.Inventory)
            {
                toolStripComboBox1.Items.Add(item.Name);
            }
        }

        private void tmrEnemyMove_Tick(object sender, EventArgs e)
        {
            Object[] enemynames = { enemyCheeto, enemyPoisonPacket, bossKoolaid };
            foreach (Enemy EnemyName in enemynames)
            {
                if (EnemyName != null)
                {
                    EnemyName.Move();
                    if (enemyCheeto != null)
                    {
                        picEnemyCheeto.Location = new Point((int)enemyCheeto.Position.x, (int)enemyCheeto.Position.y);
                    }
                    if (enemyPoisonPacket != null)
                    {
                        picEnemyPoisonPacket.Location = new Point((int)enemyPoisonPacket.Position.x, (int)enemyPoisonPacket.Position.y);
                    }
                    if (bossKoolaid != null)
                    {
                        picBossKoolAid.Location = new Point((int)bossKoolaid.Position.x, (int)bossKoolaid.Position.y);
                    }

                    EnemyName.GoLeft();
                    // check collision with walls
                    if (HitAWall(EnemyName) || HitAChar(enemyCheeto, enemyPoisonPacket) || HitAChar(enemyCheeto, bossKoolaid) || HitAChar(enemyPoisonPacket, bossKoolaid))
                    {
                        EnemyName.MoveBack();
                        // Get new direction 
                        ChooseRandomDirection(EnemyName);
                    }
                    switch (EnemyName.Direction)
                    {
                        case 1:
                            EnemyName.GoLeft();
                            break;

                        case 2:
                            EnemyName.GoUp();
                            break;

                        case 3:
                            EnemyName.GoRight();
                            break;

                        case 4:
                            EnemyName.GoDown();
                            break;
                    }
                }
            }
        }

        private void ChooseRandomDirection(Enemy c)
        {
            /* Picking a new direction to go
            1. Choose a random integer:
                1 = left
                2 = up
                3 = right
                4 = down
            2. Change the characters direction 
            */

            int rndnum = _random.Next(1, 5);
            //while (rndnum = c.Direction) { rndnum = _random.Next(1, 4); }
            c.Direction = rndnum;
        }

        private void picWall3_Click(object sender, EventArgs e)
        {

        }
        private static int[,] createMap()
        {
            int[] dimensions = { 15, 30 };   // rows & columns of map
            int maxTunnels = 80;             // max number of tunnels possible
            int maxLength = 10;              // max length each tunnel can have

            int[,] map = new int[dimensions[0], dimensions[1]];
            for (int i = 0; i < dimensions[0]; i++)  // Row
            {
                for (int j = 0; j < dimensions[1]; j++)  // Column
                {
                    map[i, j] = 1;
                }
            }
            Random random = new Random();
            //int currentRow = Math.Floor(Math.Random() * dimensions); // our current row - start at a random spot
            int currentRow = random.Next(dimensions[0]);
            //int currentColumn = Math.floor(Math.random() * dimensions); // our current column - start at a random spot
            int currentColumn = random.Next(dimensions[1]);
            //Create a matrix (array) with 4 rows and 2 columns
            //[-1, 0], [1, 0], [0, -1], [0, 1]]; 
            //array to get a random direction from (left,right,up,down)
            int[][] directions = new int[4][];
            directions[0] = new int[2] { -1, 0 };
            directions[1] = new int[2] { 1, 0 };
            directions[2] = new int[2] { 0, -1 };
            directions[3] = new int[2] { 0, 1 };

            int[] lastDirection = new int[2]; // save the last direction we went
            int[] randomDirection = new int[2]; // next turn/direction - holds a value from directions

            // lets create some tunnels - while maxTunnels, dimentions, and maxLength  is greater than 0.
            while (maxTunnels >= 0 && dimensions[0] >= 0 && maxLength >= 0 && dimensions[1] >= 0)
            {

                // lets get a random direction - until it is a perpendicular to our lastDirection
                // if the last direction = left or right,
                // then our new direction has to be up or down,
                // and vice versa
                do
                {
                    randomDirection = directions[random.Next(directions.Length)];
                } while ((randomDirection[0] == -lastDirection[0] && randomDirection[1] == -lastDirection[1]) ||
                         (randomDirection[0] == lastDirection[0] && randomDirection[1] == lastDirection[1]));

                var randomLength = random.Next(maxLength + 1); //length the next tunnel will be (max of maxLength)
                int tunnelLength = 0; //current length of tunnel being created

                // lets loop until our tunnel is long enough or until we hit an edge
                while (tunnelLength < randomLength)
                {

                    //break the loop if it is going out of the map
                    if (((currentRow == 1) && (randomDirection[0] == -1)) ||
                        ((currentColumn == 1) && (randomDirection[1] == -1)) ||
                        ((currentRow == dimensions[0] - 2) && (randomDirection[0] == 1)) ||
                        ((currentColumn == dimensions[1] - 2) && (randomDirection[1] == 1)))
                    {
                        break;
                    }
                    else
                    {
                        map[currentRow, currentColumn] = 0; //set the value of the index in map to 0 (a tunnel, making it one longer)
                                                            //add the value from randomDirection to row and col (-1, 0, or 1) to update our location
                        currentRow += randomDirection[0];
                        currentColumn += randomDirection[1];
                        tunnelLength++; //the tunnel is now one longer, so lets increment that variable
                    }
                }

                if (tunnelLength > 0)
                { // update our variables unless our last loop broke before we made any part of a tunnel
                    lastDirection = randomDirection; //set lastDirection, so we can remember what way we went
                    maxTunnels--; // we created a whole tunnel so lets decrement how many we have left to create
                }
            }
            return map;
        }
    }
}
