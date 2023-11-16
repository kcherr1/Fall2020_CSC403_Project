using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;
using System.Runtime.Remoting.Messaging;
using static MyGameLibrary.Item;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class Character : Entity
    {

        public event Action<Character,int> AttackEvent;

		public Inventory Inventory { get; set; }

		public Archetype archetype;
		
		public int defense;

		public int damage;

		public int speed;

		public int hit_mod;

		public Random dice;

		public int Health { get; private set; }
		public int MaxHealth { get; private set; }


		public Character(string Name, PictureBox Pic, Archetype archetype) : base(Name, Pic)
		{
            this.archetype = archetype;
			this.MaxHealth = archetype.baseMaxHealth;
            this.damage = archetype.baseDamage;
            this.defense = archetype.baseDefense;
            this.speed = archetype.baseSpeed;
            this.Health = MaxHealth;
			this.Inventory = new Inventory();
			this.dice = new Random();
			this.hit_mod = archetype.hitMod;
		}
		
		public string OnAttack(Character target)
		{
            int hit = this.dice.Next(1, 21);
			string log;
			int damage;
            if (hit == 20)
			{
				damage = this.damage * 2 + this.dice.Next(1, this.archetype.baseDamage + 1);
                AttackEvent(target, damage);
				log = this.Name + " criticaly hit " + target.Name + " for " + damage + "!";
			}
            else if (hit + this.hit_mod >= target.defense)
			{
				damage = this.damage + this.dice.Next(1, this.archetype.baseDamage + 1);
                AttackEvent(target, damage);
                log = this.Name + " hits " + target.Name + " for " + damage;
            }
			else
			{
				log = this.Name + " missed!";
			}
			return log;
        }

        public void TakeDamage(int amount)
		{
			Health -= amount;
		}

		public void GiveHealth(int amount)
        {
            Health += amount;
        }


		public void UpdateStats()
		{
			if (this.Inventory.Armor != null)
			{
                this.defense = this.archetype.baseDefense + this.Inventory.Armor.Stat;

            } else
			{
				this.defense = this.archetype.baseDefense;
			}

			if (this.Inventory.Weapon != null)
			{
				if (this.Inventory.Weapon.Weapon_Type == this.archetype.Weapon_Type || this.archetype.Weapon_Type == WeaponType.Any)
				{
                    this.damage = this.archetype.baseDamage + this.Inventory.Weapon.Stat;
                } else
				{
                    this.damage = this.archetype.baseDamage + this.Inventory.Weapon.Stat / 2;
                }
            } else
			{
				this.damage = this.archetype.baseDamage;
			}
        }

		public void ApplyEffect(EffectType Potion, int stat)
		{
			switch (Potion)
			{
				case EffectType.Healing:
					this.Health += stat;
					if (this.Health > this.MaxHealth)
					{
						this.Health = this.MaxHealth;
					}
					break;
				case EffectType.Strength:
					this.damage += stat;
					break;
				case EffectType.Speed:
					this.speed += stat;
					break;
				case EffectType.Accuracy:
					this.hit_mod += stat;
					break;
				default:
					break;
			}
		}

		public void RemoveEffect()
		{
			this.damage = this.archetype.baseDamage;
			this.speed = this.archetype.baseSpeed;
			this.hit_mod = this.archetype.hitMod;
		}
        
    }
}
