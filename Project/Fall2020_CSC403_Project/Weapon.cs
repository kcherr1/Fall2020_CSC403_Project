using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threating.task;
namespace Fall2020_CSC403_Project.code
{
	public class Weapon : Item
    {
        public int Damage { get; set; }
	// weapon constructor w/ parameters
        public Weapon(int itemNum, string name, int damage) 
            : base(itemNum, name)
        {
	    // weapon properties
            Damage = damage;
        }
	// create new instance of weapons
        public new Weapon Clone()
        {
            return new Weapon(ItemNum, Name, Damage);
        }
    }
}
