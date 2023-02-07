using Fall2020_CSC403_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class Sound : Form
    {
        public int Max;
        public int Min;
        public int Value;
        public int start_pont = 100;
        private FrmLevel frmLevel;
        public static Sound instance = null;

        SoundPlayer battleMusic = new SoundPlayer(stream: Resources.battle_music);
        SoundPlayer levelMusic = new SoundPlayer(stream: Resources.level_music);


        public Sound()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Volume_slider_ValueChanged(object sender, EventArgs e)
        {
            Volume_val.Text = Volume_slider.Value.ToString();
        }
        public static Sound getInstance()
        {
            if (instance == null)
            {
                instance = new Sound();
            }
            return instance;

        }
    }
}
