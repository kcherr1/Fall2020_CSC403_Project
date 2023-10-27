using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.item_system.interfaces
{
    public interface IItem
    {
        string Name { get; }
        void ExecuteEffect(Player player, Enemy enemy, List<Wall> walls);

        void RandomlyMove();
        // make the item randomly move
        // look into what makes the picture move..i guess its the picture itself of the enemy
        // So I'll need to add that parameter into randomly move when I figure out where i'll want to call it.
        // TODO: When I create the new item with  IItem newItem = ItemFactory.CreateItem(itemType), use a randomizer
        //  to call different item types..probably requires a giant if elseif elseif thing to switch item type, or no.
        //  I CAN JUST USE THE FACTORY SWITCH!?  case 1: new HealthPotion, etc etc. then have random(1,numItems) -> return to itemType in newItem
        // When to generate the newItem? I guess it can be randomly located on the map, randomly generated based on time/tmr, and randomly destroyed
        //  based on random #secs
    }
}
