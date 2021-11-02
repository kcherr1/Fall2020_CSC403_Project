﻿
using MyGameLibrary.Shop;
using System.Collections.Generic;

namespace Fall2020_CSC403_Project
{
    public static class Inventory
    {
        static int walletBalance;
        static Dictionary<Items, Item> Contents = new Dictionary<Items, Item>();

        public static void removeItem(Items ID)
        {
            Contents.Remove(ID);
        }

        public static void addItem(Items ID, Item item)
        {
            Contents.Add(ID, item);
        }

        public static void withdrawMoney(int dollars)
        {
            walletBalance -= dollars;
            if(walletBalance < 0)
            {
                walletBalance = 0;
            }
        }

        public static void depositMoney(int dollars)
        {
            walletBalance += dollars;
        }
    }
}