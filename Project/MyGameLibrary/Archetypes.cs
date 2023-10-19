using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    interface PlayerArchetype
    {
        private int maxHealth;
        private int baseDefense;
        private int baseDamage;
        private int baseSpeed;
    }

    class Tank : PlayerArchetype
    {
        private int maxHealth  { get; private set; }
        private int baseDefense  { get; private set; }
        private int baseDamage  { get; private set; }
        private int baseSpeed  { get; private set; }

        public Tank()
        {
            maxHealth = 100;
            baseDefense = 10;
            baseDamage = 5;
            baseSpeed = 0;
        }
    }

    class Rogue : PlayerArchetype
    {
        private int maxHealth { get; private set; }
        private int baseDefense { get; private set; }
        private int baseDamage { get; private set; }
        private int baseSpeed { get; private set; }

        public Rogue()
        {
            maxHealth = 20;
            baseDefense = 2;
            baseDamage = 10;
            baseSpeed = 5;
        }
    }

    class Swordsman : PlayerArchetype
    {
        private int maxHealth { get; private set; }
        private int baseDefense { get; private set; }
        private int baseDamage { get; private set; }
        private int baseSpeed { get; private set; }

        public Swordsman()
        {
            maxHealth = 50;
            baseDefense = 5;
            baseDamage = 10;
            baseSpeed = 2;
        }
    }
    
}