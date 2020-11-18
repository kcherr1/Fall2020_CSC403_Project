using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary.InventoryObjects
{
    public class BaseballBat : InventoryObject, IWeapon
    {
        private int damageAmount = 2;
        
        public BaseballBat(Image img)
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
          player.EquippedWeapon = this;
        }
    }
}
