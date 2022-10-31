using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class PlayerInventory
    {
        public List<Item> Inventory;

        public PlayerInventory() 
        {
            this.Inventory = new List<Item>();
        }

        public void Add(Item item)
        {
            this.Inventory.Add(item);
        }

        public void Remove(Item item)
        {
            this.Inventory.Remove(item);
        }
    }
}
