using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using Fall2020_CSC403_Project;
using MyGameLibrary.Properties;
using static MyGameLibrary.Item;

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
        string opener { get; }

        WeaponType Weapon_Type { get; }

        
        void specialMove(Character target);


    }

    public class ArchetypeHandler
    {
        private Archetype archetype;

        public ArchetypeHandler(Archetype archetype)
        {
            this.archetype = archetype;
        }

    }

    // Player Archetypes
    public class Tank : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Tank()
        {
            name = "Tank";
            baseMaxHealth = 100;
            baseDefense = 14;
            baseDamage = 2;
            baseSpeed = 0;
            hitMod = 2;
            Weapon_Type = WeaponType.War;
        }

        public void specialMove(Character target) { }

    }

    public class Rogue : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get;  }

        public Rogue()
        {
            name = "Rogue";
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 10;
            baseSpeed = 5;
            hitMod = 5;
            Weapon_Type = WeaponType.Dagger;
        }

        public void specialMove(Character target)
        {
        }

    }

    public class Swordsman : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Swordsman()
        {
            name = "Swordsman";
            baseMaxHealth = 50;
            baseDefense = 12;
            baseDamage = 8;
            baseSpeed = 2;
            hitMod = 3;
            Weapon_Type = WeaponType.Sword;
        }

        public void specialMove(Character target) { }


    }

    // NPC Archetypes
    public class Healer : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }

        public WeaponType Weapon_Type { get; }

        public Healer()
        {
            name = "Healer";
            baseMaxHealth = 25;
            baseDefense = 10;
            baseDamage = 3;
            baseSpeed = 2;
            hitMod = 3;
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target)
        {
            target.GiveHealth(target.dice.Next(1, 8) + this.hitMod);
        }

    }

    public class Tombstone : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Tombstone()
        {
            name = "Tombstone";
            baseMaxHealth = 30;
            baseDefense = 10;
            baseDamage = 3;
            baseSpeed = 3;
            hitMod = 3;
            opener = "I have to do this";
            Weapon_Type = WeaponType.Spear;
        }

        public void specialMove(Character target) { }
    }

    public class Gerald : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }

        public WeaponType Weapon_Type { get; }

        public Gerald()
        {
            name = "Gerald";
            baseMaxHealth = 100;
            baseDefense = 0;
            baseDamage = 20;
            baseSpeed = 0;
            hitMod = -1;
            Weapon_Type = WeaponType.Fist;
        }
        public void specialMove(Character target) { }
    }

    public class Guy : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Guy()
        {
            name = "Guy";
            baseMaxHealth = 10;
            baseDefense = 0;
            baseDamage = 1;
            baseSpeed = 1;
            hitMod = 0;
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target) { }
    }

    // Enemy Archetypes
    public class Minion : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Minion()
        {
            name = "Minion";
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 1;
            hitMod = 0;
            opener = "*Unintelligible hissing*";
            Weapon_Type = WeaponType.Fist;
        }

        public void specialMove(Character target) { }


    }

    public class Coward : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Coward()
        {
            name = "Coward";
            baseMaxHealth = 20;
            baseDefense = 10;
            baseDamage = 2;
            baseSpeed = 5;
            hitMod = 0;
            opener = "You'll regret this... No you won't I'm running away!";
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target) { }


    }

    public class Brute : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Brute()
        {
            name = "Brute";
            baseMaxHealth = 45;
            baseDefense = 12;
            baseDamage = 3;
            baseSpeed = 1;
            hitMod = 1;
            opener = "*Unintelligible Lizard Noises*";
            Weapon_Type = WeaponType.Fist;
        }

        public void specialMove(Character target) { }

    }

    public class Zombie : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }

        public WeaponType Weapon_Type { get; }
        public Zombie()
        {
            name = "Zombie";
            baseMaxHealth = 50;
            baseDefense = 7;
            baseDamage = 1;
            baseSpeed = 2;
            hitMod = 1;
            opener = "*Growling noises* (Hey, how is your day?)";
            Weapon_Type = WeaponType.Fist;
        }

        public void specialMove(Character target) { }

    }

    public class Bees : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Bees()
        {
            name = "Bees";
            baseMaxHealth = 10;
            baseDefense = 18;
            baseDamage = 1;
            baseSpeed = 5;
            hitMod = 5;
            opener = "BZZZZZZZZZZZZ";
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target) { }

    }

    public class Mage : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Mage()
        {
            name = "Mage";
            baseMaxHealth = 35;
            baseDefense = 10;
            baseDamage = 7;
            baseSpeed = 3;
            hitMod = 3;
            opener = "The Lizard Wizards shall reign supreme!";
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target) { }

    }

    public class Whelp : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }
        public WeaponType Weapon_Type { get; }

        public Whelp()
        {
            name = "Whelp";
            baseMaxHealth = 50;
            baseDefense = 8;
            baseDamage = 3;
            baseSpeed = 3;
            hitMod = 3;
            opener = "For our Dragon King!";
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target) { }

    }

    public class Boss : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }

        public WeaponType Weapon_Type { get; }

        public Boss()
        {
            name = "Boss";
            baseMaxHealth = 65;
            baseDefense = 15;
            baseDamage = 10;
            baseSpeed = 5;
            hitMod = 6;
            opener = "I am boss";
            Weapon_Type = WeaponType.Any;
        }

        public void specialMove(Character target) { }

    }

    public class Dragon : Archetype
    {
        public string name { get; }
        public int baseMaxHealth { get; }
        public int baseDefense { get; }
        public int baseDamage { get; }
        public int baseSpeed { get; }
        public int hitMod { get; set; }
        public string opener { get; }

        public WeaponType Weapon_Type { get; }

        public Dragon()
        {
            name = "Dragon";
            baseMaxHealth = 200;
            baseDefense = 20;
            baseDamage = 20;
            baseSpeed = 2;
            hitMod = 10;
            opener = "*Unintelligible dragon noises*";
            Weapon_Type = WeaponType.None;
        }

        public void specialMove(Character target) { }

    }
}