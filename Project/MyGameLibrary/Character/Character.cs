using System.Collections.Generic;
using MyGameLibrary.Shop;

namespace MyGameLibrary.Character
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string GiftHappyResponse { get; set; }
        public string GiftUnhappyResponse { get; set; }

        public string DateLocation { get; set; }
        public string DateName { get; set; }
        public string PromLocation { get; set; }
        public string PromName { get; set; }
        public bool Dated { get; set; }
        public bool IsDead { get; set; }
        private int _lovescore { get; set; }
        public int LoveScore {
            get {
                return _lovescore;
            }
            set {
                if (IsDead == true) {
                    _lovescore = -1;
                    return;
                }
                switch (value)
                {
                    case int x when x > 100:
                        _lovescore = 100;
                        break;
                    case int x when x < 0:
                        _lovescore = 0;
                        break;
                    default:
                        _lovescore = value;
                        break;
                }
            }
        }

        //Items is ID of item, int is love point value of gift for this character
        public Dictionary<Items, int> ItemScores; 

        public Character(string name, int LScore, string HappyResponse, string UnhappyResponse, string DateLocation, string DateName, string PromLocation, string PromName, Dictionary<Items, int> dict)
        {
            CharacterName = name;
            LoveScore = LScore;
            GiftHappyResponse = HappyResponse;
            GiftUnhappyResponse = UnhappyResponse;
            this.DateLocation = DateLocation;
            this.DateName = DateName;
            this.PromLocation = PromLocation;
            this.PromName = PromName;
            ItemScores = dict;
            IsDead = false;
            Dated = false;
        }

        public string LoveUpdate(Items item)
        {
            LoveScore += ItemScores[item];
            if (ItemScores[item] <= 0)
            {
                return this.GiftUnhappyResponse;
            }
            else
            {
                return this.GiftHappyResponse;
            }
        }

        public void Kill() {
            IsDead = true;
            LoveScore = -1;
        }
    }
}
