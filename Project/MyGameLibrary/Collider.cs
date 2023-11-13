using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public class Collider {
    private Rectangle rect;
        private bool isActive; 

    public Collider(Rectangle rect) {
      this.rect = rect;
    // Added as a flag to see if collider is active
      this.isActive = true;
    }

    public void MovePosition(int x, int y) {
      rect.X = x;
      rect.Y = y;
    }

    public bool Intersects(Collider c) {
      return this.isActive && c.isActive && rect.IntersectsWith(c.rect);
        }

    // Used to Remove Collision 
    public void Deactivate()
        {
            this.isActive = false;
        }

    public void Activate()
    {
        this.isActive = true;
    }
  }
}
