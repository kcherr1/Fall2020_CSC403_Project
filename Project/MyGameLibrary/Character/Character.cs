using System.Collections.Generic;

namespace Fall2020_CSC403_Project.code
{
    public class Character
    {
        public string CharacterName;
        public int LoveScore;
        public Dictionary<Items, int> ItemScores; //Items is ID, int is current value

        public Character(string name, int LScore, Dictionary<ItemID, LoveValue> dict)
        {
            CharacterName = name;
            LoveScore = LScore;
            ItemScores = dict;
        }

        public void LoveUpdate(Character Person, int AdditionalScore)
        {
            Person.LoveScore = AdditionalScore + Person.LoveScore;
        }
    }
}
