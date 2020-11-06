using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public int Level { get; private set; }
        public int EXP { get; private set; }

        public Player(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            Level = 1;
            EXP = 0;
        }

        public void AwardEXP(int xp)
        {
            // award experience points if the given xp value isn't negative
            if (xp > 0)
                EXP += xp;

            // adjust player level based on accrued experience
            // TODO: If player level goes up then a message should be displayed
            // TODO: Player shouldn't be able to grind XP off dead enemies, because that makes no sense
            Level = (EXP / 100) + 1;
        }
    }
}
