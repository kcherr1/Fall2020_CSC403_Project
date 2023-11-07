using System;
using System.Collections.Generic;
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
      Application.Run(new FrmHome());
    }
  }
}

/* Reference Code Locations
 * 1. (menu->storyWindow>game)c# windows form overlay and with button click: https://foxlearn.com/windows-forms/how-to-create-overlay-modal-popup-in-csharp-514.html
 * 
 * 
 */
