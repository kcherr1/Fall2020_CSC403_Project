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
		public int ExperienceOnDeath { get; set; }
		public int ExperienceToLevel { get; set; }

		public int CurrentLevel { get; set; }

    private float strength;

    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
			ExperienceOnDeath = GenerateExperience();
			ExperienceToLevel = 100;
			CurrentLevel = 1;
    }

		// Enemies will have a random experience to give on death
		public int GenerateExperience() {
			Random ran = new Random();
			return ran.Next(60, 140);
		}

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }
  }
}
