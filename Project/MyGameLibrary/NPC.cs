﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  public class NPC : Character {
    public NPC(string Name, PictureBox Pic, Position initPos, Collider collider, PlayerArchetype archetype) : base(Name, Pic, initPos, collider, archetype) {

        }
    }
}
