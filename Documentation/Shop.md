# Class Variables
## Products (Dictionary<int, Item>)
a dictionary of the available items in the shop, containing pairs of Item ID and Item.

# Functions
## Shop (one parameter: Dictionary<int, Item>)
A constructor for a shop object, which sets the shop’s Product dictionary to equal the provided dictionary.
## Purchase (void, one parameter: Items ID)
Implements purchasing an item in the Shop by removing the item from the Products list, removing the appropriate amount from the user’s wallet, and adding the item to the user’s inventory.
