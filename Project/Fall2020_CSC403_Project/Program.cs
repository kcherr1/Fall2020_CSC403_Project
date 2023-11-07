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
      
      FrmLevel levelOne = new FrmLevel();
      levelOne.ShowDialog();

      //levelOne = null;
      //GC.Collect();
      Debug.WriteLine(GameState.isLevelOneCompleted);
      if (GameState.isLevelOneCompleted)
      {
        Debug.WriteLine(GameState.isLevelTwoCompleted);
        levelOne.Dispose();
        FrmLevel2 levelTwo = new FrmLevel2();
        levelTwo.ShowDialog();
        Debug.WriteLine(GameState.isLevelTwoCompleted);

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
