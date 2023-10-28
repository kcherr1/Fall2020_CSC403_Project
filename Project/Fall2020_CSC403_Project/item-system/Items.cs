using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.item_system.interfaces;

namespace Fall2020_CSC403_Project.item_system
{
    public class HealthPotion : IItem
    {
        public string Name => "Health Potion";
        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            player.Health += 10;
            if (player.Health >= player.MaxHealth)
            {
                player.Health = player.MaxHealth;
            }
        }*/

        public void RandomlyMove() 
        {
            
        }
    }

    public class WallBoom : IItem
    {
        public string Name => "Wall Boom";
       /* public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            // remove all walls from map (or make them all non enabled or something
            // also execute a battle_screen type popup with a boom that disappears shortly after
        }*/
        public void RandomlyMove()
        {
            
        }
    }

    public class Enemy1Boom: IItem
    {
        public string Name => "Enemy Boom";
        /*public void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls)
        {
            // remove enemy 1 from map
        }*/

        public void RandomlyMove()
        {
            
        }
    }
}
