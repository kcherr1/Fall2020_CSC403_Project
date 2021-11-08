using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
        public int availableStatPoints { get; private set; }
    public Player(Vector2 initPos, Collider collider, float strength, float evasion, float defense) : base(initPos, collider, strength, evasion, defense) {
            availableStatPoints = 2;
    }

        public void AlterStrength(int amount)
        {
            strength += amount;
        }

        public void AlterEvasion(int amount)
        {
            evasion += amount;
        }

        public void AlterDefense(int amount)
        {
            defense += amount;
        }

        public void alterAvailableStatPoints(int amount)
        {
            availableStatPoints += amount;
        }
    }
}
