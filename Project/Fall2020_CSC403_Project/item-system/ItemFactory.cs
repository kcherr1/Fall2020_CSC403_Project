using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.item_system.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.item_system
{
    public class ItemFactory
    {
        int NUM_ITEMS = 0;
        public IItem GetItem(string itemType, FrmLevel frmLevel, int locationX, int locationY)
        {

            switch (itemType) 
            {
                case "RandomPotion":
                    NUM_ITEMS += 1;
                    return new RandomPotion(frmLevel, NUM_ITEMS, locationX, locationY);

                /*case "WallBoom":
                    return new WallBoom();

                case "Enemy1Boom":
                    return new Enemy1Boom();*/


                default:
                    throw new ArgumentException("invalid item type");
            }



        }

        public Vector2 CreatePosition(PictureBox pic)
        {
            return new Vector2(pic.Location.X, pic.Location.Y);
        }

        public Collider CreateCollider(PictureBox pic, int padding)
        {
            Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
            return new Collider(rect);
        }

    }
}
