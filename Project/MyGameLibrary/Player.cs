using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Fall2020_CSC403_Project.code {
  public class Player : BattleCharacter {

    public int level { get; private set; }
    public int experiencePerLevel { get; private set; }

    public Player(Vector2 initPos, Collider collider) : base(initPos, collider) {

      this.experience = 0;
      this.level = 1;
      //helps calculate the player's level;
      //can be changed to increase how much experience is needed before leveling up
      this.experiencePerLevel = 20;
    }
    public void EarnExperience(int experienceToGain) {
      this.experience += experienceToGain;
            
      if (this.experience / this.experiencePerLevel >= 1 )
      {
        this.experience = 0;
        this.level += 1;
        this.MaxHealth += 5;
        this.Health += 5; //player gets a chance to heal a little after leveling up
        this.strength += 2;
      }
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
        { "HealthPackCount", HealthPackCount },
        { "WeaponStrength", WeaponStrength },
        { "WeaponEquipped", WeaponEquiped },
        {"X", Position.x },
        {"Y", Position.y },
      };

      // go through the ceremony of checking if the directory exists,
      //then making the file, then writing it
      string dir = "Food-Fight-Save\\";
      if (!Directory.Exists(dir))
      {
        Directory.CreateDirectory(dir);
      }
      string savePath = dir + fileName + "_player.csv";
      File.Create(savePath).Close();

      using (var writer = new StreamWriter(savePath))
      {   
          foreach ( var item in vals.Keys) {
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

      string savePath = "Food-Fight-Save\\" + fileName + "_player.csv";
      
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
      HealthPackCount = Convert.ToInt32(vals["HealthPackCount"]);
      WeaponStrength = Convert.ToInt32(vals["WeaponStrength"]);
      WeaponEquiped = Convert.ToBoolean(vals["WeaponEquiped"]);

      Position = new Vector2(
        Convert.ToSingle(vals["X"]),
        Convert.ToSingle(vals["Y"])
      );

    }
  }
}
