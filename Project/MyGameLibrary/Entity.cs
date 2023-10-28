using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;

namespace Fall2020_CSC403_Project.code
{
    public class Entity
    {
        private const int GO_INC = 3;

		public PictureBox Pic;

		public Position MoveSpeed { get; private set; }
		public Position LastPosition { get; private set; }
		public Collider Collider { get; private set; }


        public Rectangle Size { get; private set; }
        public Position Position { get; private set; }

        public string Name { get; private set; }

        public Facing facing { get; set; }


        public enum Facing
        {
            Left,
            Right
        }



        public Entity(string Name, PictureBox Pic)
        {
            this.Name = Name;
            this.Pic = Pic;
        }


        public Entity(string Name, PictureBox Pic, Position initPos, Collider collider)
        {
            this.Name = Name;
            this.Pic = Pic;
            this.Position = initPos;
            this.LastPosition = Position;
            this.Collider = collider;
            this.LastPosition = Position;
        }

        
        public void Move()
        {
            this.LastPosition = Position;
            this.Position = new Position(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
            this.Collider.MovePosition((int)Position.x, (int)Position.y);
        }


        public void MoveBack()
        {
            this.Position = LastPosition;
        }

        public void GoLeft()
        {
            this.MoveSpeed = new Position(-GO_INC, 0);
            this.facing = Facing.Left;
        }
        public void GoRight()
        {
            this.MoveSpeed = new Position(+GO_INC, 0);
            this.facing = Facing.Right;
        }
        public void GoUp()
        {
            this.MoveSpeed = new Position(0, -GO_INC);
        }
        public void GoDown()
        {
            this.MoveSpeed = new Position(0, +GO_INC);
        }

		public void ResetMoveSpeed()
		{
			MoveSpeed = new Position(0, 0);
		}

		public void RemoveEntity()
		{
            this.LastPosition = Position;;
            this.Position = new Position(-100, -100);
            Collider.MovePosition((int)Position.x, (int)Position.y);
			this.Pic.Visible = false;
            this.Pic.Location = new Point((int)Position.x, (int)Position.y);
        }

		public void RestoreEntity()
		{
			this.Position = LastPosition;
            this.Pic.Location = new Point((int)Position.x, (int)Position.y);
            this.LastPosition = Position;
            Collider.MovePosition((int)Position.x, (int)Position.y);
			this.Pic.Visible = true;
        }

        public void SetEntityPosition(Position pos)
        {
            this.Position = pos;
            Collider.MovePosition((int)pos.x, (int)pos.y);
            this.Pic.Visible = true; // remove later
            this.Pic.Location = new Point((int)Position.x, (int)Position.y);
        }


    }
}
