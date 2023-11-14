using System.Media;
namespace Fall2020_CSC403_Project
{
    partial class FrmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            this.menuTheme.Stop();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
      this.btnStartGame = new System.Windows.Forms.Button();
      this.btnLeaveGame = new System.Windows.Forms.Button();
      this.btnSettings = new System.Windows.Forms.Button();
      this.btnBack = new System.Windows.Forms.Button();
      this.lblSettings = new System.Windows.Forms.Label();
      this.lblVolume = new System.Windows.Forms.Label();
      this.menuImage = new System.Windows.Forms.PictureBox();
      this.menuTheme = new System.Media.SoundPlayer();
      this.volumeBar = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.menuImage)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
      this.SuspendLayout();
      // 
      // btnStartGame
      // 
      this.btnStartGame.BackColor = System.Drawing.Color.Black;
      this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartGame.ForeColor = System.Drawing.Color.White;
      this.btnStartGame.Location = new System.Drawing.Point(338, 283);
      this.btnStartGame.Name = "btnStartGame";
      this.btnStartGame.Size = new System.Drawing.Size(128, 43);
      this.btnStartGame.TabIndex = 2;
      this.btnStartGame.Text = "Start";
      this.btnStartGame.UseVisualStyleBackColor = false;
      this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
      // 
      // btnLeaveGame
      // 
      this.btnLeaveGame.BackColor = System.Drawing.Color.Black;
      this.btnLeaveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLeaveGame.ForeColor = System.Drawing.Color.White;
      this.btnLeaveGame.Location = new System.Drawing.Point(338, 381);
      this.btnLeaveGame.Name = "btnLeaveGame";
      this.btnLeaveGame.Size = new System.Drawing.Size(128, 43);
      this.btnLeaveGame.TabIndex = 2;
      this.btnLeaveGame.Text = "Quit";
      this.btnLeaveGame.UseVisualStyleBackColor = false;
      this.btnLeaveGame.Click += new System.EventHandler(this.btnLeaveGame_Click);
      // 
      // btnSettings
      // 
      this.btnSettings.BackColor = System.Drawing.Color.Black;
      this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSettings.ForeColor = System.Drawing.Color.White;
      this.btnSettings.Location = new System.Drawing.Point(338, 332);
      this.btnSettings.Name = "btnSettings";
      this.btnSettings.Size = new System.Drawing.Size(128, 43);
      this.btnSettings.TabIndex = 2;
      this.btnSettings.Text = "Settings";
      this.btnSettings.UseVisualStyleBackColor = false;
      this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
      // 
      // btnBack
      // 
      this.btnBack.BackColor = System.Drawing.Color.Black;
      this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBack.ForeColor = System.Drawing.Color.White;
      this.btnBack.Location = new System.Drawing.Point(338, 300);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(128, 43);
      this.btnBack.TabIndex = 2;
      this.btnBack.Text = "Back";
      this.btnBack.UseVisualStyleBackColor = false;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // lblSettings
      // 
      this.lblSettings.BackColor = System.Drawing.Color.Black;
      this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSettings.ForeColor = System.Drawing.Color.White;
      this.lblSettings.Location = new System.Drawing.Point(301, 38);
      this.lblSettings.Name = "lblSettings";
      this.lblSettings.Size = new System.Drawing.Size(216, 85);
      this.lblSettings.TabIndex = 6;
      this.lblSettings.Text = "Settings";
      this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblSettings.Click += new System.EventHandler(this.lblTitle_Click);
      // 
      // lblVolume
      // 
      this.lblVolume.BackColor = System.Drawing.Color.Black;
      this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVolume.ForeColor = System.Drawing.Color.White;
      this.lblVolume.Location = new System.Drawing.Point(354, 137);
      this.lblVolume.Name = "lblVolume";
      this.lblVolume.Size = new System.Drawing.Size(88, 34);
      this.lblVolume.TabIndex = 6;
      this.lblVolume.Text = "Volume";
      this.lblVolume.Click += new System.EventHandler(this.lblTitle_Click);
      // 
      // menuImage
      // 
      this.menuImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuImage.BackgroundImage")));
      this.menuImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.menuImage.Location = new System.Drawing.Point(0, 0);
      this.menuImage.Name = "menuImage";
      this.menuImage.Size = new System.Drawing.Size(803, 453);
      this.menuImage.TabIndex = 1;
      this.menuImage.TabStop = false;
      // 
      // menuTheme
      // 
      this.menuTheme.LoadTimeout = 10000;
      this.menuTheme.SoundLocation = "menu_theme.wav";
      this.menuTheme.Stream = null;
      this.menuTheme.Tag = null;
      // 
      // volumeBar
      // 
      this.volumeBar.Location = new System.Drawing.Point(324, 203);
      this.volumeBar.Maximum = 100;
      this.volumeBar.Name = "volumeBar";
      this.volumeBar.Size = new System.Drawing.Size(142, 45);
      this.volumeBar.TabIndex = 7;
      this.volumeBar.TickFrequency = 5;
      this.volumeBar.Value = 20;
      this.volumeBar.BackColor = System.Drawing.Color.Black;
      this.volumeBar.Scroll += new System.EventHandler(this.changeMusicVolume);
      // 
      // FrmMainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblSettings);
      this.Controls.Add(this.lblVolume);
      this.Controls.Add(this.btnStartGame);
      this.Controls.Add(this.btnLeaveGame);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.btnSettings);
      this.Controls.Add(this.volumeBar);
      this.Controls.Add(this.menuImage);
      this.Name = "FrmMainMenu";
      this.Text = "Main Menu";
      ((System.ComponentModel.ISupportInitialize)(this.menuImage)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox menuImage;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnLeaveGame;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TrackBar volumeBar;
        SoundPlayer menuTheme = new SoundPlayer("menu_theme.wav");
    }
}