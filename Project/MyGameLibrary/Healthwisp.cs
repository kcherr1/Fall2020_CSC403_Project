using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public class Healthwisp : Character
    {
        public bool IsTaken { get; set; }
        public Healthwisp(Vector2 initPos, Collider collider) : base(initPos, collider)
        {
            IsTaken = false;
        }
    }
}
