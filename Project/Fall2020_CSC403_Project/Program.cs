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
      GameState gameState = null;
      
      FrmLevel levelOne = new FrmLevel();
      levelOne.ShowDialog();

      if (GameState.isLevelOneCompleted)
      {
          levelOne.Close();
          FrmLevel2 levelTwo = new FrmLevel2();
          levelTwo.ShowDialog();
      }

      GC.KeepAlive(gameState);
    }
  }
}
