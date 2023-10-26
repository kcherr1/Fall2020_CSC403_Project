using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    internal class Settings : Form
    {
        private Label SettingsTitle;

        public Settings()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SettingsTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.AutoSize = true;
            this.SettingsTitle.Location = new System.Drawing.Point(12, 9);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Size = new System.Drawing.Size(68, 20);
            this.SettingsTitle.TabIndex = 0;
            this.SettingsTitle.Text = "Settings";
            // 
            // Settings
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.SettingsTitle);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
