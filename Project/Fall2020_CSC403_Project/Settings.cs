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
        private Label SettingsBackdrop;
        private Button NormalSize;
        private Button Maximize;
        private Button BGMusicToggle;
        private Label SettingsTitle;

        public Settings()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SettingsTitle = new System.Windows.Forms.Label();
            this.SettingsBackdrop = new System.Windows.Forms.Label();
            this.NormalSize = new System.Windows.Forms.Button();
            this.Maximize = new System.Windows.Forms.Button();
            this.BGMusicToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsTitle
            // 
            this.SettingsTitle.AutoSize = true;
            this.SettingsTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SettingsTitle.Location = new System.Drawing.Point(125, 9);
            this.SettingsTitle.Name = "SettingsTitle";
            this.SettingsTitle.Size = new System.Drawing.Size(118, 32);
            this.SettingsTitle.TabIndex = 0;
            this.SettingsTitle.Text = "Settings";
            // 
            // SettingsBackdrop
            // 
            this.SettingsBackdrop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingsBackdrop.Location = new System.Drawing.Point(12, 41);
            this.SettingsBackdrop.Name = "SettingsBackdrop";
            this.SettingsBackdrop.Size = new System.Drawing.Size(354, 194);
            this.SettingsBackdrop.TabIndex = 1;
            // 
            // NormalSize
            // 
            this.NormalSize.AutoSize = true;
            this.NormalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NormalSize.Location = new System.Drawing.Point(119, 61);
            this.NormalSize.Name = "NormalSize";
            this.NormalSize.Size = new System.Drawing.Size(128, 35);
            this.NormalSize.TabIndex = 2;
            this.NormalSize.Text = "Normal Size";
            this.NormalSize.UseVisualStyleBackColor = true;
            this.NormalSize.Click += new System.EventHandler(this.NormalSize_Click);
            // 
            // Maximize
            // 
            this.Maximize.AutoSize = true;
            this.Maximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Maximize.Location = new System.Drawing.Point(131, 102);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(105, 35);
            this.Maximize.TabIndex = 3;
            this.Maximize.Text = "Maximize";
            this.Maximize.UseVisualStyleBackColor = true;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // BGMusicToggle
            // 
            this.BGMusicToggle.AutoSize = true;
            this.BGMusicToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BGMusicToggle.Location = new System.Drawing.Point(58, 143);
            this.BGMusicToggle.Name = "BGMusicToggle";
            this.BGMusicToggle.Size = new System.Drawing.Size(250, 35);
            this.BGMusicToggle.TabIndex = 4;
            this.BGMusicToggle.Text = "Toggle Background Music";
            this.BGMusicToggle.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.BGMusicToggle);
            this.Controls.Add(this.Maximize);
            this.Controls.Add(this.NormalSize);
            this.Controls.Add(this.SettingsTitle);
            this.Controls.Add(this.SettingsBackdrop);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        public void NormalSize_Click(object sender, EventArgs e)
        {
            Program.frame.WindowState = FormWindowState.Normal;
            this.Focus();
        }
        public void Maximize_Click(object sender, EventArgs e)
        {
            Program.frame.WindowState = FormWindowState.Maximized;
            this.Focus();
        }
        public void toggleBGMusic(object sender, EventArgs e)
        {

        }
    }
}
