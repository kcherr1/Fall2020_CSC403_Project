using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public float strength { get; protected set; }
        public float evasion { get; protected set; }
        public float defense { get; protected set; }
        public event Action<int> AttackEvent;


        public BattleCharacter(Vector2 initPos, Collider collider, float strength, float evasion, float defense) : base(initPos, collider)
        {
            MaxHealth = 20;
            this.strength = strength;
            this.evasion = evasion;
            this.defense = defense;
            Health = MaxHealth;
        }

        public void OnAttack(int amount)
        {
            float stdev = Util.GetRandomFloat();
            int deviation = Util.GetRandomInt();
            
            AttackEvent(CalculateAttack());
        }

        public int CalculateAttack()
        {
            float stdev = Util.GetRandomFloat();
            int deviation = Util.GetRandomInt();
            int baseDamage = 2;

            if (stdev > 0.845f) baseDamage++;
            if (stdev > 0.975f) baseDamage++;
            if (stdev < 0.155f) baseDamage--;

            int damage = (int)(strength * baseDamage) + deviation;
            return Math.Max(damage, (int)strength); 
        }

        public bool checkEvade()
        {
            float baseEvadeChance = 0.075f;
            float adjustedEvadeChance = baseEvadeChance + 0.0075f * evasion;
            return Util.GetRandomFloat() < adjustedEvadeChance;
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
        }

        public void DamageHealth(int amount)
        {
            if (checkEvade())
            {
                Console.WriteLine("dodged");
                return;
            }
            int damage = Math.Max(amount - (int)defense,1);
            AlterHealth(-damage);

        }
    }
}
