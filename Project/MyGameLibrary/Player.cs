﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public bool[] _movementBools = new bool[] { false, false, false, false };
        public Player(Vector2 initPos, Collider collider) : base(initPos, collider)
        {

        }

        public int MovementValue()
        {
            int movementCount = 0;
            foreach (bool movementBool in _movementBools)
            {
                if (movementBool) { movementCount++; }
            }
            return movementCount;
        }
    }
}
