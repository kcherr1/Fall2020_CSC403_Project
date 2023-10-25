using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class CharacterScreen : Form
    {
        private Label PlayerHealth;

        public CharacterScreen()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.Location = new System.Drawing.Point(27, 25);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(35, 13);
            this.PlayerHealth.TabIndex = 0;
            this.PlayerHealth.Text = "label1";
            this.PlayerHealth.Click += new System.EventHandler(this.PlayerHealth_Click);
            // 
            // CharacterScreen
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.PlayerHealth);
            this.Name = "CharacterScreen";
            this.Text = "Chacacter Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PlayerHealth_Click(object sender, EventArgs e)
        {

        }
    }
}
