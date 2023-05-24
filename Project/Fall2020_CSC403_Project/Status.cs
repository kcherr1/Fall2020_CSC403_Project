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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label5.Text = Properties.Settings.Default.Health.ToString();
            this.label6.Text = Properties.Settings.Default.WeaponDamage.ToString();
            this.label7.Text = Properties.Settings.Default.ArmorProtection.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
