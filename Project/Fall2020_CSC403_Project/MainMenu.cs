using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Fall2020_CSC403_Project.Properties;

namespace Fall2020_CSC403_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            //play Music
            SoundPlayer menuMusic = new SoundPlayer(Resources.final_battle);
            menuMusic.Play();
        }

        //Start
        private void button1_Click(object sender, EventArgs e)
        {
            FrmLevel newGame = new FrmLevel();
            newGame.Show();
            Hide();
        }

        //Quit
        private void button3_Click(object sender, EventArgs e) 
        {
            Close();
        }

        //Settings
        private void button2_Click(object sender, EventArgs e) 
        {
            Settings settings = new Settings();

            settings.Menu = this;

            settings.Show();
            
            Hide();
        }
    }
}
