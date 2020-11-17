using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary.InventoryObjects
{
    public class HealthPotion : InventoryObject
    {
        private int healAmount = 6;
        
        public HealthPotion()
        {
            this.Img = MyGameLibrary.Properties.Resources.health_potion;
        }

        public override void Effect(BattleCharacter character)
        {
            throw new NotImplementedException();

        }

        public override void Effect(Player player)
        {
            player.AlterHealth(healAmount);
        }
    }
}
