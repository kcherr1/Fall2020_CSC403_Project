using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Fall2020_CSC403_Project.code
{
    public interface PlayerArchetype
    {
        int baseMaxHealth { get; }
        int baseDefense { get; }
        int baseDamage { get; }
        int baseSpeed { get; }
    }

    public class Archetype
    {
        private PlayerArchetype archetype;

        public Archetype(PlayerArchetype archetype)
        {
            this.archetype = archetype;
        }
    }

    public class Tank : PlayerArchetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }

        public Tank()
        {
            baseMaxHealth = 100;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 0;
        }
    }

    public class Rogue : PlayerArchetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }

        public Rogue()
        {
            baseMaxHealth = 20;
            baseDefense = 2;
            baseDamage = 10;
            baseSpeed = 5;
        }
    }

    public class Swordsman : PlayerArchetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }

        public Swordsman()
        {
            baseMaxHealth = 50;
            baseDefense = 5;
            baseDamage = 10;
            baseSpeed = 2;
        }
    }
    
}