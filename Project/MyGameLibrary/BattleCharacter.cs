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
    public int HealthPackCount { get; private set; }
    public int WeaponStrength;
    public Boolean WeaponEquiped;
    private float strength;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      HealthPackCount = 3;
      WeaponStrength = 0;
      WeaponEquiped = false;
      Health = MaxHealth;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength) - WeaponStrength);
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void UseHealthPack(){
      HealthPackCount--;
    }
  }
}
