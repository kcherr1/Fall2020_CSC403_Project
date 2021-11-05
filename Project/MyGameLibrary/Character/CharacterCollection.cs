using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGameLibrary.Character;
using MyGameLibrary.Shop;

namespace MyGameLibrary.Character
{
    public class CharacterCollection
    {
        public Dictionary<characterID, Character> CharacterDictionary;

        private Dictionary<Items, int> dict1;
        private Dictionary<Items, int> dict2;
        private Dictionary<Items, int> dict3;
        private Dictionary<Items, int> dict4;
        private Dictionary<Items, int> dict5;

        private Character Wendy;
        private Character Tony;
        private Character Ronald;
        private Character Green;
        private Character BurgerKing;

        public CharacterCollection() {
            DeclareDict();
            Wendy = new Character("Wendy", 40, dict1);
            Tony = new Character("Tony the Tiger", 40, dict2);
            Ronald = new Character("Ronald McDonald", 40, dict3);
            Green = new Character("Green M&M", 40, dict4);
            BurgerKing = new Character("Burger King", 40, dict5);

            CharacterDictionary = new Dictionary<characterID, Character> {
                {(characterID) 1, Wendy},
                {(characterID) 2, Tony},
                {(characterID) 3, Ronald},
                {(characterID) 4, Green},
                {(characterID) 5, BurgerKing}
            };

        }

        //Declare love values for each gift item, dict1-dict5 corresponds to character ID 1-5
        private void DeclareDict() {
            dict1 = new Dictionary<Items, int> {
                {(Items) 1, -10},
                {(Items) 2, -10},
                {(Items) 3, -10},
                {(Items) 4, -10},
                {(Items) 5, -100},
                {(Items) 6, -10},
                {(Items) 7, -10},
                {(Items) 8, -10},
                {(Items) 9, -10},
                {(Items) 10, -10},
                {(Items) 11, -10},
                {(Items) 12, -10},
                {(Items) 13, -10},
                {(Items) 14, 60},
                {(Items) 15, -10},
                {(Items) 16, -10}
            };
            dict2 = new Dictionary<Items, int> {
                {(Items) 1, 5},
                {(Items) 2, 15},
                {(Items) 3, -5},
                {(Items) 4, -100},
                {(Items) 5, 10},
                {(Items) 6, 5},
                {(Items) 7, -5},
                {(Items) 8, -10},
                {(Items) 9, -5},
                {(Items) 10, -10},
                {(Items) 11, -10},
                {(Items) 12, -5},
                {(Items) 13, 5},
                {(Items) 14, -20},
                {(Items) 15, 5},
                {(Items) 16, 50}
            };
            dict3 = new Dictionary<Items, int> {
                {(Items) 1, 10},
                {(Items) 2, 5},
                {(Items) 3, 10},
                {(Items) 4, -5},
                {(Items) 5, 5},
                {(Items) 6, 5},
                {(Items) 7, -5},
                {(Items) 8, -10},
                {(Items) 9, 10},
                {(Items) 10, -100},
                {(Items) 11, 10},
                {(Items) 12, 75},
                {(Items) 13, -10},
                {(Items) 14, -5},
                {(Items) 15, 30},
                {(Items) 16, -10}
            };
            dict4 = new Dictionary<Items, int> {
                {(Items) 1, 5},
                {(Items) 2, 5},
                {(Items) 3, -10},
                {(Items) 4, 5},
                {(Items) 5, -10},
                {(Items) 6, -100},
                {(Items) 7, -20},
                {(Items) 8, 100},
                {(Items) 9, -5},
                {(Items) 10, -10},
                {(Items) 11, -10},
                {(Items) 12, -5},
                {(Items) 13, -10},
                {(Items) 14, -10},
                {(Items) 15, 5},
                {(Items) 16, 10}
            };
            dict5 = new Dictionary<Items, int> {
                {(Items) 1, -10},
                {(Items) 2, -5},
                {(Items) 3, -10},
                {(Items) 4, 5},
                {(Items) 5, 10},
                {(Items) 6, -10},
                {(Items) 7, 10},
                {(Items) 8, 10},
                {(Items) 9, -10},
                {(Items) 10, -10},
                {(Items) 11, -100},
                {(Items) 12, -5},
                {(Items) 13, -10},
                {(Items) 14, -10},
                {(Items) 15, 100},
                {(Items) 16, 5}
            };
        }
    }
}
