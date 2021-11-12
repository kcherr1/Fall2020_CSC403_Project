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
        public static Shop HannahShop { get; set; }
        public static Shop HayleyShop { get; set; }
        public Item(Items identifier, string name, int price)
        {
            ItemID = identifier;
            ItemName = name;
            ItemPrice = price;
            used = false;
        }

        public static void initializeAllItems()
        {
            allItems.Add((int)Items.fantasyNovel, new Item(Items.fantasyNovel, "Fantasy Novel", 10));
            allItems.Add((int)Items.brick, new Item(Items.brick, "Brick", 10));
            allItems.Add((int)Items.cookingWithChocolate, new Item(Items.cookingWithChocolate, "Chocolate Cookbook", 10));
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
            HannahShop = new Shop(new Dictionary<int, Item> {
                { (int)Items.fantasyNovel, allItems[(int)Items.fantasyNovel]},
                { (int)Items.cookingWithChocolate, allItems[(int)Items.cookingWithChocolate] },
                { (int)Items.frozenSteak, allItems[(int)Items.frozenSteak] },
                { (int)Items.plushCat, allItems[(int)Items.plushCat]},
                { (int)Items.portableOven, allItems[(int)Items.portableOven] },
                { (int)Items.tigerLily, allItems[(int)Items.tigerLily]},
                { (int)Items.toolKit, allItems[(int)Items.toolKit]},
                { (int)Items.toyGun, allItems[(int)Items.toyGun] },
                { (int)Items.mathTextbook, allItems[(int)Items.mathTextbook]} });
        }

        public static void initializeHayleyShop()
        {
            HayleyShop = new Shop(new Dictionary<int, Item> {
                { (int)Items.brick, allItems[(int)Items.brick]},
                { (int)Items.guillotine, allItems[(int)Items.guillotine] },
                { (int)Items.hayleysCrown, allItems[(int)Items.hayleysCrown] },
                { (int)Items.humanSoul, allItems[(int)Items.humanSoul] },
                { (int)Items.readyPlayerTwo, allItems[(int)Items.readyPlayerTwo] },
                { (int)Items.realGun, allItems[(int)Items.realGun] },
                { (int)Items.whoopieCushion, allItems[(int)Items.whoopieCushion]} });
        }
    }
}
