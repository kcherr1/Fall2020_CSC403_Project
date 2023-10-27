using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Tile : Terrain
    {
        public EffectType Effect { get; set; }
        public PictureBox Pic { get; set; }
        public Collider Collider { get; set; }
        public Position Position { get; set; }
        public Position LastPosition { get; set; }

        public Tile(PictureBox Pic, EffectType Effect)
        {
            this.Pic = Pic;
            Pic.SendToBack();
            Pic.Size = new Size(50, 50);
            this.Collider = new Collider(Pic);
            this.Position = new Position(Pic);
            this.Effect = Effect;
            
        }
        public Tile(PictureBox Pic)
        {
            this.Pic = Pic;
            Pic.SendToBack();
            Pic.Size = new Size(50, 50);
            this.Collider = new Collider(Pic);
            this.Position = new Position(Pic);
            this.Effect = EffectType.None;

        }
        public enum EffectType
        {
            SuperSlowness = 1,
            Slowness = 2,
            None = 3,
            Speed = 4
        }

        public bool ContainsCharacter(Character c)
        {
            return this.Collider.ContainsEntity(c);
        }

        public void RemoveTile()
        {
            this.Position = new Position(-100, -100);
            Collider.MovePosition((int)Position.x, (int)Position.y);
            this.Pic.Visible = false;
        }

        public void RestoreTile()
        {
            this.Position = LastPosition;
            Collider.MovePosition((int)Position.x, (int)Position.y);
            this.Pic.Visible = true;
        }
    }
}
