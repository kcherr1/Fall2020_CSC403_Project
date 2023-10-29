using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;
using System.Runtime.Remoting.Messaging;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class Character : Entity
    {

        public event Action<int> AttackEvent;

		public Inventory Inventory { get; set; }

		public PlayerArchetype archetype;
		
		public int defense;

		public int damage;

		public int speed;

		public int Health { get; private set; }
		public int MaxHealth { get; private set; }


		public Character(string Name, PictureBox Pic, PlayerArchetype archetype) : base(Name, Pic)
		{
            this.archetype = archetype;
			this.MaxHealth = archetype.baseMaxHealth;
            this.damage = archetype.baseDamage;
            this.defense = archetype.baseDefense;
            this.speed = archetype.baseSpeed;
            this.Health = MaxHealth;
			this.Inventory = new Inventory();
        }
		
		public void OnAttack(int amount)
		{
			AttackEvent((int)(amount * damage));
		}

        public void AlterHealth(int amount)
        {
            Health += amount;
        }

        public void RestoreHealth()
        {
            this.Health = this.MaxHealth;
        }
        
    }
}
