using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using static Fall2020_CSC403_Project.code.Entity;

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

        public Inventory(Item Weapon, Item Armor, Item Utility, Item[] Backpack)
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
            return this.Backpack[this.Backpack.Length - 1] != null;
        }

        public void UnEquipWeapon(Position position, Facing facing)
        {
            EquipWeapon(null, position, facing);
        }

        public void UnEquipArmor(Position position, Facing facing)
        {
            EquipArmor(null, position, facing);
        }

        public void UnEquipUtility(Position position, Facing facing)
        {
            EquipUtility(null, position, facing);
        }

        public void EquipWeapon(Item item, Position position, Facing facing)
        {
            Item currently_equipped = this.Weapon;
            if (item.Type == Item.ItemType.Weapon || item == null)
            {
                this.Weapon = item;
                RemoveFromBackpack(item);
                if (BackpackIsFull())
                {
                    DropItem(currently_equipped, position, facing);

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
        public void EquipArmor(Item item, Position position, Facing facing)
        {
            Item currently_equipped = this.Armor;
            if (item.Type == Item.ItemType.Armor || item == null)
            {
                this.Armor = item;
                RemoveFromBackpack(item);
                if (BackpackIsFull())
                {
                    DropItem(currently_equipped, position, facing);
                }
                else
                {
                    AddToBackpack(currently_equipped);
                }
            } else {
                Console.Error.WriteLine("Not armor");
            }
        }
        public void EquipUtility(Item item, Position position, Facing facing)
        {
            Item currently_equipped = this.Utility;
            if (item.Type == Item.ItemType.Utility || item == null)
            {
                this.Utility = item;
                RemoveFromBackpack(item);
                if (BackpackIsFull())
                {
                    DropItem(currently_equipped, position, facing);
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

        public void DropItem(Item item, Position position, Facing facing)
        {
            Position new_position = new Position(position.x, position.y);
            new_position.x = facing == Facing.Left ? new_position.x - 40 : new_position.x + 40;
            item.SetEntityPosition(new_position);
        }

        public void DropAll(Position position)
        {
            Random rnd = new Random();
            Position new_position = position;
            for (int i = 0; i < this.Backpack.Length; i++)
                if (this.Backpack[i] != null)
                {
                    new_position.x = rnd.Next(-40, 40);
                    new_position.y = rnd.Next(-40, 40);
                    this.Backpack[i].SetEntityPosition(new_position);
                    this.Backpack[i] = null;

                }

            new_position.x = rnd.Next(-40, 40);
            new_position.y = rnd.Next(-40, 40);
            this.Weapon.SetEntityPosition(new_position);
            this.Weapon = null;

            new_position.x = rnd.Next(-40, 40);
            new_position.y = rnd.Next(-40, 40);
            this.Armor.SetEntityPosition(new_position);
            this.Armor = null;

            new_position.x = rnd.Next(-40, 40);
            new_position.y = rnd.Next(-40, 40);
            this.Utility.SetEntityPosition(new_position);
            this.Utility = null;

        }
    }

}
