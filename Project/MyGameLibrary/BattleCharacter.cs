using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int Armor { get; private set; }
        public int MaxHealth { get; private set; }

    public int MaxArmor { get; private set; }

        private float strength;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
     MaxArmor = 10;
      strength = 2;
      Health = MaxHealth;
      Armor = MaxArmor;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void AlterShield(int amount)
        {
            Armor += amount;
        }
  }
}

