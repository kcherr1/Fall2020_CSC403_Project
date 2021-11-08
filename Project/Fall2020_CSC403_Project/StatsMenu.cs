using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;

namespace Fall2020_CSC403_Project
{
    public partial class StatsMenu : ChildForm
    {
        public Player player;
        public StatsMenu()
        {
            Load += new System.EventHandler(StatsMenu_Load);
            InitializeComponent();
            player = Game.player;
        }

        private void StatsMenu_Load(object caller, EventArgs args)
        {
            CheckPointsAvailble();
            strengthValueLabel.Text = player.strength.ToString();
            evasionValueLabel.Text = player.evasion.ToString();
            defenseValueLabel.Text = player.defense.ToString();
        }

        private void AddDefenseButton_Click(object sender, EventArgs e)
        {
            player.AlterDefense(1);
            defenseValueLabel.Text = player.defense.ToString();
            CheckPointsAvailble();
        }

        private void AddEvasionButton_Click(object sender, EventArgs e)
        {
            player.AlterEvasion(1);
            evasionValueLabel.Text = player.evasion.ToString();
            CheckPointsAvailble();
        }

        private void AddStrengthButton_Click(object sender, EventArgs e)
        {
            player.AlterStrength(1);
            strengthValueLabel.Text = player.strength.ToString();
            CheckPointsAvailble();
        }

        private void CheckPointsAvailble()
        {
            if (player.availableStatPoints > 0)
            {
                addStrengthButton.Enabled = true;
                addEvasionButton.Enabled = true;
                addDefenseButton.Enabled = true;
            } else
            {
                addStrengthButton.Enabled = false;
                addEvasionButton.Enabled = false;
                addDefenseButton.Enabled = false;
            }
        }
    }
}
