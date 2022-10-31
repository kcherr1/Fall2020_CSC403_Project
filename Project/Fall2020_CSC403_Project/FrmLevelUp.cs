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

    public partial class FrmLevelUp : Form
    {
        public static FrmLevelUp instance = null;
        private Player player;
        String skillpoints = null;
        public FrmLevelUp()
        {
            InitializeComponent();
            player = Game.player;
            UpdateSkillPoints();
        }
        private void UpdateSkillPoints()
        {
            skillpoints = player.skillPoints.ToString();
            textBox1.Text = "Skill points remaining: " + skillpoints;
            attackButton.Text = "Attack = " + player.playerStrength;
            defenseButton.Text = "Defense = " + player.playerDefense;
            speedButton.Text = "Speed = " + player.playerSpeed;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (player.skillPoints >= 1) 
            {
                player.playerDefense += 1;
                player.skillPoints -= 1;
                UpdateSkillPoints();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (player.skillPoints >= 1) 
            {
                player.playerSpeed += 1;
                player.skillPoints -= 1;
                UpdateSkillPoints();
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (player.skillPoints >= 1) 
            {
                player.playerStrength += 1;
                player.skillPoints -= 1;
                UpdateSkillPoints();
            }

        }
        public static FrmLevelUp getInstance()
        {
            if (instance == null)
            {
                instance = new FrmLevelUp();
            }
            return instance;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
