using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Item
    {
        public string NAME;
        private const int healValue = 10;
        public Vector2 Position { get; set; }
        public Collider Collider { get; set; }
        public Item(Vector2 initPos, Collider collider, string name)
        {
            Position = initPos;
            Collider = collider;
            NAME = name;
        }

        public void useItem(Player player)
        { }
        
    }
}
