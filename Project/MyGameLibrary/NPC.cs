﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class NPC : Character {
        public bool IsBanished { get; set; }
        public bool IsDonator { get; set; }
        public NPC(Vector2 initPos, Collider collider) : base(initPos, collider) 
        {
            IsBanished = false;
            IsDonator = false; 
        }
  }
}
