using MyGameLibrary.Shop;
using System;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public class Item
    {
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public Items ItemID { get; set; }
        public Boolean used {get; set;}
        public static Dictionary<int, Item> allItems { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> hannahShopItems { get; set; } = new Dictionary<int, Item>();
        public static Dictionary<int, Item> hayleyShopItems { get; set; } = new Dictionary<int, Item>();
        public Item(Items identifier, string name, int price)
        {
            ItemID = identifier;
            ItemName = name;
            ItemPrice = price;
            used = false;
        }

        public static void initializeAllItems()
        {
            allItems.Add((int)Items.amongTheSkies, new Item(Items.amongTheSkies, "Among The Skies", 10));
            allItems.Add((int)Items.brick, new Item(Items.brick, "Brick", 10));
            allItems.Add((int)Items.cookingWithChocolate, new Item(Items.cookingWithChocolate, "Cooking With Chocolate", 10));
            allItems.Add((int)Items.frozenSteak, new Item(Items.frozenSteak, "Frozen Steak", 10));
            allItems.Add((int)Items.guillotine, new Item(Items.guillotine, "Guillotine", 10));
            allItems.Add((int)Items.hayleysCrown, new Item(Items.hayleysCrown, "Hayley's Crown", 40));
            allItems.Add((int)Items.humanSoul, new Item(Items.humanSoul, "Human Soul", 40));
            allItems.Add((int)Items.plushCat, new Item(Items.plushCat, "Plush Cat", 10));
            allItems.Add((int)Items.portableOven, new Item(Items.portableOven, "Portable Oven", 10));
            allItems.Add((int)Items.readyPlayerTwo, new Item(Items.readyPlayerTwo, "Ready Player Two", 10));
            allItems.Add((int)Items.realGun, new Item(Items.realGun, "Gun", 20));
            allItems.Add((int)Items.tigerLily, new Item(Items.tigerLily, "Tiger Lily", 10)); ;
            allItems.Add((int)Items.toolKit, new Item(Items.toolKit, "Tool Kit", 10));
            allItems.Add((int)Items.toyGun, new Item(Items.toyGun, "Toy Gun", 10));
            allItems.Add((int)Items.whoopieCushion, new Item(Items.whoopieCushion, "Whoopie Cushion", 10));
            allItems.Add((int)Items.mathTextbook, new Item(Items.mathTextbook, "Math Textbook", 10));
        }

        public static void initializeHannahShop()
        {
            hannahShopItems.Add((int)Items.amongTheSkies, allItems[(int)Items.amongTheSkies]);
            hannahShopItems.Add((int)Items.cookingWithChocolate, allItems[(int)Items.cookingWithChocolate]);
            hannahShopItems.Add((int)Items.frozenSteak, allItems[(int)Items.frozenSteak]);
            hannahShopItems.Add((int)Items.plushCat, allItems[(int)Items.plushCat]);
            hannahShopItems.Add((int)Items.portableOven, allItems[(int)Items.portableOven]);
            hannahShopItems.Add((int)Items.tigerLily, allItems[(int)Items.tigerLily]);
            hannahShopItems.Add((int)Items.toolKit, allItems[(int)Items.toolKit]);
            hannahShopItems.Add((int)Items.toyGun, allItems[(int)Items.toyGun]);
            hannahShopItems.Add((int)Items.mathTextbook, allItems[(int)Items.mathTextbook]);
        }

        public static void initializeHayleyShop()
        {
            hayleyShopItems.Add((int)Items.brick, allItems[(int)Items.brick]);
            hayleyShopItems.Add((int)Items.guillotine, allItems[(int)Items.guillotine]);
            hayleyShopItems.Add((int)Items.hayleysCrown, allItems[(int)Items.hayleysCrown]);
            hayleyShopItems.Add((int)Items.humanSoul, allItems[(int)Items.humanSoul]);
            hayleyShopItems.Add((int)Items.readyPlayerTwo, allItems[(int)Items.readyPlayerTwo]);
            hayleyShopItems.Add((int)Items.realGun, allItems[(int)Items.realGun]);
            hayleyShopItems.Add((int)Items.whoopieCushion, allItems[(int)Items.whoopieCushion]);
        }
    }
}
