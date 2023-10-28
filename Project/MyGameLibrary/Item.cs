using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGameLibrary;
using Fall2020_CSC403_Project.code;
using System.Drawing;
using System.Windows.Forms;

namespace MyGameLibrary
{
    public class Item : Entity
    {
        public int Stat { get; private set; }
        public ItemType Type { get; private set; }

        public Color Color { get; set; }


        public Item(string Name, PictureBox Pic, int Stat, ItemType Type, Position initPos, Collider collider) : base(Name, Pic, initPos, collider)
        {
            this.Stat = Stat;
            this.Type = Type;
        }

        public Item(string Name, PictureBox Pic, int Stat, ItemType Type) : base(Name, Pic)
        {
            this.Stat = Stat;
            this.Type = Type;
        }


        public enum ItemType
        {
            Weapon,
            Armor,
            Utility
        }
    }



}
