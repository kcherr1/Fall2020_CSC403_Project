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
    public class HealthPotion : IItem
    {
        public string itemName => "Health Potion";

        public System.Windows.Forms.PictureBox picItem;
        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            player.Health += 10;
            if (player.Health >= player.MaxHealth)
            {
                player.Health = player.MaxHealth;
            }
        }*/

        public HealthPotion(FrmLevel frmLevel) 
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
            // remove enemy 1 from map
        }*/
        public void AI()
        {
            
        }
    }
}
