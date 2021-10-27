using MyGameLibrary.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project
{
    class Item
    {
        string ItemName;
        string ItemDescription;
        int ItemPrice;
        Items ItemID;
        public Item(Items identifier, string name, string description, int price)
        {
            ItemID = identifier;
            ItemName = name;
            ItemDescription = description;
            ItemPrice = price;
        }
    }
}
