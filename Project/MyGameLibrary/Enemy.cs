using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code
{

	public class Enemy : Character
	{
		public Color Color { get; set; }
        public Image Img { get; set; }

        public Enemy(string Name, PictureBox Pic, PlayerArchetype archetype) : base(Name, Pic, archetype)
		{

		}
	}
}
