using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class HealthItem : Item
    {
        public HealthItem(Vector2 initPos, Collider collider, string name) : base(initPos, collider, name)
        { }

        public new void useItem()
        {
            // Increase Health of player
        }

        public Image Img { get; set; }
    }
}
