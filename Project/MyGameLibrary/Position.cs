using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{
	public struct Position
	{
		public float x;
		public float y;

		public Position(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		public Position(PictureBox pic)
		{
			this.x = pic.Location.X;
			this.y = pic.Location.Y;
        }
	}
}
