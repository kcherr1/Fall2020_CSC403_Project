using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Wall
    {
        public PictureBox Pic { get; set; }
        public Collider Collider { get; set; }

        public Wall(PictureBox Pic)
        {
            this.Pic = Pic;
            this.Collider = new Collider(Pic);
        }

    }
}
