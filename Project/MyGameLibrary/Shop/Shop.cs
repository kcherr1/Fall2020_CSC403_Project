using Fall2020_CSC403_Project;
using System.Collections.Generic;

namespace MyGameLibrary.Shop
{
    public class Shop
    {
        public Dictionary<int, Item> Products { get; set; } = new Dictionary<int, Item>();

        public Shop(Dictionary<int, Item> products)
        {
            Products = products;
        }
        public void purchase(Items ID)
        {
            Inventory.addItem(ID, Products[(int)ID]);
            Inventory.withdrawMoney(Products[(int)ID].ItemPrice);
            Products.Remove((int)ID);
        }
    }
}
