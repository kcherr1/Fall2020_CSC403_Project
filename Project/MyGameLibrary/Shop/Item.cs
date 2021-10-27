using MyGameLibrary.Shop;

namespace Fall2020_CSC403_Project
{
    public class Item
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

        public int getPrice()
        {
            return ItemPrice;
        }

        public string getDescription()
        {
            return ItemDescription;
        }

        public string getName()
        {
            return ItemName;
        }

        public Items getID()
        {
            return ItemID;
        }
    }
}
