﻿using System;
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

        public event Action<int> AttackEvent;

        public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
            MaxHealth = 20;
            strength = 1;
            Health = MaxHealth;
        }

        public void OnAttack(int amount) {
            AttackEvent((int)(amount * strength));
        }

        public void AlterHealth(int amount) {
            Health += amount;
        }

        // gets strength value from player for display in CharacterScreen.cs
        public float getStrength()
        {
            return strength;
        }
          
        //added a set health function that sets the health of the character chosen to a specific integer
        public void SetHealth(int amount)
        {
            Health = amount;
        }
    }
}
