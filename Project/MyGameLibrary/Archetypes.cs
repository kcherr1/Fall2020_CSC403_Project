namespace Fall2020_CSC403_Project.code
{
    class Archetype
    {
        public Archetype()
        {

        }
    }
    interface PlayerArchetype
    {
        private int maxHealth;
        private int baseDefense;
        private int baseDamage;
        private int baseSpeed;
    }

    class Tank : PlayerArchetype
    {
        private int maxHealth = 100;
        private int baseDefense = 10;
        private int baseDamage = 5;
        private int baseSpeed = 0;

    }

    class Rogue : PlayerArchetype
    {
        private int maxHealth = 20;
        private int baseDefense = 2;
        private int baseDamage = 20;
        private int baseSpeed = 5;
    }

    class Swordsman : PlayerArchetype
    {
        private int maxHealth = 50;
        private int baseDefense = 5;
        private int baseDamage = 10;
        private int baseSpeed = 2;
    }
    
}