using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  /// <summary>
  /// This is the class for an enemy
  /// </summary>
  public class Enemy : BattleCharacter {
    /// <summary>
    /// This is the image for an enemy during a fight
    /// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// This is the image for an enemy on the map
    /// </summary>
    public PictureBox Icon { get; set; }

    /// <summary>
    /// this is the background color for the fight form for this enemy
    /// </summary>
    public Color Color { get; set; }
    public event Action<Enemy> OnDeathHandler;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initPos">this is the initial position of the enemy</param>
    /// <param name="collider">this is the collider for the enemy</param>
    public Enemy(Vector2 initPos, Collider collider, PictureBox pic, Color color, Action<Enemy> OnDeath) : base(initPos, collider) {
      Icon = pic;
      Color = color;
      Img = pic.BackgroundImage;
      OnDeathHandler += OnDeath;
    }

    public void OnDeath()
    {
      OnDeathHandler(this);
    }
  }
}
