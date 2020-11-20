﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code
{
    public class BattleCharacter : Character
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        private float strength;

        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider, int maxHealth = 20) : base(initPos, collider)
        {
            MaxHealth = maxHealth;
            strength = 2;
            Health = MaxHealth;
            
        }

        public void OnAttack(int amount)
        {
            AttackEvent((int)(amount * strength));
        }

        public void AlterHealth(int amount)
        {
            if (Health + amount > MaxHealth)
                Health = MaxHealth;
            else
                Health += amount;
        }
    }
}
