﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public int Score { get; private set; }
    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
        Score = 0;
    }
    public void AlterScore(int amount){
        Score += amount;
    }
  }
}
