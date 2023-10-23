using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
	public class Character : Entity
	{

		public event Action<int> AttackEvent;

		public String name { get; private set; }
		// archetype here
		// touchness here
		// damage here
		private float strength; // replace with damage
								// inventory here
		public int Health { get; private set; }
		public int MaxHealth { get; private set; }

		public Character(Position initPos, Collider collider, PictureBox pic) : base(initPos, collider, pic)
		{
			MaxHealth = 20;
			strength = 2;
			Health = MaxHealth;
		}
		
		public void OnAttack(int amount)
		{
			AttackEvent((int)(amount * strength));
		}

		public void AlterHealth(int amount)
		{
			Health += amount;
		}
	}
}
