# Fall2022_CSC532_Project


---
# **Scrum Project 1** #
---
# **Finch, Laurence H** #
## **User Story 1**: As a player, I can click on a menu to exit the game.
1.   I created a menustrip with File - Quit option on frmLevel.
2.   On the quitToolStripMenuItem_Click event, I added code to exit the application.

## **User Story 2**: As a player, I want damages from battle to be a random number between 2 values that I specify.
1.   After researching this, I decided to use the Random function to determine damage created by both the player and enemy.
2.   I created a form called frmRandomBattleDamageInput.
3.   On this form, I created 2 textboxes and 2 command buttons.
4.   One textbox is for the minumum damage allowed and the other textbox is for the maximum damage allowed.
5.   One command button is labeled 'Cancel', which cancels any changes and exits the form.
6.   The other command button saves the changes to the textboxes and exits the form.
7.   I stored the minimum and maximum damage allowed in 'Properties.Settings.Default' (MinRandomBattleDamage and MaxRandomBattleDamage) and when the form opens, it reads and displays the data in the appropriate text boxes.
8.   On the frmBattle form, I created a new instance of the Random class named '_random'.
9.   When the 'Attack' button is clicked, then the code reads the values for minimum and maximum damage from Properties.Settings.Default.MinRandomBattleDamage and Properties.Settings.Default.MaxRandomBattleDamage.
10.   Then a random integer is calculated between these two values and passed to the 'OnAttack' event of the player class.

## **User Story 3**: As a player, I want the enemy icons to be removed once they are defeated.
1.   This one was a little tricky. I had to find a way to remove the icon of the enemy off the form without causing the code to break. This was tricky because of the 'collider' class. I couldn't just make them invisible, I had to dispose of the enemy class created for each enemy, which breaks the code later due to it looking for them.
2.   I decided to add the delete code under the tmrPlayerMove_Tick event, just for quickness. 
3.   I added code to first check to see if the enemy object had already been disposed of (!=null).
4.   Then I checked to see if that enemy had died (Health<=0). If so, then I called the Dispose method for that object.
5.   I tried to dispose of the enemy object after the frmBattle form was closed, but I kept getting errors, so this was the easiest method I could find.  There are probably better options available though.



---
# **Scrum Project 2** #
---
# **Finch, Laurence H** #
---
## **User Story 1**: As a player, I want the enemy characters to move randomly around the screen.	


1.   I researched different ways of making the enemy characters change direction when they hit either a wall or another enemy character.
2.   I decided on using another timer, named tmrEnemyMove. 
3.   I started with a list of the three enemy characters, with their 'object' name.  This way if there is another enemy character added later, all we'd need to do is add that object to the list. I was trying to find a way to just find all the objects of Enemy class, but couldn't.
4.   I then created a for loop to iterate through the enemies.
5.   If the enemy object was still valid (!=null), then I called their Location method to update their cooresponding picture box.
6.   Under the Character class, I created a new integer variable to store what direction the character is currently moving.
7.   I created a new function called ChooseRandomDirection that takes the enemy object as input and stores a new random direction, not the current direction, in the variable I created in step 6. Directions are 1:left, 2:up, 3:right, 4:down.  I did notice that in using the Random.Next(minvalue, maxvalue) that the maxvalue has to be one more than what you really want. So for a random value between 1 & 4, you have to use 1 & 5.
7.   I then started each enemy moving left.
8.   Then I created an if statement to determine if any of the enemies hit a wall or each other. If they did, then I called ChooseRandomDirection to get a new direction and had the enemy start moving in that direction.



## **User Story 2**: As a player, every time the game starts I want the location of inner walls to change.

---
