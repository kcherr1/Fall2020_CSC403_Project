using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Item : Character
    {
        public string NAME;
        public Item(Vector2 initPos, Collider collider, string name) : base(initPos, collider)
        {
            NAME = name;
        }

        public void useItem()
        { }
        
    }
}
