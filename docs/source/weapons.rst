Weapons
=======

.. note::
   This page is in development.

.. default-domain:: sphinxsharp

**Overview**

Weapons can be found on the ground within the level and can be picked up by touching the weapon. 
When the weapon is equipped, the weapon will appear beside the "ATTACK" button when the player goes 
into a battle, and will add additional strength to the player's attack power based on the strength of 
the weapon. When the player selects the "ATTACK" button, a short animation will happen where it will 
appear that the weapon (in this exmample case being a firearm) is firing and will show a short burst of 
ammunition fire from the gun before inflicting the attack on the enemy.



**Techical Information**

A class called "Weapon" was created with the following class structure:

.. type:: public class Weapon

*Class Variables*

* *private int strength* - defines the weapons strength (defaults to 0 if not defined in initialization)

The only methods in this class are a getter and setter for the strength variable.



**Changes to the Code Base**

The changes to the code for weapons are as follows:

* Added the *Weapon Class* to the code base
* Added the class variables WeaponStrength and WeaponEquipped variables to the BattleCharacter class
* Added picture of weapon to the FrmBattle when the player has a weapon equipped
* Added a gunfire animation to FrmBattle when the player clicks "ATTACK" and a weapon is equipped
* Added the WeaponStrength variable to the AttackEvent in the BattleCharacter class
* Created the weapon in the FrmLevel
* Added checks within the FrmLevel code to check and see if the player has collided with the weapon object
