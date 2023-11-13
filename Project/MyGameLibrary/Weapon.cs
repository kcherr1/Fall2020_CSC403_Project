using System;
using System.Collections;
using System.IO;

namespace Fall2020_CSC403_Project.code{
  public class Weapon : Character{

    public event Action<int> AttackEvent;

    private int strength;

    public string Name;

    public Weapon(Vector2 initPos, Collider collider) : base(initPos, collider){
      strength = 0;
    }

    public int getStrength(){
      return strength;
    }

    public void setStrength(int strength){
      this.strength = strength;
    }

    public override void Save(string fileName)
    {
      //putting all vals into a hashtable makes it easier to write all to a csv
      Hashtable vals = new Hashtable
      {

        { "strength", strength },

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

      strength = Convert.ToInt32(vals["strength"]);

    }
  }
}
