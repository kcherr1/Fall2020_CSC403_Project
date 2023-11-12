using System;
using System.Collections.Generic;
using System.IO;

namespace Fall2020_CSC403_Project.code {
  public class GameState {
    public static Player player { get; private set; }
    public static DateTime timeStart { get; private set; }

    public static bool isLevelOneCompleted = false;
    public static bool isLevelTwoCompleted = false;

    public static bool startGame = false;

    public static bool isGamePaused = false;
    public static TimeSpan totalPausedTime = TimeSpan.Zero;

    public static Level currentLevel;
    public static int levelToLoad = 1;

    public GameState(Player player, DateTime timeStart) {
      GameState.player = player;
      GameState.timeStart = timeStart;
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
    public static void LoadGame(string fileName)
    {

      string basePath = "Food-Fight-Save\\" + fileName;
        
      using (var reader = new StreamReader(basePath))
      {
        string[] lines = reader.ReadLine().Trim().Split('\n');

        foreach (var line in lines)
        {
          string[] split_line = line.Split(',');

          levelToLoad = Convert.ToInt32(split_line[1]);
        }
      }

      currentLevel.Close();
    }

    public static void NextLevel()
    {
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
          if (isLevelOneCompleted)
          {
            currentLevel.Dispose();
            FrmLevel2 levelTwo = new FrmLevel2();
            currentLevel = levelTwo;
            levelTwo.ShowDialog();
          }
          break;

        default:
          break;
      }
    }
  }
}
