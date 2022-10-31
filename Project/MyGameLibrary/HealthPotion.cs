using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fall2020_CSC403_Project.code
{

    public class HealthPotion : Character
    {
        public Image Img { get; set; }

        public HealthPotion(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
        }
    }
}
