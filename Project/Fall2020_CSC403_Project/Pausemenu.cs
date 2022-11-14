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
    public partial class Pausemenu : Form
    {
        public static Pausemenu instance = null;
        public DifficultyMenu difMenu = DifficultyMenu.getInstance();
        public Sound SoundMenu = Sound.getInstance();
        //public FrmLevelUp ExpMenu = FrmLevelUp.getInstance();
        public Pausemenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel.psMenuUp = false;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            difMenu.Show();
        }
        public static Pausemenu getInstance()
        {
            if (instance == null)
            {
                instance = new Pausemenu();
            }
            return instance;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundMenu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmBattle.lvlUpMenu.Show();
        }
    }
}
