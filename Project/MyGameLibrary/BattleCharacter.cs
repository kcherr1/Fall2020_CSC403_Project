using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    private float strength;
    public int Xp { get; private set; }
    public int XpLevel { get; set; }

    public event Action<int> AttackEvent;
    public event Action<int> HealEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 30;
      strength = 2;
      Health = MaxHealth;
      Xp = 0;
      XpLevel = 1;
    }
    
        // Method to allow the setting of enemy health outside of this class
    public void setHealth(int givenHealth)
        {
            MaxHealth = givenHealth;
            Health = MaxHealth;
        }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void OnHeal(int amount)
        {
            HealEvent((int)(amount));
        }
    

    public void AlterXp(int amount)
        {
            Xp += amount;
        }
    public void AlterHealth(int amount) {
      Health += amount;
    }
  }
}
