using System;
using System.Windows.Forms;
using Fall2020_CSC403_Project.code;
using MyGameLibrary.InventoryObjects;

namespace Fall2020_CSC403_Project
{
    public partial class FrmExperience : Form
    {
        private int allocatedExperience = 0;
        private Experience experience;
        private Player player;

        public FrmExperience(Experience experience, Player player)
        {
            this.experience = experience;
            this.player = player;
            InitializeComponent();
            this.ExperienceDisplay.Text = experience.Count.ToString();
        }

        private void rBtnAttack_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnDefence.Checked)
            {
                rBtnDefence.Checked = false;
            }
        }

        private void rBtnDefence_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnAttack.Checked)
            {
                rBtnAttack.Checked = false;
            }
        }

        private void AllocatedExperience_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if(nud.Value <= experience.Count)
            {
                allocatedExperience = (int)nud.Value;
            }
            else
            {
                nud.Value = experience.Count;
            }

        }

        // Applies the experience value from the form to the player's level.
        private void ApplyExperience_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (allocatedExperience <= experience.Count)
            {
                if (rBtnAttack.Checked)
                {
                    MyGameLibrary.Stats.Skills attack = MyGameLibrary.Stats.Skills.Attack;
                    player.Stats.AddExperience(attack,allocatedExperience);
                    experience.Count -= allocatedExperience;
                    AllocatedExperience.Value = 0;
                    ExperienceDisplay.Text = experience.Count.ToString();
                }
                else if(rBtnDefence.Checked)
                {
                    MyGameLibrary.Stats.Skills defence = MyGameLibrary.Stats.Skills.Defence;
                    player.Stats.AddExperience(defence, allocatedExperience);
                    experience.Count -= allocatedExperience;
                    AllocatedExperience.Value = 0;
                    ExperienceDisplay.Text = experience.Count.ToString();
                }
            }
            if(experience.Count == 0)
            {
                this.Close();
            }
        }
    }
}
