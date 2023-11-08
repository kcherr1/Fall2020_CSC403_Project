using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;

namespace Fall2020_CSC403_Project.code
{
    public class Entity
    {
        public int SPEED { get; set; }

		public PictureBox Pic;

		public Position MoveSpeed { get; private set; }
		public Position LastPosition { get; private set; }
		public Collider Collider { get; private set; }


        public Rectangle Size { get; private set; }
        public Position Position { get; private set; }

        public string Name { get; private set; }

        public Facing facing { get; set; }
        private Facing LastFacing { get; set; }


        public enum Facing
        {
            Left,
            Right
        }

        public Entity(string Name, PictureBox Pic)
        {
            this.SPEED = 3;
            this.Name = Name;
            this.Pic = Pic;
            this.Position = new Position(this.Pic);
            this.Collider = new Collider(this.Pic);
            this.facing = Facing.Right;
            this.LastFacing = this.facing;
        }
        
        public void Move()
        {
            if (this.LastFacing != this.facing)
            {
                this.Pic.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
            this.LastFacing = this.facing;
            this.LastPosition = Position;
            this.Position = new Position(Position.x + MoveSpeed.x, Position.y + MoveSpeed.y);
            this.Pic.Location = new Point((int)this.Position.x, (int)this.Position.y);
            this.Collider.MovePosition((int)Position.x, (int)Position.y);

        }


        public void MoveBack()
        {
            this.Position = LastPosition;
        }

        public void GoLeft()
        {
            this.MoveSpeed = new Position(-SPEED, 0);
            this.facing = Facing.Left;

        }
        public void GoRight()
        {
            this.MoveSpeed = new Position(+SPEED, 0);
            this.facing = Facing.Right;
        }
        public void GoUp()
        {
            this.MoveSpeed = new Position(0, -SPEED);
        }
        public void GoDown()
        {
            this.MoveSpeed = new Position(0, +SPEED);
        }

		public void ResetMoveSpeed()
		{
			MoveSpeed = new Position(0, 0);
		}

		public void HideEntity()
		{
            Collider.Disable();
			this.Pic.Visible = false;
        }

        public void SetEntityPosition(Position pos)
        {
            this.LastPosition = Position;
            this.Position = pos;
            Collider.MovePosition((int)Position.x, (int)Position.y);
            this.Pic.Visible = true;
            this.Pic.Location = new Point((int)Position.x, (int)Position.y);
            Collider.Enable();
            this.Pic.BringToFront();
        }


    }
}
