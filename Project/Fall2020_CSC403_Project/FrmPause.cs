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
    public partial class FrmPause : Form
    {
        public static FrmPause instance = null;

        private FrmPause()
        {
            InitializeComponent();
        }

        public static FrmPause GetInstance()
        {
            instance = new FrmPause();
            return instance;
        }


        private void resumeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
