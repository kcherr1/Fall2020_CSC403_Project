using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public abstract class InventoryObject
    {
        
        private bool stackable;  // Should multiples of this type stack in a single inventory slot?
        private bool exhaustible;  // Can this object be used more than once?
        private int count;  // How many of this object are in this stack (always 1 if not stackable).
        public Image Img { get; set; } // This will be the inventory icon for this inventory item.

        // Returns how many of this object are in the stack
        public int GetCount()
        {
            return count;
        }

        // Adds addCount to the count
        public void Add(int addCount)
        {
            count += addCount;
        }

        // Removes removeCount from the count.
        // Returns if the operation was successful.
        public bool Remove(int removeCount)
        {
            if(removeCount > GetCount())
            {
                return false;
            }
            count -= Math.Max(count,removeCount);
            return true;
            
        }

        // Returns if this object is stackable
        public bool IsStackable()
        {
            return stackable;
        }

        // Returns if this object is exhaustible.
        // This determines if this object should be
        // destroyed after being used.
        public bool IsExhaustible()
        {
            return exhaustible;
        }

        // Stacks another stackable object with this one.
        public void Stack(InventoryObject other)
        {
            Add(other.GetCount());
        }

        // Returns if another object is an instance of the same class
        // as this one. This is different than the .Equals() or '=='
        // operator in that it doesn't match the specific object or 
        // or values.
        public bool TypeOf(InventoryObject other)
        {
            return (other.GetType() == this.GetType());
        }

        // Returns true if this object is a weapon
        public bool IsWeapon()
        {
            return this is IWeapon;
        }

        // The effect this object has on a battlecharacter.
        // To be implemented in specific inventory objects.
        public abstract void Effect(BattleCharacter character);

        // The effect this object has on a player.
        // To be implemented in specific inventory objects.
        public abstract void Effect(Player player);
    }
}
