using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary.InventoryObjects
{
    public class Axe : InventoryObject, IWeapon
    {
        private int damageAmount = 4;
        
        public Axe(Image img)
        {
            this.img = img;
        }
		
		public int GetDamage() {
			return damageAmount;
		}

        public override void Effect(BattleCharacter character)
        {
            throw new NotImplementedException();

        }

        public override void Effect(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
