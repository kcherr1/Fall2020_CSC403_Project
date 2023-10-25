using System;
using System.Collections.Generic;
using System.Drawing;
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
      // start program by opening menu
      Menu menu = new Menu();
      menu.Size = new Size(800, 450);
      Application.Run(menu);
    }
  }
}
