using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Collider {
    private Rectangle rect;

    public Collider(Rectangle rect) {
      this.rect = rect;
    }

    public void MovePosition(int x, int y) {
      rect.X = x;
      rect.Y = y;
    }

    public bool Intersects(Collider c) 
    {
      //enemy colliders are removed when they are defeated
      if(c == null)
      { 
        return false; 
      }
      return rect.IntersectsWith(c.rect);
    }
  }
}
