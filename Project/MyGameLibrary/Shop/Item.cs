using MyGameLibrary.Shop;

namespace Fall2020_CSC403_Project
{
    public class Item
    {
        string ItemName { get; set; }
        string ItemDescription { get; set; }
        int ItemPrice { get; set; }
        Items ItemID { get; set; }
        public Item(Items identifier, string name, string description, int price)
        {
            ItemID = identifier;
            ItemName = name;
            ItemDescription = description;
            ItemPrice = price;
        }
    }
}
