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
    public partial class FrmInv : Form
    {
        public static FrmInv instance = null;
        private Enemy enemy;
        private Player player;

        public FrmInv()
        {
            InitializeComponent();
        }


        public static FrmInv GetInstance()
        {
            instance = new FrmInv();
            return instance;
        }
    }
}
