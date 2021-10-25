// This class is the superclass of enemy and player classes

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

    // ???? wtf is this?
    // This is the variable for dynamically be applied to the health of the enemy or player
    // dumb as shit
    public event Action<int> AttackEvent;

    // The constructor for the BattleCharacter class
    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
    }

    // Method for how much damage you apply to alter the health of the BattleCharacter
    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    // Method for decreasing the health of the BattleCharacter
    public void AlterHealth(int amount) {
      Health += amount;
    }
  }
}
