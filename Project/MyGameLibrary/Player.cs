using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public int Experience;
    public int RequiredLevelExperience;
    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
      Experience = 0;
      RequiredLevelExperience = 50;
    }

    public void AlterExperience(int amount) {
     Experience += amount;
    }

    public void ScaleLevelExperience(int amount) {
     RequiredLevelExperience += amount;
    }
  }
}
