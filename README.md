# Fall2020_CSC403_Project

Added Features:

- Main Menu

- Player shoots a projectile

- Music

- Settings:
  	There is a settings page for the main menu and an in game settings page. The settings page on the main menu is accessed through the "Settings" button. Once on one
   	of the settings pages the user has options: A. Go back to the main menu, B. Go to the controls page to view in game controls, and C. Toggle the music On / Off.
  	Pressing 'P' will bring up the settings page in game. 

- Inventory class:
	Contains a List of strings (itemstorage) which is used to store all items meant to saved for the player to use at a later time.
  	The inventory class keeps track of the current status of the inventory window, whether or not it is shown.
	Pressing the 'i' button opens and closes the inventory window.
	Use the Left (or a) and Right (or d) arrows to select items.

 - Item class:
	Generic class for currently implpemented Health Items and for any future items to be implemented.
 
 - HealthItem:
	Class for Items that heal. Has a set healing value. Contains a collider and initial position to know when the player is collecting the item.
	Contains an use function that overrides the Item use function. Adds health to the player.
