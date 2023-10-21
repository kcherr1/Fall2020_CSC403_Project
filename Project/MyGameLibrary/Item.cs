using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary
{
    public class Item : Entity
    {
        public int stat { get; private set; }
        public ItemType type { get; private set; }

        public Item(int stat, ItemType type, string Name, Position initPos, Collider collider) : base(Name, initPos, collider)
        {
            this.stat = stat;
            this.type = type;
        }

        public enum ItemType
        {
            Weapon,
            Armor,
            Utility
        }
    }



}
