using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Fall2020_CSC403_Project;
using MyGameLibrary.Properties;

namespace Fall2020_CSC403_Project.code
{
    public interface Archetype
    {
        string name { get; }
        int baseMaxHealth { get; }
        int baseDefense { get; }
        int baseDamage { get; }
        int baseSpeed { get; }
        int hitMod { get; }
    }

    public class ArchetypeHandler
    {
        private Archetype archetype;

        public ArchetypeHandler(Archetype archetype)
        {
            this.archetype = archetype;
        }
    }

    public class Tank : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }

        public Tank()
        {
            name = "Tank";
            baseMaxHealth = 100;
            baseDefense = 10;
            baseDamage = 2;
            baseSpeed = 0;
            hitMod = 2;
        }
    }

    public class Rogue : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }

        public Rogue()
        {
            name = "Rogue";
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 10;
            baseSpeed = 5;
            hitMod = 5;
        }
    }

    public class Swordsman : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }

        public Swordsman()
        {
            name = "swordsman";
            baseMaxHealth = 50;
            baseDefense = 10;
            baseDamage = 8;
            baseSpeed = 2;
            hitMod = 3;
        }
    }

    public class Minion : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }

        public Minion()
        {
            name = "Minion";
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 2;
            hitMod = 0;
        }
    }

    public class Boss : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }

        public Boss()
        {
            name = "Boss";
            baseMaxHealth = 100;
            baseDefense = 18;
            baseDamage = 10;
            baseSpeed = 5;
            hitMod = 10;
        }

    }
    
}