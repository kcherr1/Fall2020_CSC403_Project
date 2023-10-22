using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;
using MyGameLibrary;

namespace MyGameLibrary
{
    public class Inventory
    {
        public Item Weapon { get; private set; }
        public Item Armor { get; private set; }
        public Item Utility { get; private set; }
        public Item[] Backpack { get; private set; }

        
        public Inventory()
        {
            this.Backpack = new Item[9];
        }

        public Inventory(Item Weapon, Item Armor, Item tility, Item[] Backpack)
        {
            this.Weapon = Weapon;
            this.Armor = Armor;
            this.Utility = Utility;
            if (Backpack != null)
            {
                if (Backpack.Length <= 9)
                {
                    this.Backpack = Backpack;
                } else
                {
                    throw new Exception("Backpack size limited to 6 Items");
                }
            } else
            {
                this.Backpack = new Item[9];
            }
        }

        public bool BackpackIsFull(){
            return this.Backpack[this.Backpack.Length - 1] == null;
        }

        public void EquipWeapon(Item item)
        {
            Item currently_equipped = this.Weapon;
            if (item.Type == Item.ItemType.Weapon)
            {
                this.Weapon = item;
                RemoveFromBackpack(item);
                if (BackpackIsFull())
                {
                    // Drop(currently_equipped, player position);
                } else
                {
                    AddToBackpack(currently_equipped);
                }
            }
            else
            {
                Console.Error.WriteLine("Not a weapon");
            }
        }
        public void EquipArmor(Item item)
        {
            Item currently_equipped = this.Armor;
            if (item.Type == Item.ItemType.Armor)
            {
                this.Armor = item;
                RemoveFromBackpack(item);
                if (BackpackIsFull())
                {
                    // Drop(currently_equipped, player position)
                }
                else
                {
                    AddToBackpack(currently_equipped);
                }
            } else {
                Console.Error.WriteLine("Not armor");
            }
        }
        public void EquipUtility(Item item)
        {
            Item currently_equipped = this.Utility;
            if (item.Type == Item.ItemType.Utility)
            {
                this.Utility = item;
                RemoveFromBackpack(item);
                if (BackpackIsFull())
                {
                    // Drop(currently_equipped, player position)
                }
                else
                {
                    AddToBackpack(currently_equipped);
                }
            } else {
                Console.Error.WriteLine("Not a utility");
            }
        }

        public void AddToBackpack(Item item)
        {
            var inserted = false;
            for (int i = 0; i < this.Backpack.Length; i++)
            {
                if (this.Backpack[i] == null)
                {
                    this.Backpack[i] = item;
                    inserted = true;
                    break;
                }
            }
            if (!inserted)
            {
                Console.Error.Write("Could not insert. Array Limited to 9 items");
            }

        }

        public void RemoveFromBackpack(Item item)
        {
            int index = -1;
            if (this.Backpack[this.Backpack.Length - 1] == item)
            {
                index = this.Backpack.Length - 1;
            } else {
                for (int i = 0; i < this.Backpack.Length - 1; i++)
                {
                    if (this.Backpack[i] == item)
                    {
                        index = i;
                        break;
                    }
                }
            }
            if (index > 0)
            {
                RemoveFromBackpack(index);
            } else {
                Console.Error.WriteLine("Item not in Backpack");
            }
        }

        public void RemoveFromBackpack(int index)
        {
            if (index == this.Backpack.Length - 1)
            {
                this.Backpack[index] = null;
                return;
            } 
            for (int i = index; i < this.Backpack.Length - 1; i++)
            {
                this.Backpack[i] = this.Backpack[i + 1];
            }
        }

        public void Drop(Item item, Position position)
        {
            // todo, create item at player position outside of collision range
        }


    }
}
