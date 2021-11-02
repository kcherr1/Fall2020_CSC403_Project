using System.Collections.Generic;
using MyGameLibrary.Shop;

namespace MyGameLibrary.Character
{
    public class Character
    {
        public string CharacterName { get; set; }
        public bool IsDead { get; set; }
        public int LoveScore {
            get {
                return _LoveScore;
            }
            set {
                if (IsDead == true) {
                    LoveScore = -1;
                    return;
                }
                switch (value)
                {
                    case int x when x > 100:
                        LoveScore = 100;
                        break;
                    case int x when x < 0:
                        LoveScore = 0;
                        break;
                    default:
                        LoveScore = value;
                        break;
                }
            }
        }

        //Items is ID of item, int is love point value of gift for this character
        public Dictionary<Items, int> ItemScores; 

        public Character(string name, int LScore, Dictionary<Items, int> dict)
        {
            CharacterName = name;
            LoveScore = LScore;
            ItemScores = dict;
            IsDead = false;
        }

        public void LoveUpdate(Items item)
        {
            LoveScore += ItemScores[item];
        }

        public void Kill() {
            IsDead = true;
            LoveScore = -1;
        }
    }
}
