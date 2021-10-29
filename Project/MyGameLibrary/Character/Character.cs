using System.Collections.Generic;

namespace Fall2020_CSC403_Project.code
{
    public class Character
    {
        public string CharacterName { get; set; };
        public bool isDead = false;
        private int LoveScore;
        public int GetLoveScore() {
            return LoveScore;
        }
        public void SetLoveScore(int LScore) {
            if (isDead == true)
            {
                LoveScore = -1;
            }
            else if (LScore > 100)
            {
                LoveScore = 100;
            } else if (LScore < 0)
            {
                LoveScore = 0;
            }
            else {
                LoveScore = LScore;
            }
        }

        //Items is ID of item, int is love point value of gift for this character
        public Dictionary<Items, int> ItemScores; 

        public Character(string name, int LScore, Dictionary<Items, int> dict)
        {
            CharacterName = name;
            LoveScore = LScore;
            ItemScores = dict;
        }

        public void LoveUpdate(Items item)
        {
            SetLoveScore(LoveScore+ItemScores[item]);
        }

        public void kill() {
            isDead = true;
            SetLoveScore(-1);
        }
    }
}
