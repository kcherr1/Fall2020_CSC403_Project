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
        int archetypeDamage { get; }
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
        public int archetypeDamage { get; }

        public Tank()
        {
            baseMaxHealth = 100;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 0;
            archetypeDamage = 5;
        }
    }

    public class Rogue : PlayerArchetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int archetypeDamage { get; }

        public Rogue()
        {
            baseMaxHealth = 20;
            baseDefense = 2;
            baseDamage = 20;
            baseSpeed = 5;
            archetypeDamage = 10;
        }
    }

    public class Swordsman : PlayerArchetype
    {
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int archetypeDamage { get; }

        public Swordsman()
        {
            baseMaxHealth = 50;
            baseDefense = 5;
            baseDamage = 8;
            baseSpeed = 2;
            archetypeDamage = 8;
        }
    }
    
}