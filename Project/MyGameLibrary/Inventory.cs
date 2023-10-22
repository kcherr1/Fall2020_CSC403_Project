using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Inventory
    {
        private Dictionary<string, Item> itemstorage = new Dictionary<string, Item>();
        public bool visible = false;

        public Inventory()
        { }

        public Image image { get; set; }

        public void addItem(Item item)
        {
            itemstorage.Add(item.NAME, item);
        }

        public void removeItem(Item item)
        {
            if (itemstorage.ContainsKey(item.NAME))
            {
                itemstorage.Remove(item.NAME);
            }
        }

        public void setVisible(bool visible)
        {
            this.visible = visible;
        }
    }
}
