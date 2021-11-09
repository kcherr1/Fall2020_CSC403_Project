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

        private static Dictionary<Items, int> s_dictWendyItemResponse;
        private static Dictionary<Items, int> s_dictTonyItemResponse;
        private static Dictionary<Items, int> s_dictRonaldItemResponse;
        private static Dictionary<Items, int> s_dictGreenItemResponse;
        private static Dictionary<Items, int> s_dictBKItemResponse;

        public static Character Wendy;
        public static Character Tony;
        public static Character Ronald;
        public static Character Green;
        public static Character BurgerKing;

        static CharacterCollection() {
            DeclareDict();
            Wendy = new Character("Wendy", LScore: 40, s_dictWendyItemResponse);
            Tony = new Character("Tony the Tiger", LScore: 50, s_dictTonyItemResponse);
            Ronald = new Character("Ronald McDonald", LScore: 50, s_dictRonaldItemResponse);
            Green = new Character("Green M&M", LScore: 50, s_dictGreenItemResponse);
            BurgerKing = new Character("Burger King", LScore: 50, s_dictBKItemResponse);

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
            s_dictWendyItemResponse = new Dictionary<Items, int> {
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
            s_dictTonyItemResponse = new Dictionary<Items, int> {
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
            s_dictRonaldItemResponse = new Dictionary<Items, int> {
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
            s_dictGreenItemResponse = new Dictionary<Items, int> {
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
            s_dictBKItemResponse = new Dictionary<Items, int> {
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
