# Class Variables
## ItemName (string)
The name of the item, to be used in the options menus

## ItemPrice (int)
The cost of an item within a given shop, requires money in the walletBalance of the Inventory class

## ItemID (Items enum)
The Items identifier for a given item

## used (Boolean)
Flag checking whether or not a given item has been used

## allItems (Dictionary<int, item>) (static)
Dictionary holding every item in the game corresponding to an int pair

## HannahShop (Shop) (static)
Shop class containing every item in the Hannah shop

## HayleyShop(Shop) (static)
Shop class containing every item in the Hayley shop

# Item
Initializer for the Item class, declares values for ItemID, ItemName, ItemPrice, and the used boolean (set to false by default)

# initializeAllItems (returns void, static, no parameters)
Adds every item in the game to the allItems dictionary, hard-coded item initialization for every item

# initializeHannahShop (returns void, static, no parameters)
Takes required Items and Item objects and adds to the HannahShop class dictionary

# initializeHayleyShop (returns void, static, no parameters)
Takes required Items and Item objects and adds to the HayleyShop class dictionary
