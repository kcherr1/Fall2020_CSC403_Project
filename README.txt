Documentation for Team Squonk Fall 2022 Project

FrmMenu.cs
    - The FrmMenu.cs file adds the new main menu for the game

    METHODS
    1) quitBtn_Click(object sender, EventArgs e)
        - Triggers when the quitBtn on the main menu form is clicked. This closes the entire application

    2) playBtn_Click(object sender, EventArgs e)
        - Triggers when the playBtn on the main menu form is click. Currently it hides the current menu form then start's the gcharacter select form.
        - It starts the game form by calling FrmLevel.GetInstance(0) and assigning it to the variable theGame and then showing that varibale.
        - The 0 input tells the function that this is calling a new game and needs to return a new FrmLevel()

Program.cs
    - When first starting up the application, the game now starts by loading up the FrmMenu() form instead of the FrmLevel() form

FrmLevel.cs
    METHODS
    1) GetInstance(int flag)
        - The method is used to either open up a new, fresh version of the FrmLevel() form or reset the instance of the form if the game has ended, either by the player winning or dying in battle. 
        - An input of 0 tells the function to return a new FrmLevel form while an input of 1 tells the function to reset the instance to null

FrmDeath.cs
    - The death screen that pop ups when the game ends, specifically after the player's health has reached 0 while fighting

    METHODS
    1) menuBtn_Click(object sender, EventArgs e)
        - Triggers when the menuBtn on the death screen is clicked. It creates a new instance of the FrmMenu form and shows it then closes the FrmDeath form.
    1) quitBtn_Click(object sender, EventArgs e)
        - Triggers when the quitBtn on the death screen is clicked. This closes the entire application

FrmCharacterSelect.cs
    - The character selection screen the players reaches before starting the game. All three of the click methods in this form start the game by calling FrmLevel.GetInstance(0) which creates a new instance of the FrmLevel form and shows the form

    METHODS
    1) selectMr_Click(object sender, EventArgs e)
        - This function sets the player model and stats to the Mr. Peanut class

    2) selectMs_Click(object sender, EventArgs e)
        - This function sets the player model and stats to the Ms. Peanut class
        
    3) selectBaby_Click(object sender, EventArgs e)
        - This function sets the player model and stats to the Baby Peanut class
