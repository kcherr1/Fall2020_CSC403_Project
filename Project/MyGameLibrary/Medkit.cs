using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Medkit
    {
        public Vector2 Position { get; private set; }
        public Collider Collider { get; private set; }

        public int health_value { get; set; }



        public Medkit(Vector2 initPos, Collider collider, int health)
        {
            Position = initPos;
            Collider = collider;
            health_value = health;
        }
    }
}
