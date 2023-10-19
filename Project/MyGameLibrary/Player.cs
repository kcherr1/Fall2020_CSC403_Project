using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    public int level { get; private set; }
    public int experiencePerLevel { get; private set; }

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
            this.experience = 0;
            this.level = 0;

            //helps calculate the player's level;
            //can be changed to increase how much experience is needed before leveling up
            this.experiencePerLevel = 30;
    }
    public void EarnExperience(int experienceToGain) {
            this.experience += experienceToGain;
            
            if (this.experience / this.experiencePerLevel >= 1 )
            {
                //reset experience to 0 so it's easy to repeat the procedure above
                this.experience = 0;
                this.level += 1;
            }
    }
  }
}
