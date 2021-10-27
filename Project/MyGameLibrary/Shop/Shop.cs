using Fall2020_CSC403_Project;
using System.Collections.Generic;

namespace MyGameLibrary.Shop
{
    class Shop
    {
        public Dictionary<Items, Item> Products = new Dictionary<Items, Item>();

        public void purchase(Items ID)
        {
            Inventory.addItem(ID, Products[ID]);
            Inventory.withdrawMoney(Products[ID].getPrice());
            Products.Remove(ID);
        }
    }
}
