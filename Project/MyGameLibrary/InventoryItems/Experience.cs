﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fall2020_CSC403_Project;
using Fall2020_CSC403_Project.code;

namespace MyGameLibrary.InventoryObjects
{
    public class Experience : InventoryObject
    {
        private readonly int experienceAmount = 1;
        
        public Experience(Image img, int count)
        {
            this._stackable = true;
            this._exhaustible = true;
            this.img = img;
            this._count = count;
        }

        public override void Effect(BattleCharacter character)
        {
            throw new NotImplementedException();
        }

        public override void Effect(Player player)
        {
            FrmExperience frmExperience = new FrmExperience(this,player);
            frmExperience.ShowDialog(); // Shows the experience dialogue; pauses the
                                        // game until the player has allocated the experience.
        }
    }
}