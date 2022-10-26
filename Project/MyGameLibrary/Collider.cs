using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Collider {
    private Rectangle rect;
    private Boolean canBeCollidedWith;

    public Collider(Rectangle rect, Boolean canBeCollidedWith) {
      this.canBeCollidedWith = canBeCollidedWith;
      this.rect = rect;
    }

    public void MovePosition(int x, int y) {
      rect.X = x;
      rect.Y = y;
    }

    public void EnableCollider() {
      this.canBeCollidedWith = true;
    }
    public void DisableCollider() {
      this.canBeCollidedWith = false;
    }

    public bool Intersects(Collider c) {
      return canBeCollidedWith && rect.IntersectsWith(c.rect);
    }
  }
}
