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
        public Item(string name, string description, int price)
        {
            ItemName = name;
            ItemDescription = description;
            ItemPrice = price;
        }
    }
}
