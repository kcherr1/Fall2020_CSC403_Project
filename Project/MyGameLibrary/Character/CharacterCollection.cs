using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGameLibrary.Character;
using MyGameLibrary.Shop;

namespace MyGameLibrary.Character
{
    public static class CharacterCollection
    {
        public static Dictionary<CharacterID, Character> CharacterDictionary;

        private static Dictionary<Items, int> dictWendy;
        private static Dictionary<Items, int> dictTony;
        private static Dictionary<Items, int> dictRonald;
        private static Dictionary<Items, int> dictGreen;
        private static Dictionary<Items, int> dictBK;

        public static Character Wendy;
        public static Character Tony;
        public static Character Ronald;
        public static Character Green;
        public static Character BurgerKing;

        static CharacterCollection() {
            DeclareDict();
            Wendy = new Character("Wendy", 40, dictWendy);
            Tony = new Character("Tony the Tiger", 40, dictTony);
            Ronald = new Character("Ronald McDonald", 40, dictRonald);
            Green = new Character("Green M&M", 40, dictGreen);
            BurgerKing = new Character("Burger King", 40, dictBK);

            CharacterDictionary = new Dictionary<CharacterID, Character> {
                {(CharacterID) 1, Wendy},
                {(CharacterID) 2, Tony},
                {(CharacterID) 3, Ronald},
                {(CharacterID) 4, Green},
                {(CharacterID) 5, BurgerKing}
            };

        }

        //Declare love values for each gift item, dict1-dict5 corresponds to character ID 1-5
        private static void DeclareDict() {
            dictWendy = new Dictionary<Items, int> {
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
            dictTony = new Dictionary<Items, int> {
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
            dictRonald = new Dictionary<Items, int> {
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
            dictGreen = new Dictionary<Items, int> {
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
            dictBK = new Dictionary<Items, int> {
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
