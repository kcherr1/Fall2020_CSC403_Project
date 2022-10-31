using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Weapon : Item
    {

        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public bool IsEquiped { get; set; }
        
        public Weapon(string name, int minDamage, int maxDamage) : base(name)
        {
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.IsEquiped = false;
        }
        
        override public int Use()
        {
            if (this.IsEquiped)
            {
                MessageBox.Show("You have unequiped " + this.Name + "!", this.Name);
                this.IsEquiped = false;
                //this.Unequip();
                return 0;

            }
            else
            {
                MessageBox.Show("You have equiped " + this.Name + "!", this.Name);
                this.IsEquiped = true;
                //this.Equip();
                return 1;
            }

            
        }

        public void Equip()
        {
            //throw new NotImplementedException();
            //Properties.Settings.Default.MinRandomBattleDamage = this.MinDamage;
            //Properties.Settings.Default.MaxRandomBattleDamage = this.MaxDamage;
        }

        public void Unequip()
        {
            //throw new NotImplementedException();
        }
    }
}
