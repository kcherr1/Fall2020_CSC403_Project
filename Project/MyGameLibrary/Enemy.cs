using System.Drawing;

namespace Fall2020_CSC403_Project.code {
  /// <summary>
  /// This is the class for an enemy
  /// </summary>
  public class Enemy : BattleCharacter {
    /// <summary>
    /// THis is the image for an enemy
    /// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// this is the background color for the fight form for this enemy
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initPos">this is the initial position of the enemy</param>
    /// <param name="collider">this is the collider for the enemy</param>
    /// <param name="strength">this is the enemy strength</param>
    /// <param name="evasion">this is the enemy evasion</param>
    /// <param name="defense">this is the enemy defense</param>
    public Enemy(Vector2 initPos, Collider collider, float strength, float evasion, float defense) : base(initPos, collider, strength, evasion, defense) {
    }
  }
}
