using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

    public override void Save(string fileName)
    {
      Hashtable vals = new Hashtable();

      vals.Add("Health", Health);
      vals.Add("MaxHealth",MaxHealth);
      vals.Add("strength",strength);
      vals.Add("experience", experience);
      vals.Add("HealthPackCount", HealthPackCount);
      vals.Add("WeaponStrength",WeaponStrength);
      vals.Add("WeaponEquipped",WeaponEquiped);

      /*
      string savePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                        + "\\Food-Fight-Save\\"+fileName + "_player.csv";

      if (!Directory.Exists(savePath))
      {
        Directory.CreateDirectory(savePath);
      }

      using (var writer = new StreamWriter(savePath))
      */
      string savePath = "Food-Fight-Save\\" + fileName + "_player.csv";
      if (!Directory.Exists(savePath))
      {
        Directory.CreateDirectory(savePath);
      }

      using (var writer = new StreamWriter(savePath))
      {   
          foreach ( var item in vals.Values) {
            var line = string.Format("{0},{1}", item, vals[item]);
            writer.WriteLine(line);
            writer.Flush();
        }
      }

    }
  }
}
