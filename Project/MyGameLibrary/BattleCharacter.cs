using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; }
    public int strength { get; protected set; }
    public bool IsAlive { get; protected set; }
    public int experience { get; protected set; }
    public int HealthPackCount { get; protected set; }
    public int WeaponStrength;
    public Boolean WeaponEquiped;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider, int MaxHealth=20) : base(initPos, collider) {
      this.MaxHealth = MaxHealth;
      strength = 0;
      experience = 10;
      Health = MaxHealth;
      IsAlive = true;
      HealthPackCount = 3;
      WeaponStrength = 0;
      WeaponEquiped = false;
    }

    //amount should be a negative number, so subtract strength
    public void OnAttack(int amount) {
      AttackEvent((int)(amount - strength) - WeaponStrength);
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void UseHealthPack() {
      HealthPackCount--;
    }

    public void AlterIsAlive(bool state)
    {
      IsAlive = state;
    }
  }
}
