using System.Collections.Generic;
using MyGameLibrary.Shop;

namespace MyGameLibrary.Character
{
    public class Character
    {
        public string CharacterName { get; set; }
        public int ID { get; set; }
        public string GiftHappyResponse { get; set; }
        public string GiftUnhappyResponse { get; set; }
        public string GiftKillsResponse { get; set; }

        public string DateLocation { get; set; }
        public string DateName { get; set; }
        public string PromLocation { get; set; }
        public string PromName { get; set; }
        public bool Dated { get; set; }
        private bool _isDead { get; set; }
        public bool IsDead
        {
            get
            {
                return _isDead;
            }
            set
            {
                _isDead = value;
                if (value)
                {
                    switch (this.ID)
                    {
                        case 1:
                            CharacterCollection.CharacterDictionary[(CharacterID)2].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)3].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)4].LoveScore += -100;
                            CharacterCollection.CharacterDictionary[(CharacterID)5].LoveScore += -25;
                            break;
                        case 2:
                            CharacterCollection.CharacterDictionary[(CharacterID)1].LoveScore += 25;
                            CharacterCollection.CharacterDictionary[(CharacterID)3].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)4].LoveScore += -100;
                            CharacterCollection.CharacterDictionary[(CharacterID)5].LoveScore += -25;
                            break;
                        case 3:
                            CharacterCollection.CharacterDictionary[(CharacterID)1].LoveScore += 25;
                            CharacterCollection.CharacterDictionary[(CharacterID)2].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)4].LoveScore += -100;
                            CharacterCollection.CharacterDictionary[(CharacterID)5].LoveScore += 25;
                            break;
                        case 4:
                            CharacterCollection.CharacterDictionary[(CharacterID)1].LoveScore += 25;
                            CharacterCollection.CharacterDictionary[(CharacterID)2].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)3].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)5].LoveScore += -25;
                            break;
                        case 5:
                            CharacterCollection.CharacterDictionary[(CharacterID)5].LoveScore += 25;
                            CharacterCollection.CharacterDictionary[(CharacterID)2].LoveScore += -25;
                            CharacterCollection.CharacterDictionary[(CharacterID)3].LoveScore += 25;
                            CharacterCollection.CharacterDictionary[(CharacterID)4].LoveScore += -100;
                            break;
                    }
                }
            }
        }
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

        public Character(string name, int ID, int LScore, string HappyResponse, string UnhappyResponse, string DeathResponse, string DateLocation, string DateName, string PromLocation, string PromName, Dictionary<Items, int> dict)
        {
            CharacterName = name;
            this.ID = ID;
            LoveScore = LScore;
            GiftHappyResponse = HappyResponse;
            GiftUnhappyResponse = UnhappyResponse;
            GiftKillsResponse = DeathResponse;
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
            if (ItemScores[item] == -100)
            {
                IsDead = true;
                return this.GiftKillsResponse;
            }
            else if(ItemScores[item] <= 0)
            {
                return this.GiftUnhappyResponse;
            }
            else
            {
                return this.GiftHappyResponse;
            }
        }
    }
}
