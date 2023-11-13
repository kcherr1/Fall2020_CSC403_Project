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
        public List<string> itemstorage = new List<string>();
        public Dictionary<string, Item> itemDictionary = new Dictionary<string, Item>();
        public bool visible = false;
        private const int padding = 20;

        public Inventory()
        { }

        public Image image { get; set; }

        public int selectedItem { get; set; }

        public int PADDING { get { return padding; } }

        public void addHealthItem(Item item)
        {
            if (!itemstorage.Contains(item.NAME))
            {
                itemstorage.Add(item.NAME);
                itemDictionary.Add(item.NAME, item);
            }
            
        }

        public void removeItem(Item item)
        {
            if (itemstorage.Contains(item.NAME))
            {
                itemstorage.Remove(item.NAME);
                itemDictionary.Remove(item.NAME);
            }
        }

        public void setVisible(bool visible)
        {
            this.visible = visible;
        }

    }
}
