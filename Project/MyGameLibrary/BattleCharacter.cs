using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code 
{
    public class BattleCharacter : Character 
    {
        public int Health { get; set; }
        public int MaxHealth { get; private set; }
        private float strength;
        private float heal_strength;

        public event Action<int> AttackEvent;
        public event Action<int> HealEvent;

        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) 
        {

            MaxHealth = 20;
            strength = 1;
            heal_strength = 1;
            Health = MaxHealth;
        }

        public void OnAttack(int amount) 
        {
            AttackEvent((int)(amount * strength));
            
        }

        public void OnHeal(int amount)
        {
            HealEvent((int)(amount * heal_strength));
        }

        public void AlterHealth(int amount) 
        {
            Health += amount;
        }
    }
}
