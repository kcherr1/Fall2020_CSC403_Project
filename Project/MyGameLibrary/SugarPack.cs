using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class SugarPack : Item
    {
        private const int healValue = 10;

        public SugarPack(Vector2 initPos, Collider collider, string name) : base(initPos, collider, name)
        { }

        public new void useItem(Player player)
        {
            
        }

        public Image Img { get; set; }
    }
}
