using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code {
  public struct Vector2 {
    public float x;
    public float y;

    public Vector2(float x, float y) {
      this.x = x;
      this.y = y;
    }

    public static Vector2 Add(Vector2 VectorA, Vector2 VectorB) {
      return new Vector2(VectorA.x + VectorB.x, VectorA.y + VectorB.y);
    }

    public void NormalizeSquare() {
      float MaxValue = Math.Abs(Math.Max(this.x, this.y));
      if (MaxValue > 0f) {
        this.x /= MaxValue;
        this.y /= MaxValue;
      }
    }

    public bool IsZero() {
      return (this.x == 0f && this.y == 0f);
    }
  }
}
