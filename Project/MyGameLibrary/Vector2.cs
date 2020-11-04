using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public struct Vector2
    {
        // static class variables
        public static Vector2 Up = new Vector2(0, 1);
        public static Vector2 Down = new Vector2(0, -1);
        public static Vector2 Left = new Vector2(-1, 0);
        public static Vector2 Right = new Vector2(1, 0);

        // private fields
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        // operator overloading
        public static Vector2 operator +(Vector2 a) => a;
        public static Vector2 operator -(Vector2 a) => new Vector2(-a.x, -a.y);

        public static Vector2 operator +(Vector2 a, Vector2 b) => new Vector2(a.x + b.x, a.y + b.y);
        public static Vector2 operator -(Vector2 a, Vector2 b) => new Vector2(a.x - b.x, a.y - b.y);
        public static Vector2 operator *(Vector2 a, float b) => new Vector2(a.x * b, a.y * b);
    }
}
