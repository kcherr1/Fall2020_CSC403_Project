using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings
// test comment
namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    private float strength;
    // damage mitigation from attacks
    private float toughness;
    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider, float toughness) : base(initPos, collider, toughness) {
      MaxHealth = 50;
      strength = 2;
      this.toughness = toughness;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += (int)(amount * toughness);
    }
  }
}
