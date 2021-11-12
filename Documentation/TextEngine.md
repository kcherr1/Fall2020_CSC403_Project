# Overview
This is our driver code for the backend. 

# Class Variables
## Story (Story)
The story’s text separated into lines, using the class Story.cs. 
## Options (Stack<Options>)
A stack of the current options for the options menu, using the class MyGameLibrary/Story/Options.cs. 
## TempOptions (Stack<Options>) 
An empty stack that allows the options menu to focus, using the class MyGameLibrary/Story/Options.cs. 
## options (List<Options>)
A list of the current options to support the options menu, using the class MyGameLibrary/Story/Options.cs. 
## ForegroundImage_XScale (double) 
The scaling value for the width of the foreground image, used for resizing the window. 
## ForegroundImage_YScale (double)
The scaling value for the height of the foreground image, used for resizing the window. 
##ForegroundImage_AspectRatio (double)
The aspect ratio of the foreground image, used for resizing the window.
## originalHeight (int)
The original height of the form, used for resizing the window.
## originalWidth (int)
The original width of the form, used for resizing the window.
## isShop (bool) (private)
Flag that determines whether the current options menu is a shop menu or not. Shop menus use a looping mechanism. 

# TextEngine
This is the initializer for the Text Engine. It initializes the shop, items, and the component, then starts handling the markup from Story.txt (in /data/story). 

# NewBackground
Argument: New background image (Image). 

Behavior: This function changes the background image. Used in scene changes. 

# NewForeground
Argument: New foreground image (Image). 

Behavior: This function changes the foreground image. Used when the character speaking changes. 

# ChangeText
Argument: new text (string). 

Behavior: This function changes the text in the textbox. Used when something new is said. 

# ForegroundVisible
Argument: hide (bool).

Behavior: If hide is true, the foreground image (the character) is visible. If hide is false, the character is hidden. 

# TextboxVisible
Argument: hide (bool). 

Behavior: If hide is true, the textbox is visible. If hide is false, the textbox is hidden. 

# TextEngine_KeyPress
Arguments: sender (object), e (KeyEventArgs)
## If there is an options menu…
Options: a stack of all the possible options

TempOptions: a stack of all the options you’ve passed

Whatever is at the top of Options stack is the currently focused option. 
### Keypress down and not at the end of Options
Changes the currently focused option by pushing the current option onto the TempOptions stack and focusing the new top Option. 
### Keypress up and TempOptions not empty
Changes the currently focused option by taking the top option off of TempOptions and making that your current option. 
### Enter
This is your selected option. 

Goes through TempOptions and Options and adds each of them back to an options list, while finding the currently focused option. Then, if you’re in the shop and your currently focused option is the exit option, isShop is set to false and you leave the shop. Then all visible options are cleared and the option’s associated markup is added to the story to handle next. Then the story progresses with a call to HandleMarkup for the next line in the story. 
## If there isn’t an options menu…
When any key is pressed, the next line of the story is parsed. 

# HandleMarkup
Argument: Line of markup (string).

Behavior: For the line, goes through each case of Markup from the Markup enum (see MyGameLibrary/Story/Markup.cs as well as MyGameLibrary/Story/Story.cs for the markup definitions) and changes the display accordingly. 
## ChangeText
Markup format: #CT text

If the markup is just whitespace or null, get the next line. Otherwise change the text of the textbox to the line. 
## ChangeBackgroundImage
Markup format: #CB image_location image_name text

Get the new background image from its file location, then remove the old background image and replace it with the new one. Then display the text. 
## ChangeForegroundImage
Markup format: #CF image_location image_name text

Get the new foreground image from its file location, then remove the old foreground image and replace it with the new one. Then display the text. 
## ChangeBackgroundAndForegroundImage
Markup format: #CBF background_location background_name foreground_location foreground_name text

Changes both images in a way similar to the previous two. 
## HideForeground
Markup format: #HF text

Hides foreground (character), then displays text. 
## ShowForeground
Markup format: #SF text

Shows foreground (character), then displays text. 
## HideTextbox
Markup format: #HT

Hides textbox. 
## ShowTextbox
Markup format: #ST

Shows textbox. 
## Options
Markup format: #O Option 1,#CT label1] Option 2,#CT label2] text

Can also have the Shop flag S: #O S Option 1,#CT label1] Option 2,#CT label2] text

Creates Options from the given options by splitting along the “]” character. The Options stack is then created, and the top option is focused. The text is then displayed. 
## AddToWallet
Markup format: #AW amount

Adds the amount to the wallet, using the functions in MyGameLibrary/Inventory.cs. 
## HideWallet
Markup format: #HW

Passes false to UpdateBalance(), which hides the wallet. 
## AddItemToInventory
Markup format: #A id

The item is found by ID. 

Then if the item’s price is less than or equal to the player’s balance, then the item’s price is withdrawn from the balance and the item is added to their inventory (using functions from MyGameLibrary/Inventory.cs). 

- Then if the item is in Hannah’s shop, the item is removed from Hannah’s shop items and Hannah’s shop is refreshed. 
- Otherwise the same is done for Hayley’s shop. 

Otherwise, if the player doesn’t have enough money to buy the selected item, the applicable shop is refreshed. 
## GiveItem
Markup format: #G characterID itemID

The characterID and itemID are parsed. Then the item is marked as used (using a function from MyGameLibrary/Inventory.cs). Then the character’s love for you is updated according to the item, and the character’s response is parsed. 
## ReadInNewStory
Markup format: #NS newstory_location newstory_name

This allows the Story to be swapped to a different txt file using ChangeStory() from MyGameLibrary/Story/Story.cs. 
## CheckPromProsal
Markup format: #CPP 

Finds the character that you have the maximum love for (checking to make sure they’re not dead), then changes the story to the prom date associated with them. If all the characters are dead, you get the bad ending. 
## CheckIfDead
Markup format: #CID characterID

First checks if the character is dead using the character enum. Then, if the character is dead, skips to the [STD] (“skip to dead”) marker, which delineates each character’s dialogue for days 3-5. 
## CheckThresholdsForTree
Markup format: #T characterID

First gets the character associated with characterID. Then, if the character hasn’t already been dated and if their LoveScore is greater than or equal to 100 (ie, they’ve been given the date gift), the story is duplicated and trimmed to the end of the day (the [ST] “skip to” marker), then the date is read in and the character is marked as dated. 
## ExitOptions
Markup format: #E

Sets shop to false and breaks the shop loop by progressing to the next line in the story. 
## HannahShopOptions
Markup format: #S1

Creates a string following the Options format of all the items currently available in Hannah’s shop, along with Hannah’s dialogue line. Then the string is added to the current story and the story progresses to that line.
## Hayley Shop Options
Markup format: #S2

Same as the previous, but with Hayley’s shop. 
## GiftOptions
Markup format: #GO characterID

Creates a string following the Options format of all the items currently in your inventory. Each item is marked with the #G markup along with the character’s name so that when you click an option, you give the character the gift. Then the string is added to the current story and the story progresses to that line. 

# ResizeHandler
Arguments: sender (object), EventHandler

Behavior: Handles scaling when the user resizes the window. 

# TextEngine_Load and TextEngine_Load1
Arguments: sender (object), EventHandler

Behavior: Empty. Required for loading the TextEngine. 
