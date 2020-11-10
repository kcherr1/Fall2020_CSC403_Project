using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary.InventoryObjects
{
    public class Experience : InventoryObject
    {
        private readonly int experienceAmount = 1;
        
        public Experience(Image img, int count)
        {
            this.stackable = true;
            this.exhaustible = true;
            this.img = img;
            this.count = count;
            
        }

        public override void Effect(BattleCharacter character)
        {
            throw new NotImplementedException();
        }

        public override void Effect(Player player)
        {
            Remove(1);
        }
    }
}
