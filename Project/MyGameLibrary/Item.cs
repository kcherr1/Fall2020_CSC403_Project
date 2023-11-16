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
        public string Desc { get; private set; }
        public ItemType Type { get; private set; }

        public EffectType Potion { get; private set; }

        public WeaponType Weapon_Type { get; private set; }


        public Item(string Name, PictureBox Pic, int Stat, ItemType Type, string desc) : base(Name, Pic)
        {
            this.Stat = Stat;
            this.Type = Type;
            this.Desc = desc;
            Pic.Size = new Size(50, 50);
        }

        public Item(string Name, PictureBox Pic, int Stat, ItemType Type, EffectType Potion, string desc) : base(Name, Pic)
        {
            this.Stat = Stat;
            this.Type = Type;
            this.Potion = Potion;
            this.Desc= desc;
            Pic.Size = new Size(50, 50);
        }

        public Item(string Name, PictureBox Pic, int Stat, ItemType Type, WeaponType Weapon_Type, string desc) : base(Name, Pic)
        {
            this.Stat = Stat;
            this.Type = Type;
            this.Weapon_Type = Weapon_Type;
            this.Desc = desc;
            Pic.Size = new Size(50, 50);
        }

        public enum ItemType
        {
            Weapon,
            Armor,
            Utility
        }

        public enum WeaponType
        {
            Sword,
            Dagger,
            War,
            Fist,
            Spear,
            Any,
            None
        }

        public enum EffectType
        {
            Healing,
            Speed,
            Strength,
            Accuracy
        }


    }



}
