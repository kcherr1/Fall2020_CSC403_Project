# Fall2020_CSC403_Project
## Description
A simple Game written in C# using Windows Forms on a .NET framework

------------------------------------------------------------------------------

## Running Program
Can only be run in Visual Studio 19 with source code by running the solution.
No executable available.

------------------------------------------------------------------------------

## Features
------------------------------------------------------------------------------

### FEATURE - Random Enemies
- Date: 11/08/2020
- This feature created 2 new enemies and allows for spawning 3 random and unique enemies from the total pool of enemies

##### **RandomIntegers()**
This function returns an integer array with three unique integers. The integers are random and determine which enemies are spawned. Enemies visibility is determined through this array.

##### **SpawnEnemies()**
This function does not return a value. This function initially sets all enemy models to invisible and then loops through the return of RandomIntegers() to determine which enemy models to make visible (spawn).

##### **Other Changes**
- Created 2 new enemies : Tony the tiger and Ronald McDonald.
- Change in exising function tmrPlayerMove_Tick() to only fight enemies that are also visible to the exisiting condition checks.


----------------------------------------------------------------------------

### FEATURE - Experience
- Date: 11/11/2020
- Adds Experience Tracking. Including Random experience from enemies, an XP bar in the battle form as well as an indicator on enemy picture for how much experience they will give on death.

##### **UpdateExperienceBar(int xpGain)**
This functions paramater is xpGain which is a random integer designated at enemy instantiation.
This will check if the player has exceeded the 100 needed points needed for a level incrementing the level when successful. The experience bar UI is adjusted based on the % the player is away from leveling up. Level is updated and displayed in a label next to the experience bar and the enemy portrait contains another level displaying the enemies experience given on death.

This function is called in btnAttack_Click(). Here UpdateExperienceBar will only be called if the player is still alive and the enemy has been killed.

##### **GenerateExperience()**
generates a random integer between two specified values. This function is called to generate a random experience amount for characters.

#### **Other Changes**
Battle Character class has added three member variables:
   - ExperienceOnDeath which sets it's value based on GenerateExperience().
   - ExperienceToLevel which is the amount needed until the next level is achieved.
   - CurrentLevel which is the players current level.
   
-------------------------------------------------------------------------------------
