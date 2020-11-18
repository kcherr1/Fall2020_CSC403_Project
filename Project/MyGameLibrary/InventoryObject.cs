using Fall2020_CSC403_Project.code;
using System.Drawing;

namespace MyGameLibrary
{
    public abstract class InventoryObject
    {
        
        protected bool _stackable;  // Should multiples of this type stack in a single inventory slot?
        public bool IsStackable { get => _stackable; }
        protected bool _exhaustible;  // Can this object be used more than once?
        public bool IsExhaustible { get => _exhaustible; }
        protected int _count;  // How many of this object are in this stack (always 1 if not stackable).
        public int Count { get => _count; set => _count = value; }
        public Image img; // This will be the inventory icon for this inventory item.
        

        // Adds addCount to the count
        public void Add(int addCount)
        {
            _count += addCount;
        }

        // Removes removeCount from the count.
        // Returns if the operation was successful.
        public bool Remove(int removeCount)
        {
            if(removeCount > _count)
            {
                return false;
            }
            _count -= removeCount;
            return true;
            
        }

        // Stacks another stackable object with this one.
        public void Stack(InventoryObject other)
        {
            Add(other.Count);
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
