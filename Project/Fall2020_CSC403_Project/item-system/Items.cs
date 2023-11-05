using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.item_system.interfaces;

namespace Fall2020_CSC403_Project.item_system
{

    public class WallBoom : AbstractItem, IItem
    {
        public string itemName => "Wall Boom";
        public Collider collider { get; set; }
        public Vector2 initPos { get; set; }
        private SoundPlayer effectEventPlayer;
        


        public WallBoom(FrmLevel frmLevel, int numItems, float locXatLvl, float locYatLvl)
        {
            // Non unique methods(implemented the same for all items) are called from the AbsractItem class
            InitializeComponent(frmLevel, numItems, global::Fall2020_CSC403_Project.Properties.Resources.RandomPotion, locXatLvl, locYatLvl, "RandomItem", 50, 50, 18);
            initPos = CreatePosition(picItem);
            collider = CreateCollider(picItem, 7);

        }

        // Unique Implementations for each Item are required by the interface.
        //public void ExecuteEffect(FrmLevel frmLevel, Player player, Enemy enemy)
        public void ExecuteEffect(FrmLevel frmLevel)
        {
            /* ExecuteEffect: Triggers on collision of player with item object
             * EFFECT #1 : WallBoom ...maybe implement as separate item -- TODO: move to itemID 2 and make this a separate effect */

            EffectEvent(frmLevel, 18);

            // Remove all walls from map (or make them all non enabled or something
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

            // Now that the effect has been executed, remove the item from the map
            this.picItem.Visible = false;
            this.collider = null;
            


        }

        private async void EffectEvent(FrmLevel frmLevel, int tabIndex) 
        {

            effectEventPlayer = new SoundPlayer(global::Fall2020_CSC403_Project.Properties.Resources.wallBoomSound1);
            effectEventPlayer.Play();

            picEffectEvent = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(picEffectEvent)).BeginInit();
            frmLevel.SuspendLayout();

            this.picEffectEvent.Image = global::Fall2020_CSC403_Project.Properties.Resources.wallBoom1;
            this.picEffectEvent.Location = new System.Drawing.Point(150,50);
            this.picEffectEvent.Name = "WallBoom";
            this.picEffectEvent.Size = new System.Drawing.Size(650,650);
            this.picEffectEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEffectEvent.TabIndex = tabIndex;
            this.picEffectEvent.TabStop = false;

            frmLevel.Controls.Add(picEffectEvent);
            ((System.ComponentModel.ISupportInitialize)(picEffectEvent)).EndInit();
            frmLevel.ResumeLayout(false);

            // Give the gif time to play
            await Task.Delay(3000);

            // Remove the image after the gif plays for however many seconds
            picEffectEvent.Visible = false;

        }
        public void AI() 
        {
            
        }
    }

    /*
    public class WallBoom : IItem
    {
        public string itemName => "Wall Boom";
        public Collider collider { get; set; }
        public Vector2 initPos { get; set; }


        public void InitializeComponent(FrmLevel frmLvl) 
        {
            
        }
        */
        
        /*
        public void ExecuteEffect(FrmLevel frmLevel)
        {
            // see above implementation and copy paste here
        }
        */
        
        /*
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
        */
        
        /*
        public void ExecuteEffect(FrmLevel frmLevel)
        {
            // (remove enemy 1 from map)
            
            // num = random(1,2); // random betewen 2 numbers

            // if (num == 1)
                {
                    frmLevel.picEnemyPoisonPacket.Visible = false;
                    frmLevel.enemyPoisonPacket = null;
                }
                else if (num == 2)
                {
                    frmLevel.picEnemyCheeto.Visible = false;
                    frmLevel.enemyCheeto = null;
                }
        }
        */
        
        /*
        public void AI()
        {
            
        }
    }
    */
}
