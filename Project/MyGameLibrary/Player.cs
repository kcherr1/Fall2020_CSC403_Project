using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Player : Character
    {
        public Player(Position initPos, Collider collider, PictureBox pic, String name) : base(initPos, collider, pic, name)
        {

        }
    }
}
