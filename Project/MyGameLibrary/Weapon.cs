using System;

public class Weapon : Character {

  public event Action<int> AttackEvent;

  private float strength;

  public Weapon(Vector2 initPos, Collider collider) : base(initPos, collider){
    strength = 1;
  }
    
  public float getStrength(){
    return strength;
  }

  public void setStrength(float strength){
    this.strength = strength;
  }
}
