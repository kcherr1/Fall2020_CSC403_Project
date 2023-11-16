using System.Drawing;


namespace Fall2020_CSC403_Project.code
{
    public class Item {
        public Image Img { get; set; }
        public Vector2 Position { get; set; }
        public Collider Collider { get; private set; }
        public string Name { get; private set; }

        public Item(string name, Vector2 initPos, Collider collider) {
            Name = name;
            Position = initPos;
            Collider = collider;
        }
    }
}
