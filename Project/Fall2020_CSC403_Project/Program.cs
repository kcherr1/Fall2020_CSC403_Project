using Fall2020_CSC403_Project.code;
using MyGameLibrary;
using System;
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

      while (true)
      {
        GameState.NextLevel();
      }

      /*
      if (GameState.startGame)
      {

        FrmLevel levelOne = new FrmLevel();
        GameState.currentLevel = levelOne;
        levelOne.ShowDialog();

        if (GameState.isLevelOneCompleted)
        {
          levelOne.Dispose();
          FrmLevel2 levelTwo = new FrmLevel2();
          GameState.currentLevel = levelTwo;
          levelTwo.ShowDialog();
        }
      }
      */

    }
  }
}
