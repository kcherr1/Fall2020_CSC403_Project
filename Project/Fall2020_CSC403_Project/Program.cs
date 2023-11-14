using Fall2020_CSC403_Project.code;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //GameState gameState = null;

      FrmStartScreen startScreen = new FrmStartScreen();
      startScreen.ShowDialog();

      //prevents the player from closing the window and starting the game anyway
      if (GameState.startGame)
      {

        FrmLevel levelOne = new FrmLevel();
        levelOne.ShowDialog();

      //levelOne = null;
      //GC.Collect();
      if (GameState.isLevelOneCompleted)
      {
        levelOne.Dispose();
        FrmLevel2 levelTwo = new FrmLevel2();
        levelTwo.ShowDialog();

        if (GameState.isLevelTwoCompleted) {
          levelTwo.Dispose();
          FrmLevel3 levelThree = new FrmLevel3();
          levelThree.ShowDialog();
        }
      }

      //GC.KeepAlive(gameState);
    }
  }
}
