# Class Variables

## CharacterName (string)
Name of the character in question

## ID (int)
Number corresponding to the CharacterID of a given character

## GiftHappyResponse (string)
Response to a positive score gift

## GiftUnhappyResponse (string)
Response to a negative score gift

## GiftDeathResponse (string)
Response specifically to a gift that kills character

## DateLocation (string)
Name of the folder containing the story file for date story

## DateName (string)
Name of the story file in given DateLocation folder

## PromLocation (string)
Name of the folder containing the story file for prom story

## PromName (string)
Name of story file in given PromLocation folder

## IsDated (bool)
Flag checking if layer has gone in date with a given character

## _isDead (bool) (private)
Private variable for custom setter of IsDead variable

## IsDead (bool)
A variable that determines whether or no the character is dead.
When setting isDead to true, the setter also updates the love scores of every other character based on a set of predetermined values.

## _lovescore (int) (private)
Private variable for custom setter of LoveScore variable

## LoveScore (int)
A variable that holds the current degree of love for the player possessed by the character.
When setting the lovescore, the setter checks if the character is dead (and sets to -1); if not dead, checks if the lovescore is between 0 and 100. If not, it sets the lovescore to 0 when below 0 or to 100 when above 100.

## ItemScores (Dictionary<Items, int>)
Contains a series of Items-int pairs corresponding to the lovescore associated with each item

# Character
Initializer for the character class. Sets Character name, CharacterID, Love Score, Response to good gifts (line of dialogue), response to bad gifts, death response, date location, name of date (in code), Prom location and name, scores for interacting with every item, whether the character is dead, and whether the character has been dated

# LoveUpdate (returns string, takes Item as parameter)
Adds current love score to the score of the inputted item for the character. On doing this, determines whether the item is positive, negative, or death response and returns the appropriate line.
