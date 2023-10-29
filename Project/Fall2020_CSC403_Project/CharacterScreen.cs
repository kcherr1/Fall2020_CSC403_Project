using Fall2020_CSC403_Project.code;
using System;
using System.Windows.Forms;

/*
 * This file handles the creation of the character screen which is available to
 * the player via pressing the Escape key while exploring the game. The menu shows
 * the player's current and maximum health, the player's strength (which helps govern damage),
 * the gold the player currently owns, and a settings button (see Settings.cs for info on that).
 * 
 * IMPORTANT NOTE: Running the designer for this file will not work while the code IS correct.
 * The designer does not recognize player values as of right now because Game has not been
 * initialized. If you want to use the visual studio designer to edit the screen, go and 
 * comment out the strings that use player.values located in the InitializeComponent() function 
 * and place a temporary string there to let designer run properly.
 */

namespace Fall2020_CSC403_Project
{
    public partial class CharacterScreen : Form
    {
        private Label PlayerHealth;
        private Label HealthTracker;
        private Label StrengthTitle;
        private Label StrengthTracker;
        private Label GoldTitle;
        private Label GoldCounter;
        private Label MenuBackdrop;
        private Label MenuBackdrop2;
        private Button SettingsButton;
        private Player player;

        public CharacterScreen()
        {
            // Game is static, so grab the player and its info from it.
            player = Game.player;
            InitializeComponent();
        }
        // Bulk of this function is auto-generated, please use visual designer to edit.
        // Only edit the lable text for the player health, strength, and gold manually.
        private void InitializeComponent()
        {
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.HealthTracker = new System.Windows.Forms.Label();
            this.StrengthTitle = new System.Windows.Forms.Label();
            this.StrengthTracker = new System.Windows.Forms.Label();
            this.GoldTitle = new System.Windows.Forms.Label();
            this.GoldCounter = new System.Windows.Forms.Label();
            this.MenuBackdrop = new System.Windows.Forms.Label();
            this.MenuBackdrop2 = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PlayerHealth.Location = new System.Drawing.Point(28, 54);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(134, 25);
            this.PlayerHealth.TabIndex = 0;
            this.PlayerHealth.Text = "Player Health:";
            this.PlayerHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealthTracker
            // 
            this.HealthTracker.AutoSize = true;
            this.HealthTracker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HealthTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.HealthTracker.Location = new System.Drawing.Point(33, 79);
            this.HealthTracker.Name = "HealthTracker";
            this.HealthTracker.Size = new System.Drawing.Size(0, 22);
            this.HealthTracker.TabIndex = 1;
            this.HealthTracker.Text = "" + player.Health + "/" + player.MaxHealth;
            // 
            // StrengthTitle
            // 
            this.StrengthTitle.AutoSize = true;
            this.StrengthTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StrengthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.StrengthTitle.Location = new System.Drawing.Point(28, 122);
            this.StrengthTitle.Name = "StrengthTitle";
            this.StrengthTitle.Size = new System.Drawing.Size(152, 25);
            this.StrengthTitle.TabIndex = 2;
            this.StrengthTitle.Text = "Player Strength:";
            // 
            // StrengthTracker
            // 
            this.StrengthTracker.AutoSize = true;
            this.StrengthTracker.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StrengthTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.StrengthTracker.Location = new System.Drawing.Point(33, 147);
            this.StrengthTracker.Name = "StrengthTracker";
            this.StrengthTracker.Size = new System.Drawing.Size(0, 22);
            this.StrengthTracker.TabIndex = 3;
            this.StrengthTracker.Text = "" + player.getStrength();
            // 
            // GoldTitle
            // 
            this.GoldTitle.AutoSize = true;
            this.GoldTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GoldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GoldTitle.Location = new System.Drawing.Point(29, 184);
            this.GoldTitle.Name = "GoldTitle";
            this.GoldTitle.Size = new System.Drawing.Size(127, 25);
            this.GoldTitle.TabIndex = 4;
            this.GoldTitle.Text = "Owned Gold:";
            // 
            // GoldCounter
            // 
            this.GoldCounter.AutoSize = true;
            this.GoldCounter.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GoldCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GoldCounter.Location = new System.Drawing.Point(33, 209);
            this.GoldCounter.Name = "GoldCounter";
            this.GoldCounter.Size = new System.Drawing.Size(0, 22);
            this.GoldCounter.TabIndex = 5;
            this.GoldCounter.Text = player.gold.ToString();
            // 
            // MenuBackdrop
            // 
            this.MenuBackdrop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuBackdrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MenuBackdrop.Location = new System.Drawing.Point(11, 9);
            this.MenuBackdrop.Name = "MenuBackdrop";
            this.MenuBackdrop.Size = new System.Drawing.Size(237, 253);
            this.MenuBackdrop.TabIndex = 6;
            this.MenuBackdrop.Text = "Stats";
            this.MenuBackdrop.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuBackdrop2
            // 
            this.MenuBackdrop2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MenuBackdrop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MenuBackdrop2.Location = new System.Drawing.Point(285, 9);
            this.MenuBackdrop2.Name = "MenuBackdrop2";
            this.MenuBackdrop2.Size = new System.Drawing.Size(237, 253);
            this.MenuBackdrop2.TabIndex = 7;
            this.MenuBackdrop2.Text = "Options";
            this.MenuBackdrop2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoSize = true;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SettingsButton.Location = new System.Drawing.Point(309, 54);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(190, 35);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // CharacterScreen
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(534, 272);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.GoldCounter);
            this.Controls.Add(this.GoldTitle);
            this.Controls.Add(this.StrengthTracker);
            this.Controls.Add(this.StrengthTitle);
            this.Controls.Add(this.HealthTracker);
            this.Controls.Add(this.PlayerHealth);
            this.Controls.Add(this.MenuBackdrop);
            this.Controls.Add(this.MenuBackdrop2);
            this.Name = "CharacterScreen";
            this.Text = "Chacacter Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

        // Updates the red bar to fill up based on the player's current Health.
        private void UpdateHealthBar()
        {

        }
    }
}
