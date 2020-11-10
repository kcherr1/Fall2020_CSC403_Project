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
        private readonly int healAmount = 6;
        
        public HealthPotion()
        {
            this.stackable = false;
            this.exhaustible = true;
            
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
