using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGameLibrary
{
    public class Projectile
    {
        public bool inFlight = false;
        private const int GO_INC = 6;

        public int Damage = -1;
        public Vector2 Position { get; set; }
        public Collider Collider { get; private set; }
        public Projectile(Vector2 initPos, Collider collider)
        {
            Position = initPos;
            Collider = collider;
        }
        // Calculates which direction to shoot the arrow
        public void arrowMove(string direction)
        {
            int xPos = 0;
            int yPos = 0;
            if (direction.Equals("right"))
            {
                xPos = GO_INC;
            } 
            else if (direction.Equals("left"))
            {
                xPos = -GO_INC;
            }
            else if (direction.Equals("up"))
            {
                yPos = -GO_INC;
            }
            else if (direction.Equals("down"))
            {
                yPos = GO_INC;
            }

            Position = new Vector2(Position.x + xPos, Position.y + yPos);
            Collider.MovePosition((int)Position.x + xPos, (int)Position.y + yPos);
        }
    }
}
