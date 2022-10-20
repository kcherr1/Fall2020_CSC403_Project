using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      Console.WriteLine("Resume Clicked");
    }

    private void btnRestart_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Restart Clicked");
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
      Console.WriteLine("Quit Clicked");
    }
  }
}
