using MyGameLibrary.Shop;

namespace Fall2020_CSC403_Project
{
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int ItemPrice { get; set; }
        public Items ItemID { get; set; }
        public Item(Items identifier, string name, string description, int price)
        {
            ItemID = identifier;
            ItemName = name;
            ItemDescription = description;
            ItemPrice = price;
        }
    }
}
