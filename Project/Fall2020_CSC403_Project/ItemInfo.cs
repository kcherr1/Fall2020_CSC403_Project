using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threating.task;
namespace Fall2020_CSC403_Project.code
{
	public static class ItemInfo
	{
		private static List<Item> _gameItem;
		static ItemInfo()
		{
			// creating the items for the game
			_gameItem = new List<Item>();
			// creating first weapon
			_gameItem.Add(new Weapon(01, "Stapler", 1);
			// creating first health item
			_gameItem.Add(new HealthItem(02, "Health", 10);
		}
	}
	// instantiates the items
	public static Item CreateItem(int itemNum)
	{
		// Looks through list for item with the itemNum
		Item regularItem = _gameItem.FirstOrDefault(item => item.ItemNum == itemNum);
		if(regularItem != null)
		{
			// if there is a matach, a new instance of the item is created
			return regularItem.Clone();
		}
		return null;
	}
}
