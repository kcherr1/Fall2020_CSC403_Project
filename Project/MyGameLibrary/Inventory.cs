using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Inventory
    {
        private int maxInventorySize = 8; // Max number of inventory slots, defaults to 8.
        private InventoryObject[] inventory; // List storing the inventory.

        // Constructor with no arguements.
        public Inventory()
        {
            inventory = new InventoryObject[maxInventorySize];
        }

        // Inventory constructor with passed List of InventoryObjects
        public Inventory(int maxInventorySize,List<InventoryObject> invObjs)
        {
            inventory = new InventoryObject[maxInventorySize];
            this.maxInventorySize = maxInventorySize;
            for (int i = 0; i < invObjs.Count && i < maxInventorySize; i++)
            {
                inventory[i] = invObjs[i];
            }
        }

        // Inventory constructor with passed array of InventoryObjects
        public Inventory(int maxInventorySize, InventoryObject[] invObjs)
        {
            inventory = new InventoryObject[maxInventorySize];
            this.maxInventorySize = maxInventorySize;
            for (int i = 0; i < invObjs.Length && i < maxInventorySize; i++)
            {
                inventory[i] = invObjs[i];
            }
        }

        public int GetMaxInventorySize()
        {
            return maxInventorySize;
        }

        // Returns the inventory as a List
        public InventoryObject[] GetInventory()
        {
            return inventory;
        }

        // Adds an InventoryObject to the inventory.
        // Returns if the addition was successful.
        public Boolean AddToInventory(InventoryObject iObj)
        {
            // Checks if the object is stackable
            if (iObj.IsStackable())
            {
                int index = ObjectTypeExistsInInventory(iObj);
                if(index != -1)
                {
                    // If the object is stackable and exists in the inventory,
                    // add it to the existing stack.
                    inventory[index].Stack(iObj);
                    return true;
                }
            }
            // Checks if inventory is full, if not, the object is added.
            for(int i = 0; i < maxInventorySize; i++)
            {
                if(inventory[i] == null)
                {
                    inventory[i] = iObj;
                    return true;
                }
            }

            // There are no empty spaces in the inventory.
            return false;
        }

        // Adds an InventoryObject implementing the IWeapon interface to the inventory.
        // Returns if the addition was successful or not.
        public Boolean AddToInventory(IWeapon iWep)
        {
            // Checks if the passed IWeapon object
            // is an instance of InventoryObject.
            InventoryObject iObj = null;
            if(iWep is InventoryObject)
            {
                iObj = (InventoryObject)iWep;
            }
            else
            {
                // The passed IWeapon is not an InventoryObject.
                return false;
            }
            // Checks if the object is stackable
            if (iObj.IsStackable())
            {
                int index = ObjectTypeExistsInInventory(iObj);
                if (index != -1)
                {
                    // If the object is stackable and exists in the inventory,
                    // add it to the existing stack.
                    inventory[index].Stack(iObj);
                    return true;
                }
            }
            // Checks if inventory is full, if not, the object is added.
            for (int i = 0; i < maxInventorySize; i++)
            {
                if (inventory[i] == null)
                {
                    inventory[i] = iObj;
                    return true;
                }
            }

            // There are no empty spaces in the inventory.
            return false;
        }

        // Returns the index of the given object type (matches the passed
        // object's class) in the inventory.
        private int ObjectTypeExistsInInventory(InventoryObject iObj)
        {
            for(int i = 0; i< maxInventorySize;i++)
            {
                if (inventory[i] != null)
                {
                    if (inventory[i].TypeOf(iObj))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        // Returns object in inventory at index without removing it.
        public InventoryObject GetInventoryObject(int index)
        {
            //Console.WriteLine("\t" + index.ToString());
            if (index < inventory.Count())
            {
                //Console.WriteLine("\t" + inventory[index].GetType());
                return (inventory[index]);
            }
            else
            {
                return null;
            }
        }

        // Removes an object at index from the inventory
        public void RemoveInventoryObject(int index)
        {
            if(index < maxInventorySize)
            {
                inventory[index] = null;
            }
        }

        // Removes the given object from the inventory
        public void RemoveInventoryObject(InventoryObject iObj)
        {
            for(int i = 0; i < maxInventorySize; i++)
            {
                if(iObj == inventory[i])
                {
                    inventory[i] = null;
                }
            }
        }

        public void UseInventoryObject(int index, Player player)
        {
            InventoryObject iObj = GetInventoryObject(index);
            if(iObj == null)
            {
                return;
            }
            iObj.Effect(player);
            if (iObj.IsExhaustible())
            {
                if (iObj.IsStackable())
                {
                    if(iObj.GetCount() <= 0)
                    {
                        RemoveInventoryObject(index);
                    }
                }
                else
                {
                    RemoveInventoryObject(index);
                }
            }

        }

        // Finds all items in inventory that implement IWeapon
        public List<IWeapon> GetWeapons()
        {
            List<IWeapon> weapons = new List<IWeapon>();
            foreach(InventoryObject io in inventory)
            {
                if (io.IsWeapon())
                {
                    weapons.Add((IWeapon)io);
                }
            }
            return (weapons);
        }
    }
}
