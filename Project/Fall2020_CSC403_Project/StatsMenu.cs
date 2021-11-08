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
            KeyDown += new System.Windows.Forms.KeyEventHandler(StatsMenu_KeyDown);
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

        private void AddDefenseLabel_Click(object sender, EventArgs e)
        {
            Game.player.AlterDefense(1);
            defenseValueLabel.Text = Game.player.defense.ToString();
            Game.player.alterAvailableStatPoints(-1);
            CheckPointsAvailble();
        }

        private void AddEvasionLabel_Click(object sender, EventArgs e)
        {
            Game.player.AlterEvasion(1);
            evasionValueLabel.Text = Game.player.evasion.ToString();
            Game.player.alterAvailableStatPoints(-1);
            CheckPointsAvailble();
        }

        private void AddStrengthLabel_Click(object sender, EventArgs e)
        {
            Game.player.AlterStrength(1);
            strengthValueLabel.Text = Game.player.strength.ToString();
            Game.player.alterAvailableStatPoints(-1);
            CheckPointsAvailble();
        }

        private void CheckPointsAvailble()
        {
            availablePointsLabel.Text = Game.player.availableStatPoints.ToString();

            if (Game.player.availableStatPoints > 0)
            {
                addStrengthLabel.Enabled = true;
                addEvasionLabel.Enabled = true;
                addDefenseLabel.Enabled = true;
            } else
            {
                addStrengthLabel.Enabled = false;
                addEvasionLabel.Enabled = false;
                addDefenseLabel.Enabled = false;
            }
        }


       private void StatsMenu_KeyDown(object caller, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P)
            {
                FrmLevel f = (FrmLevel)Creator;
                f.statsMenu = null;
                f.RequestShow();
                f.StartPlayerMoveTimer();
                Close();
            }
        }
    }
}
