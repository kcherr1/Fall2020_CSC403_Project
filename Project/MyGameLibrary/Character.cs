using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
	public class Character : Entity
	{

		public event Action<int> AttackEvent;

		public String name { get; private set; }

		public PlayerArchetype archetype;
		
		public int defense;

		public int damage;

		public int speed;

		public int Health { get; private set; }
		public int MaxHealth { get; private set; }

		public Character(Position initPos, Collider collider, PlayerArchetype archetype) : base(initPos, collider)
		{
			this.archetype = archetype;
			this.MaxHealth = archetype.baseMaxHealth;
            this.damage = archetype.baseDamage;
            this.defense = archetype.baseDefense;
            this.speed = archetype.baseSpeed;
            this.Health = MaxHealth;
		}

		public void setArchetype(PlayerArchetype newArchetype)
		{
			this.archetype = newArchetype;
		}
		
		public void OnAttack(int amount)
		{
			AttackEvent((int)(amount * damage));
		}

		public void AlterHealth(int amount)
		{
			Health += amount;
		}
	}
}
