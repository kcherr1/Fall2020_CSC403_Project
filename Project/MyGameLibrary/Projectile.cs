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

        public int Damage = -20;
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
            Collider.MovePosition((int)Position.x, (int)Position.y);
        }

        public void returnArrow(Character p)
        {
            Position = new Vector2(p.Position.x, p.Position.y);
            Collider.MovePosition((int)p.Position.x, (int)p.Position.y);
        }

        public Vector2 calcDirection(Vector2 player, Vector2 enemy)
        {
            int dx = (int)player.x - (int)enemy.x;
            int dy = (int)player.y - (int)enemy.y;

            bool xIsPositive = dx > 0;
            bool yIsPositive = dy > 0;

            int xPos = (GO_INC - 3);
            int yPos = (GO_INC - 3);

            if (!xIsPositive)
                xPos = -xPos;
            if (!yIsPositive)
                yPos = -yPos;


            return new Vector2(xPos, yPos);
        }

        public void enemyArrowMove(Vector2 direction)
        {
            Position = new Vector2(Position.x + direction.x, Position.y + direction.y);
            Collider.MovePosition((int)Position.x, (int)Position.y);
        }
    }
}
