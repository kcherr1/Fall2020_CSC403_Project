using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threating.task;
namespace Fall2020_CSC403_Project.code
{
	public class Item
	{
		public int ItemNum {get; set;}
		public string Name {get; set;}
		public Item(int itemNum, string name)
		{
			ItemNum = itemNum;
			Name = name;
		}
	}
	
	public Item Clone()
	{
		return new Item(ItemNum, Name);
	}
}
