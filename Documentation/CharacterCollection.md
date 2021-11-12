# Class Variables

## CharacterDictionary(Dictionary<CharacterID, Character>) (static)
Dictionary for accessing every character using CharacterID enum as key

## s_dictWendyItemResponse (Dictionary<Items, int>) (static)
ItemScore dictionary to be added to the Wendy Character

## s_dictTonyItemResponse (Dictionary<Items, int>) (static)
ItemScore dictionary to be added to the Tony Character

## s_dictRonaldItemResponse (Dictionary<Items, int>) (static)
ItemScore dictionary to be added to the Ronald Character

## s_dictGreenItemResponse (Dictionary<Items, int>) (static)
ItemScore dictionary to be added to the Green Character

## s_dictBKItemResponse (Dictionary<Items, int>) (static)
ItemScore dictionary to be added to the BurgerKing Character

## Wendy (Character) (static)
Character class object for the Wendy character

## Tony (Character) (static)
Character class object for the Tony the Tiger character

## Ronald (Character) (static)
Character class object for the Ronald McDonald character

## Green (Character) (static)
Character class object for the Green M&M character

## BurgerKing (Character) (static)
Character class object for the Burger King character

# CharacterCollection (static)
Initializer of CharacterCollection class. Runs DeclareDict function, creates every character to be placed in CharacterDictionary (with associated variables), and creates the CharacterDictionary with key: CharacterID and value: character.

# DeclareDict (static) (void, no parameters)
Declares each dictionary and all key-value pairs (Items, int) associated with each character’s ItemScore variable.
