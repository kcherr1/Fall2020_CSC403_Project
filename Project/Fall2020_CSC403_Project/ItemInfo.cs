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
			_gameItem = new List<Item>();
			_gameItem.Add(new Weapon(01, "Stapler", 1);
		}
	}
	public static Item CreateItem(int itemNum)
	{
		Item regularItem = _gameItem.FirstOrDefault(item => item.ItemNum == itemNum);
		if(regularItem != null)
		{
			return regularItem.Clone();
		}
		return null;
	}
}
