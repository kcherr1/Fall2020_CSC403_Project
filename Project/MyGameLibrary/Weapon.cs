using System;

namespace Fall2020_CSC403_Project.code{
  public class Weapon : Character{

    public event Action<int> AttackEvent;

    private int strength;

    public Weapon(Vector2 initPos, Collider collider) : base(initPos, collider){
      strength = 0;
    }

    public int getStrength(){
      return strength;
    }

    public void setStrength(int strength){
      this.strength = strength;
    }
  }
}
