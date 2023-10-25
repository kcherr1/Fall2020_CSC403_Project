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
    public int Score { get; private set; }

    public event Action<int> AttackEvent;
    public event Action<int> HealEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
      Score = 0;
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
    }

    public void OnHeal(int amount)
        {
            HealEvent((int)(amount));
        }

    public void AlterScore(int amount)
        {
            Score += amount;
        }
    public void AlterHealth(int amount) {
      Health += amount;
    }
  }
}
