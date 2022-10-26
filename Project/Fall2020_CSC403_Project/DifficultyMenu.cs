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
    public partial class DifficultyMenu : Form
    {
        public static DifficultyMenu instance = null;
        private string Dif = "Easy";
        public DifficultyMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dif = "Hard";
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dif = "Medium";
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dif = "Easy";
            this.Hide();
        }
        public static DifficultyMenu getInstance()
        {
            if (instance == null)
            {
                instance = new DifficultyMenu();
            }
            return instance;

        }
    }
}
