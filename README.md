# Fall2020_CSC403_Project

# Finch, Laurence H
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
