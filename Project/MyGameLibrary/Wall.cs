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

        public Position Position { get; set; }
        public Position LastPosition { get; set; }

        public Wall(PictureBox Pic)
        {
            this.Pic = Pic;
            this.Collider = new Collider(Pic);
            this.Position = new Position(Pic);
        }

        public void RemoveWall()
        {
            this.Position = new Position(-100, -100);
            Collider.MovePosition((int)Position.x, (int)Position.y);
            this.Pic.Visible = false;
        }

        public void RestoreWall()
        {
            this.Position = LastPosition;
            Collider.MovePosition((int)Position.x, (int)Position.y);
            this.Pic.Visible = true;
        }
    }
}
