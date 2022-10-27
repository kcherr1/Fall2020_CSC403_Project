using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {

    }

    // options for face_direction: front or back (used for player animation)
    public string face_direction = "front";

    // options for move_direction: still, left, right, forward, or backward (used for player animation)
    public string move_direction = "still";
  }
}
