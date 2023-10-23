using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using MyGameLibrary;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class Character : Entity {
        
        public event Action<int> AttackEvent;

        // archetype here
        // toughness here
        private float strength; // replace with damage
        public Inventory Inventory { get; set; }

        public int Health { get; private set; }
        public int MaxHealth { get; private set; }

        public Character(string Name, Position initPos, Collider collider) : base(Name, initPos, collider) {
            // set archetype
            Inventory = new Inventory(); // fill in inventory based on archetype

            MaxHealth = 20; // get from archetype
            strength = 2; // get from archetype + weapon 
            Health = MaxHealth;
            
        }

        public Character(string Name) : base(Name) {
            Inventory = new Inventory(); // fill in inventory based on archetype

            MaxHealth = 20; // get from archetype
            strength = 2; // get from archetype + weapon 
            Health = MaxHealth;
        }

        public void OnAttack(int amount) {
            AttackEvent((int)(amount * strength));
        }

        public void AlterHealth(int amount) {
            Health += amount;
        }
        
    }
}
