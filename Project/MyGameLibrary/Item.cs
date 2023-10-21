using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGameLibrary;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary
{
    public class Item : Entity
    {
        public int Stat { get; private set; }
        public ItemType Type { get; private set; }

        public Item(int Stat, ItemType Type, string Name, Position initPos, Collider collider) : base(Name, initPos, collider)
        {
            this.Stat = Stat;
            this.Type = Type;
        }

        public Item(string Name, int Stat, ItemType Type) : base(Name)
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
