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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public Form Menu { get; set; }



        //go back
        private void startButton_Click(object sender, EventArgs e)
        {
            //MainMenu menu = new MainMenu();
            Menu.Show();
            Close();
        }

        //maximize window
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
