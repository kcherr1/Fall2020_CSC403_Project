using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
<<<<<<< Updated upstream
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    private float strength;
=======
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; }
    protected float strength;
    public int Stamina { get; protected set; }
    public int MaxStamina { get; protected set; }
    public int Mana { get; protected set; }
    public int MaxMana { get; protected set; }
    
>>>>>>> Stashed changes

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      MaxStamina = 20;
      MaxMana = 10;
      strength = 2;
      Health = MaxHealth;
      Stamina = MaxStamina;
      Mana = MaxMana;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void AlterStamina(int amount) {
      int i = 0;
      i += amount / strength;
      Stamina += (amount / strength);
    }

    public void AlterMana(int amount) {
      Mana += amount;
    }
  }
}
