using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public class Level : Form {
    public Level() { }

    public Vector2 CreatePosition(PictureBox pic) {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    public Collider CreateCollider(PictureBox pic, int padding) {
      Rectangle rect = new Rectangle(
        pic.Location, 
        new Size(pic.Size.Width - padding, pic.Size.Height - padding)
      );
      return new Collider(rect);
    }

    public virtual void SaveGame(string fileName){ }
  }
}
