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
    public int Level { get; private set; }
    private float strength;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      Level = 1;
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void LevelUp() {
      Level += 1;
      
      // Level = 1, Strength = 3; Level = 2, Strength = 4
      AlterStrength(Level);
      
      
      // Level = 2, MaxHealth = 30; Level = 3, MaxHealth = 45
      IncreaseMaxHealth(Level);
    }
    
    public void AlterStrength(int amount) { 
      strength += amount;
    }
    
    public void IncreaseMaxHealth(int amount) {
            MaxHealth = MaxHealth + (amount * 5);
    }
  }
}
