Healing
=======

.. note::
   This page is in development.

.. default-domain:: sphinxsharp


**Overview**

At the beginning of the game, the player has 3 healing items. A button that says "HEAL" as well as a 
counter for how many healing potions the player has will be displayed on the battle screen. When the 
player uses a healing potion, it will heal the player *1/2* health up to but not exceeding the player's 
max health. Health packs can also be picked up within the level. Once the player touches a health pack,
it will disappear from the level and the player's health pack inventory will be incremented by one.


**Technical Information/Changes**

The changes to the code for healing are as follows:

* Added a HealthPackCount variable which is initialized within the constructor of the BattleCharacter 
  class.
* Added a *useHealthPack()* class method to the BattleCharacter class that will decrement the 
  HealthPackCount by one every time that it is used.
* A "HEAL" button (and the related code to its function), an image of a health pack beside the "HEAL" 
  button, and a counter that pulls from HealthPackCount (which is updated every time the health bars 
  are updated) were added to the FrmBattle class and Designer files.
* The player can pick up a health pack from the level (health pack is represented as a Character object).
