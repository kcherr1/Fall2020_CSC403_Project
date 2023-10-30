using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
    public class Tile
    {
        public EffectType Effect { get; set; }
        public PictureBox Pic { get; set; }
        public Collider Collider { get; set; }
        public Position Position { get; set; }

        public Tile(PictureBox Pic, EffectType Effect)
        {
            this.Pic = Pic;
            Pic.SendToBack();
            this.Collider = new Collider(Pic);
            this.Position = new Position(Pic);
            this.Effect = Effect;
            
        }
        public Tile(PictureBox Pic)
        {
            this.Pic = Pic;
            Pic.SendToBack();
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

    }
}
