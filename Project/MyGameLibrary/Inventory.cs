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
        public bool visible = false;
        public const int leftPAD = 20;
        public const int rightPAD = 20;
        public const int imagePAD = 20;

        public Inventory()
        { }

        public Image image { get; set; }

        public int LEFTPAD { get { return leftPAD; } }
        public int RIGHTPAD { get { return rightPAD; } }
        public int IMAGEPAD { get { return imagePAD; } }

        public void addItem(Item item)
        {
            if (!itemstorage.Contains(item.NAME))
            {
                itemstorage.Add(item.NAME);
            }
            
        }

        public void removeItem(Item item)
        {
            if (itemstorage.Contains(item.NAME))
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
