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


        public static FrmInv GetInstance(Player player)
        {
            instance = new FrmInv();
            return instance;
        }

        private void FrmInv_Load(object sender, EventArgs e)
        {

        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {

        }

        private void UnequipButton_Click(object sender, EventArgs e)
        {

        }

        private void EquipButton_Click(object sender, EventArgs e)
        {

        }

        private void DropButton_Click(object sender, EventArgs e)
        {

        }
    }
}
