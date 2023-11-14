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
      this.level = 1;
      //helps calculate the player's level;
      //can be changed to increase how much experience is needed before leveling up
      this.experiencePerLevel = 20;
    }
    public void EarnExperience(int experienceToGain) {
      this.experience += experienceToGain;
            
      if (this.experience / this.experiencePerLevel >= 1 )
      {
        this.experience = 0;
        this.level += 1;
        this.MaxHealth += 5;
        this.Health += 5; //player gets a chance to heal a little after leveling up
        this.strength += 2;
      }
    }
  }
}
