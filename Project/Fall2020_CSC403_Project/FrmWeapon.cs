using Fall2020_CSC403_Project.Properties;
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
    public partial class FrmWeapon : Form
    {
        public FrmWeapon()
        {
            InitializeComponent();
        }

        private void picHand_Click(object sender, EventArgs e)
        {
            ChosenWeapon.Image = picHand.Image;
            ChosenWeapon.Name = picHand.Name;
            Close();
            var picWeapon = (PictureBox)FrmLevel.ActiveForm.Controls.Find("picWeapon", true)[0];
            picWeapon.Image = ChosenWeapon.Image;
           

        }

        private void picBomb_Click(object sender, EventArgs e)
        {
            ChosenWeapon.Image = picBomb.Image;
            ChosenWeapon.Name = picBomb.Name;
            Close();
            var picWeapon = (PictureBox)FrmLevel.ActiveForm.Controls.Find("picWeapon", true)[0];
            picWeapon.Image = ChosenWeapon.Image;

        }

        private void picGun_Click(object sender, EventArgs e)
        {
            
            ChosenWeapon.Image = picGun.Image;
            ChosenWeapon.Name = picGun.Name;
            Close();
            var picWeapon = (PictureBox)FrmLevel.ActiveForm.Controls.Find("picWeapon", true)[0];
            picWeapon.Image = ChosenWeapon.Image;
            
        }

        private void picSword_Click(object sender, EventArgs e)
        {
            ChosenWeapon.Image = picSword.Image;
            ChosenWeapon.Name = picSword.Name;
            Close();
            var picWeapon = (PictureBox)FrmLevel.ActiveForm.Controls.Find("picWeapon", true)[0];
            picWeapon.Image = ChosenWeapon.Image;
        
        }

        private void FrmWeapon_Load(object sender, EventArgs e)
        {

        }
    }
}
