using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Fall2020_CSC403_Project
{
    public partial class FrmDeath : Form
    {
        public static FrmDeath instance = null;

        private FrmDeath()
        {
            InitializeComponent();
        }

        public static FrmDeath GetInstance()
        {
            instance = new FrmDeath();
            return instance;
        }
    }
}

