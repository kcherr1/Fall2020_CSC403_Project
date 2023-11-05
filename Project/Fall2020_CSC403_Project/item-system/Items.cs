using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.item_system.interfaces;

namespace Fall2020_CSC403_Project.item_system
{

    public class RandomPotion : AbstractItem, IItem
    {
        public string itemName => "Random Potion";
        public Collider collider { get; set; }
        public Vector2 initPos { get; set; }
        //private FrmLevel frmLevelAtItem;
        


        public RandomPotion(FrmLevel frmLevel, int numItems, float locXatLvl, float locYatLvl)
        {
            // Non unique methods(implemented the same for all items) are called from the AbsractItem class
            //InitializeComponent(frmLevel, NUM_ITEMS, global::Fall2020_CSC403_Project.Properties.Resources.RandomPotion, 767, 354, "RandomItem", 50, 50, 18);
            InitializeComponent(frmLevel, numItems, global::Fall2020_CSC403_Project.Properties.Resources.RandomPotion, locXatLvl, locYatLvl, "RandomItem", 50, 50, 18);
            initPos = CreatePosition(picItem);
            collider = CreateCollider(picItem, 7);

            // We need frmLevel accessible in other methods here, so we either need to keep track of it here,
            //  or pass frmLevel directly into it from RandomPotion.myMethod(FrmLevel frmLevel)
            //frmLevelAtItem = frmLevel;

        }

        // Unique Implementations for each Item are required by the interface.
        //public void ExecuteEffect(FrmLevel frmLevel, Player player, Enemy enemy)
        public void ExecuteEffect(FrmLevel frmLevel)
        {
            // EFFECT #1 : WallBoom ...maybe implement as separate item

            // remove all walls from map (or make them all non enabled or something
            // also execute a battle_screen type popup with a boom that disappears shortly after
            for (int w = 0; w < 13; w++)
            {
                // Get a handle for each wall picture
                PictureBox pic = frmLevel.Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                
                // Remove pictures from being seen
                pic.Visible = false;
                // Remove colliders ... each wall in walls that was constructed in frmLevel has a collider. if we null the class contained in wall, all is removed
                frmLevel.walls[w] = null; // In order to null this, checks for the walls need to have try catch in case the walls no longer exist!
                
            }
            


        }
        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            // remove all walls from map (or make them all non enabled or something
            // also execute a battle_screen type popup with a boom that disappears shortly after
        }*/

        /*void GetItemControls() 
        {
            items = new Character[NUM_ITEMS];
            for (int w = 0; w < NUM_ITEMS; w++)
            {
                PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
                walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
            }
        private bool ItemIsHit(Character c)
        {
            bool hitAnItem = false;
            walls = new Character[NUM_WALLS];
          for (int w = 0; w < NUM_WALLS; w++) {
            PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
            walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
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
        void PlaceHolder(Player player) 
        {
            if (ItemIsHit()) 
            {
                player.ResetMoveSpeed();
                player.MoveBack();
            }
        }*/

        public void AI() 
        {
            
        }
    }

    /*public class WallBoom : IItem
    {
        public string itemName => "Wall Boom";
        public Collider collider { get; set; }
        public Vector2 initPos { get; set; }


        public void InitializeComponent(FrmLevel frmLvl) 
        {
            
        }
        *//*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            // remove all walls from map (or make them all non enabled or something
            // also execute a battle_screen type popup with a boom that disappears shortly after
            
            FormWallBoom frmWallBoom = new FormWallBoom(); //instantiate the form 

            // Remove all walls from the game
            frmLvl.picWall1.Visible = false;
            frmLvl.picWall2.Visible = false;
            frmLvl.picWall3.Visible = false;
            frmLvl.picWall4.Visible = false;
            frmLvl.picWall5.Visible = false;
            frmLvl.picWall6.Visible = false;
            frmLvl.picWall7.Visible = false;
            frmLvl.picWall8.Visible = false;
            frmLvl.picWall9.Visible = false;
            frmLvl.picWall10.Visible = false;
            frmLvl.picWall11.Visible = false;
            frmLvl.picWall12.Visible = false;
            frmLvl.picWall13.Visible = false;
        }*//*

        public void AI()
        {
            
        }
    }

    public class Enemy1Boom: IItem
    {
        public string itemName => "Enemy Boom";
        public Collider collider { get; set; }
        public Vector2 initPos { get; set; }
        public void InitializeComponent(FrmLevel frmLvl)
        {

        }

        *//*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            // (remove enemy 1 from map)
            
            // num = random(1,2); // random betewen 2 numbers

            // if (num == 1)
                {
                    frmLvl.picEnemyPoisonPacket.Visible = false;
                    frmLvl.picEnemyPoisonPacket.Enabled = false;
                }
                else if (num == 2)
                {
                    frmLvl.picEnemyCheeto.Visible = false;
                    frmLvl.picEnemyCheeto.Enabled = false;
                }
        }*//*
        public void AI()
        {
            
        }
    }*/
}
