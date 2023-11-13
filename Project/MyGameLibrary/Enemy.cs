using System.Collections;
using System;
using System.Drawing;
using System.IO;

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

    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initPos">this is the initial position of the enemy</param>
    /// <param name="collider">this is the collider for the enemy</param>
    public Enemy(Vector2 initPos, Collider collider, int MaxHealth = 20) : base(initPos, collider, MaxHealth) {
    }

    //overrides the Character Save function
    public override void Save(string fileName)
    {
      //putting all vals into a hashtable makes it easier to write all to a csv
      Hashtable vals = new Hashtable
      {
        { "Health", Health },
        { "MaxHealth", MaxHealth },
        { "strength", strength },
        { "experience", experience },
        {"IsAlive", IsAlive }
      };

      // go through the ceremony of checking if the directory exists,
      //then making the file, then writing it
      string dir = "Food-Fight-Save\\";
      if (!Directory.Exists(dir))
      {
        Directory.CreateDirectory(dir);
      }
      string savePath = dir + fileName + "_" + Name + ".csv";
      File.Create(savePath).Close();

      using (var writer = new StreamWriter(savePath))
      {
        foreach (var item in vals.Keys)
        {
          var line = string.Format("{0},{1}", item, vals[item]);
          writer.WriteLine(line);
          writer.Flush();
        }
      }

    }

    //overrides the Character's Load function
    public override void Load(string fileName)
    {

      Hashtable vals = new Hashtable();

      string savePath = "Food-Fight-Save\\" + fileName + "_" + Name + ".csv";

      using (var reader = new StreamReader(savePath))
      {
        string[] lines = reader.ReadToEnd().Trim().Split('\n');

        foreach (var line in lines)
        {
          string[] split_line = line.Split(',');
          vals.Add(
            split_line[0],
            split_line[1]
           );
        }
      }

      Health = Convert.ToInt32(vals["Health"]);
      MaxHealth = Convert.ToInt32(vals["MaxHealth"]);
      strength = Convert.ToInt32(vals["strength"]);
      experience = Convert.ToInt32(vals["experience"]);
      IsAlive = Convert.ToBoolean(vals["IsAlive"]);

    }
  }
}
