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
        public Image Pic { get; set; }
        public Point Position { get; set; }


        public Tile(Image Pic, Point Position, EffectType Effect)
        {
            this.Pic = Pic;
            this.Position = Position;
            this.Effect = Effect;
            
        }
        public Tile(Image Pic, Point Position)
        {
            this.Pic = Pic;
            this.Position = Position;
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
