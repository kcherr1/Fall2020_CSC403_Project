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
            int deviation = Util.GetRandomInt();
            AttackEvent((int) Math.Max(strength+deviation,1)*(-1));
        }

        public void AlterHealth(int amount)
        {
            Health += amount;
        }
    }
}
