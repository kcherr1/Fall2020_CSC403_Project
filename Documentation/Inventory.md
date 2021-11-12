# Class Variables
## walletBalance (int) (static)
The amount of money held by the player (to be used in shops), starts at 0.

## Contents (Dictionary<Items, Item>)
The contents of the player inventory, with key of Items type and value of Item type.

# removeItem (returns void, static, takes Items enum as parameter)
Removes from the Contents dictionary the Items object and associated Item fed to the function

# useItem (returns void, static, takes Items enum as parameter)
Changes the used property of an Item in the Contents dictionary corresponding to the Items enum key to true

# addItem (returns void, static, takes Items enum and Item object as parameter)
Adds the two parameters to the Contents dictionary in the form key: Items, value: Item

# withdrawMoney (returns void, static, takes int as parameter)
Subtracts the given int from the walletBalance variable

# depositMoney (returns void, static, takes int as parameter)
Adds the given int to the walletBalance variable
