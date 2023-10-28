using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGameLibrary;

namespace Fall2020_CSC403_Project
{
  public partial class FrmPause : Form
  {
        public FrmPause()
        {
          InitializeComponent();
        }

        private void FrmPause_Load(object sender, EventArgs e)
        {
      
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
          Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
          Application.Restart();  // exit and start new instance
          Environment.Exit(0);    // terminates without event handlers intervening
        }

        private void btnShow_Statistics(object sender, EventArgs e)
        {
            var stats = DatabaseHandler.get_latest_statistics();

            Console.WriteLine("Damage Taken");
            Console.WriteLine(stats.DamageTaken);
            Console.WriteLine("Damage Dealt");
            Console.WriteLine(stats.DamageDone);
            Console.WriteLine("Distance Traveled");
            Console.WriteLine(stats.DistanceTraveled);
            // TODO show new window
        }

        private void btnQuit_Click(object sender, EventArgs e)
    {
      Application.Exit();   // exit application
      Environment.Exit(0);  // terminates without event handlers intervening
    }

       
    }
}
