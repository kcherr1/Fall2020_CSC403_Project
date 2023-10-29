using Fall2020_CSC403_Project.code;
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
  public partial class FrmPlayerDeath : Form
  {
    public static FrmPlayerDeath instance = null;
    public FrmPlayerDeath()
    {
      InitializeComponent();
    }

    public static FrmPlayerDeath GetInstance()
    {
      if (instance == null)
      {
        instance = new FrmPlayerDeath();
        //instance.Setup();
      }
      return instance;
    }

    // Player clicked "Yes" to restart game
    private void button1_Click(object sender, EventArgs e)
    {
      Application.Restart();
      Environment.Exit(0);
    }

    // Player clicked "No" to restart game
    private void button2_Click(object sender, EventArgs e)
    {
      Environment.Exit(0);
    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
  }
}
