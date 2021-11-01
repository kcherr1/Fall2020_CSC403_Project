using System.Collections.Generic;
using MyGameLibrary.Shop;

namespace MyGameLibrary.Character
{
    public class Character
    {
        public string CharacterName { get; set; }
        public bool IsDead { get; set; }
        private int LoveScore;
        public int GetLoveScore() {
            return LoveScore;
        }
        public void SetLoveScore(int LScore) {
            if (IsDead == true) {
                LoveScore = -1;
                return;
            }
            switch (LScore)
            {
                case int x when x > 100:
                    LoveScore = 100;
                    break;
                case int x when x < 0:
                    LoveScore = 0;
                    break;
                default:
                    LoveScore = LScore;
                    break;
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
