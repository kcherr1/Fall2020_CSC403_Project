using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Inventory
    {
        public Item weapon { get; private set; }
        public Item armor { get; private set; }
        public Item utility { get; private set; }


        public Item[] backpack;

        
        public Inventory()
        {
            this.backpack = new Item[6];
        }

        public Inventory(Item weapon, Item armor, Item utility, Item[] backpack)
        {
            this.weapon = weapon;
            this.armor = armor;
            this.utility = utility;
            if (backpack != null)
            {
                if (backpack.Length <= 6)
                {
                    this.backpack = backpack;
                } else
                {
                    throw new Exception("Backpack size limited to 6 Items");
                }
            } else
            {
                this.backpack = new Item[6];
            }
        }

        public void addToBackpack (Item item)
        {
            this.backpack = this.backpack.Append(item).ToArray();
            Console.WriteLine(this.backpack);
        }



    }
}
