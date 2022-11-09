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
    - The death screen that pop ups when the game ends, specifically after the player's health has reached 0 while fighting. It displays a specific image for each character option.

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
        
FrmBattle.cs
    - The battle screen. The player picture displays the image for the specific character chosen. The player also now has the option to do a special attack that is unique for each character.
    
    METHODS
    1) btnAttack_Click(object sender, EventArgs e)
        - Function now checks the health of the player and pops up the death form
        - Also checks if the player is playing as baby and if so, checks if the baby has used the special attack so it can know if it needs to deal extra damage or not.
    2) specialAttack_Click(object sender, EventArgs e)
        - New function that will do damage based on a special attack unique to the character
        - Mr. Peanut's special attack is just a stronger one time attack he can do once
        - Mrs. Peanut's is a health steal that takes health from the enemy and heals her for that amount
        - Baby Peanut has a bleed attack that will continuously do damage for the next three attacks

FrmHelp.cs
    - A help screen that the player will be able to access on the menu, battle screens, and level screen in pause. 
