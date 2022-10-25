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
	private int experience;
	private int level;

	public event Action<int> AttackEvent;

	public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
	  MaxHealth = 20;
	  strength = 2;
	  experience = 0;
		level = 1;
	  Health = MaxHealth;
	}

	public void OnAttack(int amount) {
	  AttackEvent((int)(amount * strength));
	}

    public void AlterHealth(int amount) {
      Health += amount;
    }

	public void AlterExperience(int amount) {
			experience += amount;
			if (experience >= 100) {
				LevelUp();
			}
	}

	public void LevelUp() {
      MaxHealth += 10;
      Health = MaxHealth;
      strength += 1;
      level += 1;
      experience -= 100;
    }

    // Function set dead character's health to 0
    public void Die()
    {
        Health = 0;
    }
   }
}
