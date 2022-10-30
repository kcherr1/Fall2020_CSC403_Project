# Team CSC403-002 22F Scrum Project

## Documentation 

### Ingame Pause Window 

Created a new Windows Forms class that acts as the pause menu for the game called `FrmPause.cs`. A `FrmPause` instance is initiated and shown when the player presses the escape button. Unlike a `FrmBattle` instance, a player can not continue to play the game while a `FrmPause` window is shown. The reason is because inside `FrmLevel.cs`, frmBattle, an instance of `FrmBattle.cs`, uses `frmBattle.show()` to show the window while frmPause, an instance of `FrmPause.cs`, uses `frmPause.ShowDialog()` which does not allow the player to access any other windows while frmPause is shown. 

A boolean class variable inside of `FrmLevel.cs` called isPaused was created solely for the purpose of stopping the ingame timer. isPaused's value is initially set to false. When the escape key is hit, the isPaused variable is set to true, and when the frmPause window is closed, isPaused is set back to false. More on pausing the ingame timer is discussed below.

### `FrmPause.cs` Functionality 

`FrmPause.cs` contains three buttons: `resumeButton`, `startOverButton`, and `quitButton`. For each button, there is a Click `EventHandler` inside `FrmPause.Designer.cs` that triggers each of the `[button]_Click` functions inside `FrmPause.cs` in the event that any one of the buttons are clicked.

#### Resume Button

When clicked, the `FrmPause.cs` instance frmPause inside `FrmLevel.cs` is closed and the game is resumed. 

#### Start Over Button 

When clicked, the entire Windows Forms application is restarted and the game starts over completely. 

#### Quit Button 

When clicked, the entire Window Forms application is closed, quitting the game entirely. 

### `FrmPause.cs` Design

The buttons were implemented using the Windows Forms Toolbox. The background photo in the window, named `pauseMenuBackground.jpg` can be found in the `Team_CSC403_Scrum_1/Properties/` folder inside the file `Resources.resx `. The `pauseMenuBackground.jpg` photo was uploaded to `Resources.resx` from the `Team_CSC403_Scrum_1/Data/` folder (`pauseMenuBackground.jpg` was uploaded manually to this folder). 

### Pausing Ingame Timer
In order to pause the timer found inside of the game, a Stopwatch instance named timer was created inside `FrmLevel.cs` (replacing the old DateTime instance startTime). The timer is started when the game is first loaded. When the isPaused variable is true, the timer is stopped. The timer can only be started again when the isPaused variable is set back to true, which only happens when the frmPause window is closed. 
