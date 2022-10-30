# Team CSC403-002 22F Scrum Project

## Documentation 

### Enemy Instance Removal Upon Death

Ingame enemies are now removed from the game when their health is less than or equal to zero. Three functions were created in `FrmLevel.cs` to implement this capability. 

#### private bool enemyIsDead(Enemy enemy)

Takes in a `Enemy.cs` instance as an input and checks if its health is less than or equal to zero, and if so, return true. Otherwise, if the enemy's health is above zero, return false. 

#### private void removeEnemy(Enemy enemy)
Takes in a `Enemy.cs` instance as an input and sets the instance to null. Furthermore, the PictureBox image that is attached to the enemy instance (as a collider) is set to be invisible. 

#### private void battleOver(object sender, FormClosedEventArgs e)
Closed EventHandler for `FrmBattle` instance frmBattle created in `Fight` function. This function is called when the frmBattle window is closed. Inside the function is a call to the `enemyIsDead` function to check if the enemy from the battle is dead. If this function returns true, the enemy instance is passed into the `removeEnemy` function. 
