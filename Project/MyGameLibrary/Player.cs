using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {
    public new int Xp { get; private set; }
        public new int XpLevel { get;  set; }
        public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {
        Xp = 0;
        XpLevel = 1;
    }
    public new void AlterXp(int amount){
        Xp += amount;
    }
  }
}
