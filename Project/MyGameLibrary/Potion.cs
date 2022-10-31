using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Potion : Item
    {
        public int Healing { get; private set; }

        public Potion(string name, int healing): base(name)
        {
            this.Name = name;
            this.Healing = healing;
        }

        public override int Use()
        {
            MessageBox.Show("You have used the " + this.Name + " you healed " + this.Healing.ToString() + "!", this.Name);
            return Healing;
        }
    }
}
