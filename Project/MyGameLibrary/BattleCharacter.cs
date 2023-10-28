using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
<<<<<<< HEAD
    public int Health { get; set; }
    public int MaxHealth { get; private set; }
    private float strength;
=======
    public int Health;
    public int MaxHealth;
    public float strength;
>>>>>>> 9a002a9a36abae29cdf7f1ef25e92cb8bd7c92ab

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
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
  }
}
