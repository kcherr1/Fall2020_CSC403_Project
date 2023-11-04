using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.item_system.interfaces;

namespace Fall2020_CSC403_Project.item_system
{
    public class PeanutPotion : IItem
    {
        public string itemName => "Peanut Potion";

        public System.Windows.Forms.PictureBox picItem;
        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            player.Health += 10;
            if (player.Health >= player.MaxHealth)
            {
                player.Health = player.MaxHealth;
            }
        }*/

        public PeanutPotion(FrmLevel frmLevel) 
        {
            InitializeComponent(frmLevel);
        }
        public void InitializeComponent(FrmLevel frmLevel)
        {
            picItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(picItem)).BeginInit();
            frmLevel.SuspendLayout();
            picItem.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.battle_screen;
            picItem.Location = new System.Drawing.Point(801, 387);
            picItem.Name = "picItem";
            picItem.Size = new System.Drawing.Size(100, 50);
            picItem.TabIndex = 18;
            picItem.TabStop = false;
            frmLevel.Controls.Add(picItem);
            ((System.ComponentModel.ISupportInitialize)(picItem)).EndInit();
            frmLevel.ResumeLayout(false);
        }

        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            // remove all walls from map (or make them all non enabled or something
            // also execute a battle_screen type popup with a boom that disappears shortly after
        }*/

        public void AI() 
        {
            
        }
    }

    public class WallBoom : IItem
    {
        public string itemName => "Wall Boom";
        
        
        public void InitializeComponent(FrmLevel frmLvl) 
        {
            
        }
        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
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
        }*/

        public void AI()
        {
            
        }
    }

    public class Enemy1Boom: IItem
    {
        public string itemName => "Enemy Boom";
        public void InitializeComponent(FrmLevel frmLvl)
        {

        }

        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
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
        }*/
        public void AI()
        {
            
        }
    }
}
