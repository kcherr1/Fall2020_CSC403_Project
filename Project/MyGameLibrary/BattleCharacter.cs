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
    private float heavystrength;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      heavystrength = 4;
      Health = MaxHealth;
    }
    //public PoisonBC(Vector2 initPos, Collider collider) : base(initPos, collider) {
      //MaxHealth = 25;
      //strength = 1;
      //heavystrength = 4;
      //Health = MaxHealth;
    //}

    //public CheetoBC(Vector2 initPos, Collider collider) : base(initPos, collider) {
      //MaxHealth = 15;
      //strength = 3;
      //heavystrength = 4;
      //Health = MaxHealth;
    //}

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }
    public void OnHeavyAttack(int amount){
      AttackEvent((int)(amount * heavystrength));
    }
    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void CheetoBC() {
      MaxHealth = 15;
      strength = 3;
      heavystrength = 4;
      Health = MaxHealth;
    }

    public void PoisonBC() {
      MaxHealth = 25;
      strength = 1;
      heavystrength = 4;
      Health = MaxHealth;
    }

    public void BossKoolAidBC() {
      MaxHealth = 40;
      strength = 4;
      heavystrength = 4;
      Health = MaxHealth;
    }


    }
}
