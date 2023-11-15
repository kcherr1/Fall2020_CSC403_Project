using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project.code {
  public class GameState {
    public static Player player { get; private set; }
    public static DateTime timeStart { get; private set; }

    public static bool isLevelOneCompleted = false;
    public static bool isLevelTwoCompleted = false;
    public static bool isLevelThreeCompleted = false;

    public static bool startGame = false;

    public static bool isGamePaused = false;
    public static TimeSpan totalPausedTime = TimeSpan.Zero;

    public static Level currentLevel;
    public static int levelToLoad = 1;
    public static string saveToLoadFrom;
    public static int healthPackCountFromSave = -1;

    public static Form startScreenReference;

    //public static DateTime saveTime;

    public GameState(Player player) {
      GameState.player = player;
      
      //if (timeStart == default(DateTime))
      //{
        timeStart = DateTime.Now;
      //}
  }

    //takes file name for save files, the number of the level just so it's easy to track
    //which level is being saved, then the objects from the level that need to have their
    //fields written
    public static void SaveGame(string fileName, int levelNum, List<Character> objectsToSave)
    {

      // go through the ceremony of checking if the directory exists,
      //then making the file, then writing it
      string dir = "Food-Fight-Save\\";
      if (!Directory.Exists(dir))
      {
        Directory.CreateDirectory(dir);
      }
      string savePath = dir + fileName + "_level.csv";
      File.Create(savePath).Close();

      using (var writer = new StreamWriter(savePath))
      {
        var line = string.Format("{0},{1}", "level", levelNum);
        writer.WriteLine(line);

        line = string.Format("{0},{1}", "healthPackCount", currentLevel.healthPackCount);
        writer.WriteLine(line);

        line = string.Format("{0},{1}", "time", timeStart);//+totalPausedTime);
        writer.WriteLine(line);

        //line = string.Format("{0},{1}", "saveTime", DateTime.Now);
        //writer.WriteLine(line);

        /*
        line = string.Format("{0},{1}", "timeDifference", );
        writer.WriteLine(line);
        */
        writer.Flush();
      }

      foreach (Character character in objectsToSave)
      {
        character.Save(fileName);
      }
    }

    //this just figures out which level needs to be loaded;
    //once that is done, then the GameState will create that level and then call
    //that level object's LoadData function
    public static void LoadGame()
    {

      string basePath = "Food-Fight-Save\\" + saveToLoadFrom + "_level.csv";

      if (File.Exists(basePath))
      {
        using (var reader = new StreamReader(basePath))
        {
          string[] lines = reader.ReadToEnd().Trim().Split('\n');

          string[] split_line = lines[0].Split(',');
          levelToLoad = Convert.ToInt32(split_line[1]);

          split_line = lines[1].Split(',');
          healthPackCountFromSave = Convert.ToInt32(split_line[1]);

          split_line = lines[2].Split(',');
          timeStart = Convert.ToDateTime(split_line[1]);

        }

        NextLevel();
      }
    }

    //each level will call this to close after reaching the end condition
    public static void NextLevel()
    {

      if (startScreenReference != null)
      {
        startScreenReference.Dispose();
        startScreenReference = null;
        isGamePaused = false;
      }

      switch (levelToLoad)
      {
        case 1:
          if (startGame)
          {
            if (currentLevel != null) {
              currentLevel.Dispose();
            } 
            FrmLevel levelOne = new FrmLevel();
            currentLevel = levelOne;
            levelOne.ShowDialog();
          }
          break;

        case 2:
          if (currentLevel != null) {  
            currentLevel.Dispose();
          }
          FrmLevel2 levelTwo = new FrmLevel2();
          currentLevel = levelTwo;
          levelTwo.ShowDialog();
          break;

        default:
          break;
      }
    }
  }
}
