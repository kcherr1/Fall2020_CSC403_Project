using System;

namespace Fall2020_CSC403_Project.code {
  public class GameState {
    public Player player { get; private set; }
    public DateTime timeStart { get; private set; }
    //public Enemy[] enemies { get; set; }

    public GameState(Player player, DateTime timeStart) {
      this.player = player;
      this.timeStart = timeStart;
      //this.enemies = enemies;
    }
  }
}
