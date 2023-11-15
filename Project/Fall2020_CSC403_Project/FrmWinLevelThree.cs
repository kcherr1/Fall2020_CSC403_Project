using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmWinLevelThree : Form {
    public static FrmWinLevelThree instance = null;
    public FrmWinLevelThree() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      Application.Restart();
      Environment.Exit(0);
    }

    public static FrmWinLevelThree GetInstance() {
      if (instance == null) {
        instance = new FrmWinLevelThree();
        //instance.Setup();
      }
      return instance;
    }

    private void button2_Click(object sender, EventArgs e) {
      Environment.ExitCode = 1;
      Application.Exit();
    }

    public void FrmWinLevelThree_Load(object sender, EventArgs e)
    {

    }
  }
}
