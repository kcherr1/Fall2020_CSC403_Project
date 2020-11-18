using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Stats
    {
        public Levels Levels;
        private readonly int expPerLevel = 10;

        
        public Stats(int startingAttack, int startingDefence)
        {
            Levels.attack = startingAttack;
            Levels.attackExp = startingAttack * expPerLevel;
            Levels.defence = startingDefence;
            Levels.defenceExp = startingDefence * expPerLevel;
        }

        // Increases levels/exp based passed exp value.
        public void AddExperience(Skills skill, int exp)
        {
            switch (skill)
            {
                case Skills.Attack:
                    Levels.attackExp += exp;
                    Levels.attack = Levels.attackExp / expPerLevel;
                    break;
                case Skills.Defence:
                    Levels.defenceExp += exp;
                    Levels.defence = Levels.defenceExp / expPerLevel;
                    break;
            }
        }

        public enum Skills
        {
            Attack,
            Defence
        }
    }

    

    public struct Levels
    {
        public int attack;
        public int attackExp;
        public int defence;
        public int defenceExp;
    }
}
