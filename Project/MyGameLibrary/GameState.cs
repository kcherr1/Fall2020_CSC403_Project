using System;

namespace Fall2020_CSC403_Project.code {
  public class GameState {
    public static Player player { get; private set; }
    public static DateTime timeStart { get; private set; }
    //public Enemy[] enemies { get; set; }

    public static bool isLevelOneCompleted = false;
   
    public GameState(Player player, DateTime timeStart) {
      GameState.player = player;
      GameState.timeStart = timeStart;
      //this.enemies = enemies;
    }

  }
}
