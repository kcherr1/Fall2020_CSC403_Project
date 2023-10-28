using Fall2020_CSC403_Project.item_system.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.item_system
{
    public class ItemFactory
    {
        public IItem CreateItem(string itemType) 
        {
            switch (itemType) 
            {
                case "HealthPotion":
                    return new HealthPotion();

                case "WallBoom":
                    return new WallBoom();

                case "Enemy1Boom":
                    return new Enemy1Boom();


                default:
                    throw new ArgumentException("invalid item type");
            }
        }
    }
}
