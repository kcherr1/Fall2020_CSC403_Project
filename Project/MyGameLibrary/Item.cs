using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public abstract class Item
    {
        public string Name { get; set; }

        abstract public int Use();

        public Item(string name)
        {
            this.Name = name;
        }
    }
}
